﻿using Extensions;

using System;

namespace LoadOrderToolTwo.Utilities;
internal class Locale : LocaleHelper
{
	private static readonly Locale _instance = new();

	protected Locale() : base($"{nameof(LoadOrderToolTwo)}.Properties.Locale.csv") { }

	public static string CR_NoAvailableReport => _instance.GetText(nameof(CR_NoAvailableReport));
	public static string CR_IncompatibleWithGameVersion => _instance.GetText(nameof(CR_IncompatibleWithGameVersion));
	public static string CR_RequiresIncompatibleMod => _instance.GetText(nameof(CR_RequiresIncompatibleMod));
	public static string CR_BreaksGame => _instance.GetText(nameof(CR_BreaksGame));
	public static string CR_BrokenMod => _instance.GetText(nameof(CR_BrokenMod));
	public static string CR_MajorIssuesNoNote => _instance.GetText(nameof(CR_MajorIssuesNoNote));
	public static string CR_MajorIssuesWithNote => _instance.GetText(nameof(CR_MajorIssuesWithNote));
	public static string CR_MinorIssuesNoNote => _instance.GetText(nameof(CR_MinorIssuesNoNote));
	public static string CR_MinorIssuesWithNote => _instance.GetText(nameof(CR_MinorIssuesWithNote));
	public static string CR_UserReportsNoNote => _instance.GetText(nameof(CR_UserReportsNoNote));
	public static string CR_UserReportsWithNote => _instance.GetText(nameof(CR_UserReportsWithNote));
	public static string CR_NotEnoughInformationUpdated => _instance.GetText(nameof(CR_NotEnoughInformationUpdated));
	public static string CR_NotEnoughInformationOutdated => _instance.GetText(nameof(CR_NotEnoughInformationOutdated));
	public static string CR_Stable => _instance.GetText(nameof(CR_Stable));
	public static string CR_NotReviewedUpdated => _instance.GetText(nameof(CR_NotReviewedUpdated));
	public static string CR_NotReviewedOutdated => _instance.GetText(nameof(CR_NotReviewedOutdated));
	public static string CR_NotInCatalogMod => _instance.GetText(nameof(CR_NotInCatalogMod));
	public static string CR_NotInCatalog => _instance.GetText(nameof(CR_NotInCatalog));
	public static string CR_MissingDLC => _instance.GetText(nameof(CR_MissingDLC));
	public static string CR_UnneededDependency => _instance.GetText(nameof(CR_UnneededDependency));
	public static string CR_WorksWhenDisabled => _instance.GetText(nameof(CR_WorksWhenDisabled));
	public static string CR_SuccessorsAvailable => _instance.GetText(nameof(CR_SuccessorsAvailable));
	public static string CR_SuccessorsAvailableMultiple => _instance.GetText(nameof(CR_SuccessorsAvailableMultiple));
	public static string CR_AlternativesAvailable => _instance.GetText(nameof(CR_AlternativesAvailable));
	public static string CR_AlternativesAvailableMultiple => _instance.GetText(nameof(CR_AlternativesAvailableMultiple));
	public static string CR_RequiredModsMissing => _instance.GetText(nameof(CR_RequiredModsMissing));
	public static string CR_Obsolete => _instance.GetText(nameof(CR_Obsolete));
	public static string CR_RemovedFromWorkshop => _instance.GetText(nameof(CR_RemovedFromWorkshop));
	public static string CR_Deprecated => _instance.GetText(nameof(CR_Deprecated));
	public static string CR_Abandoned => _instance.GetText(nameof(CR_Abandoned));
	public static string CR_AbandonedRetired => _instance.GetText(nameof(CR_AbandonedRetired));
	public static string CR_Retired => _instance.GetText(nameof(CR_Retired));
	public static string CR_Note => _instance.GetText(nameof(CR_Note));
	public static string CR_Recommendations => _instance.GetText(nameof(CR_Recommendations));
	public static string CR_SavesCantLoadWithout => _instance.GetText(nameof(CR_SavesCantLoadWithout));
	public static string CR_SourceNotPublic => _instance.GetText(nameof(CR_SourceNotPublic));
	public static string CR_NoDescription => _instance.GetText(nameof(CR_NoDescription));
	public static string CR_NoCommentSection => _instance.GetText(nameof(CR_NoCommentSection));
	public static string CR_SourceBundled => _instance.GetText(nameof(CR_SourceBundled));
	public static string CR_SourceNotPublicAbandoned => _instance.GetText(nameof(CR_SourceNotPublicAbandoned));
	public static string CR_SourceObfuscated => _instance.GetText(nameof(CR_SourceObfuscated));
	public static string CR_Reupload => _instance.GetText(nameof(CR_Reupload));
	public static string CR_BreaksEditors => _instance.GetText(nameof(CR_BreaksEditors));
	public static string CR_ModForModders => _instance.GetText(nameof(CR_ModForModders));
	public static string CR_TestVersion => _instance.GetText(nameof(CR_TestVersion));
	public static string CR_TestVersionStable => _instance.GetText(nameof(CR_TestVersionStable));
	public static string CR_MusicCopyright => _instance.GetText(nameof(CR_MusicCopyright));
	public static string CR_SameModDifferentReleaseType => _instance.GetText(nameof(CR_SameModDifferentReleaseType));
	public static string CR_SameFunctionality => _instance.GetText(nameof(CR_SameFunctionality));
	public static string CR_IncompatibleAccordingToAuthor => _instance.GetText(nameof(CR_IncompatibleAccordingToAuthor));
	public static string CR_IncompatibleAccordingToUsers => _instance.GetText(nameof(CR_IncompatibleAccordingToUsers));
	public static string CR_MajorIssuesWith => _instance.GetText(nameof(CR_MajorIssuesWith));
	public static string CR_MinorIssuesWith => _instance.GetText(nameof(CR_MinorIssuesWith));
	public static string CR_RequiresSpecificSettings => _instance.GetText(nameof(CR_RequiresSpecificSettings));
	public static string CR_SameFunctionalityCompatible => _instance.GetText(nameof(CR_SameFunctionalityCompatible));
	public static string CR_CompatibleAccordingToAuthor => _instance.GetText(nameof(CR_CompatibleAccordingToAuthor));

	public static string Dashboard => _instance.GetText(nameof(Dashboard));
	public static string StartCities => _instance.GetText(nameof(StartCities));
	public static string StopCities => _instance.GetText(nameof(StopCities));
	public static string ProfileBubble => _instance.GetText(nameof(ProfileBubble));
	public static string AssetsBubble => _instance.GetText(nameof(AssetsBubble));
	public static string ModsBubble => _instance.GetText(nameof(ModsBubble));
	public static string ModOutOfDatePlural => _instance.GetText(nameof(ModOutOfDatePlural));
	public static string ModOutOfDate => _instance.GetText(nameof(ModOutOfDate));
	public static string ModIncompletePlural => _instance.GetText(nameof(ModIncompletePlural));
	public static string ModIncomplete => _instance.GetText(nameof(ModIncomplete));
	public static string MultipleModsIncluded => _instance.GetText(nameof(MultipleModsIncluded));
	public static string ModIncluded => _instance.GetText(nameof(ModIncluded));
	public static string ModIncludedPlural => _instance.GetText(nameof(ModIncludedPlural));
	public static string Mods => _instance.GetText(nameof(Mods));
	public static string Local => _instance.GetText(nameof(Local));
	public static string Workshop => _instance.GetText(nameof(Workshop));
	public static string Enabled => _instance.GetText(nameof(Enabled));
	public static string Disabled => _instance.GetText(nameof(Disabled));
	public static string Included => _instance.GetText(nameof(Included));
	public static string Excluded => _instance.GetText(nameof(Excluded));
	public static string Loading => _instance.GetText(nameof(Loading));
	public static string ModEnabled => _instance.GetText(nameof(ModEnabled));
	public static string ModIncludedAndEnabled => _instance.GetText(nameof(ModIncludedAndEnabled));
	public static string ModEnabledPlural => _instance.GetText(nameof(ModEnabledPlural));
	public static string ModIncludedAndEnabledPlural => _instance.GetText(nameof(ModIncludedAndEnabledPlural));
	public static string ModIsLocal => _instance.GetText(nameof(ModIsLocal));
	public static string ModIsRemoved => _instance.GetText(nameof(ModIsRemoved));
	public static string ModIsUnknown => _instance.GetText(nameof(ModIsUnknown));
	public static string ModIsNotDownloaded => _instance.GetText(nameof(ModIsNotDownloaded));
	public static string ModIsOutOfDate => _instance.GetText(nameof(ModIsOutOfDate));
	public static string ModIsMaybeOutOfDate => _instance.GetText(nameof(ModIsMaybeOutOfDate));
	public static string ModIsIncomplete => _instance.GetText(nameof(ModIsIncomplete));
	public static string ModIsUpToDate => _instance.GetText(nameof(ModIsUpToDate));
	public static string AssetIsLocal => _instance.GetText(nameof(AssetIsLocal));
	public static string AssetIsRemoved => _instance.GetText(nameof(AssetIsRemoved));
	public static string AssetIsUnknown => _instance.GetText(nameof(AssetIsUnknown));
	public static string AssetIsNotDownloaded => _instance.GetText(nameof(AssetIsNotDownloaded));
	public static string AssetIsOutOfDate => _instance.GetText(nameof(AssetIsOutOfDate));
	public static string AssetIsMaybeOutOfDate => _instance.GetText(nameof(AssetIsMaybeOutOfDate));
	public static string AssetIsIncomplete => _instance.GetText(nameof(AssetIsIncomplete));
	public static string AssetIsUpToDate => _instance.GetText(nameof(AssetIsUpToDate));
	public static string Server => _instance.GetText(nameof(Server));
	public static string Assets => _instance.GetText(nameof(Assets));
	public static string Vanilla => _instance.GetText(nameof(Vanilla));
	public static string UpToDate => _instance.GetText(nameof(UpToDate));
	public static string StatusUnknown => _instance.GetText(nameof(StatusUnknown));
	public static string OutOfDate => _instance.GetText(nameof(OutOfDate));
	public static string PartiallyDownloaded => _instance.GetText(nameof(PartiallyDownloaded));
	public static string CompatibilityReport => _instance.GetText(nameof(CompatibilityReport));
	public static string Back => _instance.GetText(nameof(Back));
	public static string Profiles => _instance.GetText(nameof(Profiles));
	public static string AutoProfileSaveOn => _instance.GetText(nameof(AutoProfileSaveOn));
	public static string AutoProfileSaveOff => _instance.GetText(nameof(AutoProfileSaveOff));
	public static string TemporaryProfileCanNotBeEdited => _instance.GetText(nameof(TemporaryProfileCanNotBeEdited));
	public static string LaunchSettings => _instance.GetText(nameof(LaunchSettings));
	public static string IncludesItemsYouDoNotHave => _instance.GetText(nameof(IncludesItemsYouDoNotHave));
	public static string ContentAndInfo => _instance.GetText(nameof(ContentAndInfo));
	public static string OtherProfiles => _instance.GetText(nameof(OtherProfiles));
	public static string Filters => _instance.GetText(nameof(Filters));
	public static string AssetIncluded => _instance.GetText(nameof(AssetIncluded));
	public static string AssetIncludedPlural => _instance.GetText(nameof(AssetIncludedPlural));
	public static string TotalSize => _instance.GetText(nameof(TotalSize));
	public static string AssetStatus => _instance.GetText(nameof(AssetStatus));
	public static string ModStatus => _instance.GetText(nameof(ModStatus));
	public static string ReportSeverity => _instance.GetText(nameof(ReportSeverity));
	public static string AnyStatus => _instance.GetText(nameof(AnyStatus));
	public static string AnyReportStatus => _instance.GetText(nameof(AnyReportStatus));
	public static string Subscribe => _instance.GetText(nameof(Subscribe));
	public static string Switch => _instance.GetText(nameof(Switch));
	public static string Enable => _instance.GetText(nameof(Enable));
	public static string ModOwned => _instance.GetText(nameof(ModOwned));
	public static string Settings => _instance.GetText(nameof(Settings));
	public static string NoLocalPackagesFound => _instance.GetText(nameof(NoLocalPackagesFound));
	public static string NoPackagesMatchFilters => _instance.GetText(nameof(NoPackagesMatchFilters));
	public static string Actions => _instance.GetText(nameof(Actions));
	public static string ModUtilities => _instance.GetText(nameof(ModUtilities));
	public static string CollectionTitle => _instance.GetText(nameof(CollectionTitle));
	public static string Packages => _instance.GetText(nameof(Packages));
	public static string Options => _instance.GetText(nameof(Options));
	public static string CrNotAvailable => _instance.GetText(nameof(CrNotAvailable));
	public static string ModsWithMinorIssues => _instance.GetText(nameof(ModsWithMinorIssues));
	public static string ModsWithMajorIssues => _instance.GetText(nameof(ModsWithMajorIssues));
	public static string ModsShouldUnsub => _instance.GetText(nameof(ModsShouldUnsub));
	public static string ModsNoIssues => _instance.GetText(nameof(ModsNoIssues));
	public static string Preferences => _instance.GetText(nameof(Preferences));
	public static string StartScratch => _instance.GetText(nameof(StartScratch));
	public static string ContinueFromCurrent => _instance.GetText(nameof(ContinueFromCurrent));
	public static string ProfileUsage => _instance.GetText(nameof(ProfileUsage));
	public static string CheckFolderInOptions => _instance.GetText(nameof(CheckFolderInOptions));
	public static string SomePackagesWillBeDisabled => _instance.GetText(nameof(SomePackagesWillBeDisabled));
	public static string AffectedPackagesAre => _instance.GetText(nameof(AffectedPackagesAre));
	public static string ConfirmDeleteProfile => _instance.GetText(nameof(ConfirmDeleteProfile));
	public static string ProfileReplace => _instance.GetText(nameof(ProfileReplace));
	public static string ProfileExclude => _instance.GetText(nameof(ProfileExclude));
	public static string ProfileMerge => _instance.GetText(nameof(ProfileMerge));
	public static string ProfileDelete => _instance.GetText(nameof(ProfileDelete));
	public static string ShouldNotBeSubscribed => _instance.GetText(nameof(ShouldNotBeSubscribed));
	public static string MissingPackages => _instance.GetText(nameof(MissingPackages));
	public static string LoadingScreenMod => _instance.GetText(nameof(LoadingScreenMod));
	public static string ExcludeInclude => _instance.GetText(nameof(ExcludeInclude));
	public static string EnableDisable => _instance.GetText(nameof(EnableDisable));
	public static string OpenPackagePage => _instance.GetText(nameof(OpenPackagePage));
	public static string OpenLocalFolder => _instance.GetText(nameof(OpenLocalFolder));
	public static string ViewOnSteam => _instance.GetText(nameof(ViewOnSteam));
	public static string ReDownloadPackage => _instance.GetText(nameof(ReDownloadPackage));
	public static string CopySteamId => _instance.GetText(nameof(CopySteamId));
	public static string OpenAuthorPage => _instance.GetText(nameof(OpenAuthorPage));
	public static string Total => _instance.GetText(nameof(Total));
	public static string Sorting => _instance.GetText(nameof(Sorting));
	public static string FolderSettings => _instance.GetText(nameof(FolderSettings));
	public static string ChangingFoldersRequiresRestart => _instance.GetText(nameof(ChangingFoldersRequiresRestart));
	public static string CreateProfileHere => _instance.GetText(nameof(CreateProfileHere));
	public static string TemporaryProfile => _instance.GetText(nameof(TemporaryProfile));
	public static string CouldNotCreateProfile => _instance.GetText(nameof(CouldNotCreateProfile));
	public static string ProfileNameChangedIllegalChars => _instance.GetText(nameof(ProfileNameChangedIllegalChars));
	public static string ProfileSaveInfo => _instance.GetText(nameof(ProfileSaveInfo));
	public static string From => _instance.GetText(nameof(From));
	public static string To => _instance.GetText(nameof(To));
	public static string DateSubscribed => _instance.GetText(nameof(DateSubscribed));
	public static string DateUpdated => _instance.GetText(nameof(DateUpdated));
	public static object PackageIncluded => _instance.GetText(nameof(PackageIncluded));
	public static object PackageIncludedPlural => _instance.GetText(nameof(PackageIncludedPlural));
	public static string PackageStatus => _instance.GetText(nameof(PackageStatus));
	public static string MultiplePackagesIncluded => _instance.GetText(nameof(MultiplePackagesIncluded));
	public static string CopyWorkshopLink => _instance.GetText(nameof(CopyWorkshopLink));
	public static string DeletePackage => _instance.GetText(nameof(DeletePackage));
	public static string UnsubscribePackage => _instance.GetText(nameof(UnsubscribePackage));
	public static string CopyWorkshopId => _instance.GetText(nameof(CopyWorkshopId));
	public static string CopyAuthorLink => _instance.GetText(nameof(CopyAuthorLink));
	public static string CopyAuthorId => _instance.GetText(nameof(CopyAuthorId));
	public static string Copy => _instance.GetText(nameof(Copy));
	public static string Showing => _instance.GetText(nameof(Showing));
	public static string YourProfiles => _instance.GetText(nameof(YourProfiles));
	public static string Profile => _instance.GetText(nameof(Profile));
	public static string Favorite => _instance.GetText(nameof(Favorite));
	public static string UnFavoriteThisProfile => _instance.GetText(nameof(UnFavoriteThisProfile));
	public static string FavoriteThisProfile => _instance.GetText(nameof(FavoriteThisProfile));
	public static string ProfileCreationFailed => _instance.GetText(nameof(ProfileCreationFailed));
	public static string Tags => _instance.GetText(nameof(Tags));
	public static string DLCs => _instance.GetText(nameof(DLCs));
	public static string NoDlcsNoInternet => _instance.GetText(nameof(NoDlcsNoInternet));
	public static string NoDlcsOpenGame => _instance.GetText(nameof(NoDlcsOpenGame));
	public static string DlcUpdateNotice => _instance.GetText(nameof(DlcUpdateNotice));
	public static string DlcCount => _instance.GetText(nameof(DlcCount));
	public static string IncludeAllItemsInThisPackage => _instance.GetText(nameof(IncludeAllItemsInThisPackage));
	public static string ExcludeAllItemsInThisPackage => _instance.GetText(nameof(ExcludeAllItemsInThisPackage));
	public static string Unfiltered => _instance.GetText(nameof(Unfiltered));
	public static string AnyTags => _instance.GetText(nameof(AnyTags));
	public static string MovePackageToLocalFolder => _instance.GetText(nameof(MovePackageToLocalFolder));
	public static string TotalItems => _instance.GetText(nameof(TotalItems));
	public static string OutOf => _instance.GetText(nameof(OutOf));
	public static string MissingItemsRemain => _instance.GetText(nameof(MissingItemsRemain));
}