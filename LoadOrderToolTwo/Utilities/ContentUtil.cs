﻿using Extensions;

using LoadOrderToolTwo.Domain;
using LoadOrderToolTwo.Domain.Enums;
using LoadOrderToolTwo.Domain.Interfaces;
using LoadOrderToolTwo.Domain.Utilities;
using LoadOrderToolTwo.Utilities.Managers;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LoadOrderToolTwo.Utilities;
internal class ContentUtil
{
	public const string EXCLUDED_FILE_NAME = ".excluded";

	private static readonly object _contentUpdateLock = new();

	public static IEnumerable<ulong> GetSubscribedItems()
	{
		foreach (var path in GetSubscribedItemPaths())
		{
			yield return ulong.Parse(Path.GetFileName(path));
		}
	}

	public static IEnumerable<string> GetSubscribedItemPaths()
	{
		if (!Directory.Exists(LocationManager.WorkshopContentPath))
		{
			yield break;
		}

		foreach (var path in Directory.EnumerateDirectories(LocationManager.WorkshopContentPath))
		{
			if (ulong.TryParse(Path.GetFileName(path), out _))
			{
				yield return path;
			}
		}
	}

	public static string GetSubscribedItemPath(ulong id)
	{
		return Path.Combine(LocationManager.WorkshopContentPath, id.ToString());
	}

	public static DateTime GetLocalUpdatedTime(string path)
	{
		var dateTime = DateTime.MinValue;

		if (Directory.Exists(path))
		{
			foreach (var filePAth in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
			{
				if (Path.GetFileName(filePAth) != EXCLUDED_FILE_NAME)
				{
					var lastWriteTimeUtc = File.GetLastWriteTimeUtc(filePAth);

					if (lastWriteTimeUtc > dateTime)
					{
						dateTime = lastWriteTimeUtc;
					}
				}
			}
		}

		return dateTime;
	}

	public static DateTime GetLocalSubscribeTime(string path)
	{
		var dateTime = DateTime.MaxValue;

		if (Directory.Exists(path))
		{
			foreach (var filePAth in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
			{
				if (Path.GetFileName(filePAth) != EXCLUDED_FILE_NAME)
				{
					var lastWriteTimeUtc = File.GetCreationTimeUtc(filePAth);

					if (lastWriteTimeUtc < dateTime)
					{
						dateTime = lastWriteTimeUtc;
					}
				}
			}
		}

		return dateTime;
	}

	public static long GetTotalSize(string path)
	{
		var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
		return files.Sum(f => new FileInfo(f).Length);
	}

	internal static List<Package> LoadContents()
	{
		var packages = new List<Package>();
		var gameModsPath = Path.Combine(LocationManager.GameContentPath, "Mods");
		var addonsModsPath = LocationManager.ModsPath;
		var addonsAssetsPath = new[]
		{
			LocationManager.AssetsPath,
			LocationManager.StylesPath,
			LocationManager.MapThemesPath
		};

		foreach (var folder in addonsAssetsPath)
		{
			getPackage(folder, false, false);
		}

		if (Directory.Exists(gameModsPath))
		{
			foreach (var folder in Directory.GetDirectories(gameModsPath))
			{
				getPackage(folder, true, false);
			}
		}

		if (Directory.Exists(addonsModsPath))
		{
			foreach (var folder in Directory.GetDirectories(addonsModsPath))
			{
				getPackage(folder, false, false);
			}
		}

		var subscribedItems = GetSubscribedItemPaths().ToList();

		Parallel.ForEach(subscribedItems, (folder, state) =>
		{
			getPackage(folder, false, true);
		});

		return packages;

		void getPackage(string folder, bool builtIn, bool workshop)
		{
			if (!Directory.Exists(folder))
			{
				return;
			}

			var package = new Package(folder, builtIn, workshop);

			package.Assets = AssetsUtil.GetAssets(package).ToArray();
			package.Mod = ModsUtil.GetMod(package);

			if (package.Assets.Length != 0 || package.Mod != null)
			{
				lock (packages)
				{
					packages.Add(package);
				}
			}
		}
	}

	internal static void ContentUpdated(string path, bool builtIn, bool workshop)
	{
		lock (_contentUpdateLock)
		{
			var existingPackage = CentralManager.Packages.FirstOrDefault(x => x.Folder.PathEquals(path));

			if (existingPackage != null)
			{
				RefreshPackage(existingPackage);
			}
			else
			{
				AddNewPackage(path, builtIn, workshop);
			}
		}
	}

	private static void AddNewPackage(string path, bool builtIn, bool workshop)
	{
		if (workshop && !ulong.TryParse(Path.GetFileName(path), out _))
		{ return; }

		var package = new Package(path, builtIn, workshop);

		package.Assets = AssetsUtil.GetAssets(package).ToArray();
		package.Mod = ModsUtil.GetMod(package);

		CentralManager.AddPackage(package);
	}

	internal static void RefreshPackage(Package package)
	{
		if (!Directory.Exists(package.Folder))
		{
			CentralManager.RemovePackage(package);
			return;
		}

		package.Assets = AssetsUtil.GetAssets(package).ToArray();
		package.Mod = ModsUtil.GetMod(package);

		CentralManager.RefreshSteamInfo(package);
	}

	internal static void StartListeners()
	{
		var addonsAssetsPath = new[]
		{
			LocationManager.AssetsPath,
			LocationManager.StylesPath,
			LocationManager.MapThemesPath
		};

		foreach (var folder in addonsAssetsPath)
		{
			PackageWatcher.Create(folder, false, false);
		}

		PackageWatcher.Create(LocationManager.ModsPath, false, false);

		PackageWatcher.Create(LocationManager.WorkshopContentPath, false, true);
	}

	internal static void CreateShortcut()
	{
		try
		{
			ExtensionClass.CreateShortcut(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "LOT 2.lnk"), System.Windows.Forms.Application.ExecutablePath);
		}
		catch (Exception ex)
		{
			Log.Exception(ex, "Failed to create shortcut");
		}
	}

	internal static void DeleteAll(IEnumerable<ulong> ids)
	{
		foreach (var id in ids)
		{
			DeleteAll(Path.Combine(LocationManager.WorkshopContentPath, id.ToString()));
		}
	}

	internal static void DeleteAll(string folder)
	{
		var package = CentralManager.Packages.FirstOrDefault(x => x.Folder.PathEquals(folder));

		if (package != null)
		{
			CentralManager.RemovePackage(package);
		}

		PackageWatcher.Pause();
		Directory.Delete(folder, true);
		PackageWatcher.Resume();
	}

	internal static void MoveToLocalFolder<T>(T item) where T : IPackage
	{
		if (item is Asset asset)
		{
			File.Copy(asset.FileName, Path.Combine(LocationManager.AssetsPath, Path.GetFileName(asset.FileName)), true);
			return;
		}

		if (item.Package.Assets?.Any() ?? false)
		{
			var target = new DirectoryInfo(Path.Combine(LocationManager.AssetsPath, Path.GetFileName(item.Folder)));

			new DirectoryInfo(item.Folder).CopyAll(target, x => Path.GetExtension(x).Equals(".crp", StringComparison.CurrentCultureIgnoreCase));

			target.RemoveEmptyFolders();
		}

		if (item.Package.Mod is not null)
		{
			var target = new DirectoryInfo(Path.Combine(LocationManager.ModsPath, Path.GetFileName(item.Folder)));

			new DirectoryInfo(item.Folder).CopyAll(target, x => !Path.GetExtension(x).Equals(".crp", StringComparison.CurrentCultureIgnoreCase));

			target.RemoveEmptyFolders();
		}
	}

	internal static GenericPackageState GetGenericPackageState(IGenericPackage item) => GetGenericPackageState(item, out _);

	internal static GenericPackageState GetGenericPackageState(IGenericPackage item, out Package? package)
	{
		if (item.SteamId == 0)
		{
			package = null;
			return GenericPackageState.Local;
		}

		package = CentralManager.Packages.FirstOrDefault(x => x.SteamId == item.SteamId);

		if (package == null)
		{
			return GenericPackageState.Unsubscribed;
		}

		if (!package.IsIncluded)
		{
			return GenericPackageState.Excluded;
		}

		if (package.Mod is null || package.Mod.IsEnabled)
		{
			return GenericPackageState.Enabled;
		}

		return GenericPackageState.Disabled;
	}
}
