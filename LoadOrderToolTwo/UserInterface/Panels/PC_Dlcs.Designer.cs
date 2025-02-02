﻿using LoadOrderToolTwo.UserInterface.Generic;
using LoadOrderToolTwo.UserInterface.Lists;
using LoadOrderToolTwo.Utilities;

namespace LoadOrderToolTwo.UserInterface.Panels;

partial class PC_DLCs
{
	/// <summary> 
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			SteamUtil.DLCsLoaded -= SteamUtil_DLCsLoaded;
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Component Designer generated code

	/// <summary> 
	/// Required method for Designer support - do not modify 
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
			this.TLP_Main = new System.Windows.Forms.TableLayoutPanel();
			this.B_ExInclude = new LoadOrderToolTwo.UserInterface.Generic.DoubleButton();
			this.slickSpacer2 = new SlickControls.SlickSpacer();
			this.slickSpacer1 = new SlickControls.SlickSpacer();
			this.TB_Search = new SlickControls.SlickTextBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.L_Duplicates = new System.Windows.Forms.Label();
			this.L_Counts = new System.Windows.Forms.Label();
			this.LC_DLCs = new LoadOrderToolTwo.UserInterface.Lists.DlcListControl();
			this.TLP_Main.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// base_Text
			// 
			this.base_Text.Location = new System.Drawing.Point(-2, 3);
			// 
			// TLP_Main
			// 
			this.TLP_Main.ColumnCount = 2;
			this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TLP_Main.Controls.Add(this.B_ExInclude, 1, 0);
			this.TLP_Main.Controls.Add(this.slickSpacer2, 0, 1);
			this.TLP_Main.Controls.Add(this.slickSpacer1, 0, 3);
			this.TLP_Main.Controls.Add(this.TB_Search, 0, 0);
			this.TLP_Main.Controls.Add(this.tableLayoutPanel3, 0, 2);
			this.TLP_Main.Controls.Add(this.LC_DLCs, 0, 4);
			this.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TLP_Main.Location = new System.Drawing.Point(0, 30);
			this.TLP_Main.Name = "TLP_Main";
			this.TLP_Main.RowCount = 5;
			this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TLP_Main.Size = new System.Drawing.Size(932, 683);
			this.TLP_Main.TabIndex = 0;
			// 
			// B_ExInclude
			// 
			this.B_ExInclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.B_ExInclude.Cursor = System.Windows.Forms.Cursors.Hand;
			this.B_ExInclude.Image1 = "I_X";
			this.B_ExInclude.Image2 = "I_Check";
			this.B_ExInclude.Location = new System.Drawing.Point(556, 3);
			this.B_ExInclude.Name = "B_ExInclude";
			this.B_ExInclude.Option1 = "ExcludeAll";
			this.B_ExInclude.Option2 = "IncludeAll";
			this.B_ExInclude.Size = new System.Drawing.Size(373, 40);
			this.B_ExInclude.TabIndex = 1;
			this.B_ExInclude.TabStop = false;
			this.B_ExInclude.LeftClicked += new System.EventHandler(this.B_ExInclude_LeftClicked);
			this.B_ExInclude.RightClicked += new System.EventHandler(this.B_ExInclude_RightClicked);
			// 
			// slickSpacer2
			// 
			this.TLP_Main.SetColumnSpan(this.slickSpacer2, 2);
			this.slickSpacer2.Dock = System.Windows.Forms.DockStyle.Top;
			this.slickSpacer2.Location = new System.Drawing.Point(0, 53);
			this.slickSpacer2.Margin = new System.Windows.Forms.Padding(0);
			this.slickSpacer2.Name = "slickSpacer2";
			this.slickSpacer2.Size = new System.Drawing.Size(932, 2);
			this.slickSpacer2.TabIndex = 8;
			this.slickSpacer2.TabStop = false;
			this.slickSpacer2.Text = "slickSpacer2";
			// 
			// slickSpacer1
			// 
			this.TLP_Main.SetColumnSpan(this.slickSpacer1, 2);
			this.slickSpacer1.Dock = System.Windows.Forms.DockStyle.Top;
			this.slickSpacer1.Location = new System.Drawing.Point(0, 78);
			this.slickSpacer1.Margin = new System.Windows.Forms.Padding(0);
			this.slickSpacer1.Name = "slickSpacer1";
			this.slickSpacer1.Size = new System.Drawing.Size(932, 2);
			this.slickSpacer1.TabIndex = 7;
			this.slickSpacer1.TabStop = false;
			this.slickSpacer1.Text = "slickSpacer1";
			// 
			// TB_Search
			// 
			this.TB_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.TB_Search.Image = global::LoadOrderToolTwo.Properties.Resources.I_Search;
			this.TB_Search.LabelText = "Search";
			this.TB_Search.Location = new System.Drawing.Point(3, 3);
			this.TB_Search.Name = "TB_Search";
			this.TB_Search.Placeholder = "SearchDlcs";
			this.TB_Search.SelectedText = "";
			this.TB_Search.SelectionLength = 0;
			this.TB_Search.SelectionStart = 0;
			this.TB_Search.Size = new System.Drawing.Size(149, 47);
			this.TB_Search.TabIndex = 0;
			this.TB_Search.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
			this.TB_Search.IconClicked += new System.EventHandler(this.TB_Search_IconClicked);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel3.ColumnCount = 2;
			this.TLP_Main.SetColumnSpan(this.tableLayoutPanel3, 2);
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.L_Duplicates, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.L_Counts, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 55);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(932, 23);
			this.tableLayoutPanel3.TabIndex = 6;
			// 
			// L_Duplicates
			// 
			this.L_Duplicates.AutoSize = true;
			this.L_Duplicates.Location = new System.Drawing.Point(3, 0);
			this.L_Duplicates.Name = "L_Duplicates";
			this.L_Duplicates.Size = new System.Drawing.Size(55, 23);
			this.L_Duplicates.TabIndex = 2;
			this.L_Duplicates.Text = "label1";
			// 
			// L_Counts
			// 
			this.L_Counts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.L_Counts.AutoSize = true;
			this.L_Counts.Location = new System.Drawing.Point(874, 0);
			this.L_Counts.Name = "L_Counts";
			this.tableLayoutPanel3.SetRowSpan(this.L_Counts, 2);
			this.L_Counts.Size = new System.Drawing.Size(55, 23);
			this.L_Counts.TabIndex = 1;
			this.L_Counts.Text = "label1";
			// 
			// LC_DLCs
			// 
			this.LC_DLCs.AutoInvalidate = false;
			this.LC_DLCs.AutoScroll = true;
			this.TLP_Main.SetColumnSpan(this.LC_DLCs, 2);
			this.LC_DLCs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LC_DLCs.HighlightOnHover = true;
			this.LC_DLCs.Loading = true;
			this.LC_DLCs.Location = new System.Drawing.Point(0, 80);
			this.LC_DLCs.Margin = new System.Windows.Forms.Padding(0);
			this.LC_DLCs.Name = "LC_DLCs";
			this.LC_DLCs.SeparateWithLines = true;
			this.LC_DLCs.Size = new System.Drawing.Size(932, 603);
			this.LC_DLCs.TabIndex = 15;
			// 
			// PC_DLCs
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.TLP_Main);
			this.LabelBounds = new System.Drawing.Point(-2, 3);
			this.Name = "PC_DLCs";
			this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
			this.Size = new System.Drawing.Size(932, 713);
			this.Controls.SetChildIndex(this.base_Text, 0);
			this.Controls.SetChildIndex(this.TLP_Main, 0);
			this.TLP_Main.ResumeLayout(false);
			this.TLP_Main.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.TableLayoutPanel TLP_Main;
	private DoubleButton B_ExInclude;
	private SlickControls.SlickSpacer slickSpacer2;
	private SlickControls.SlickSpacer slickSpacer1;
	private SlickControls.SlickTextBox TB_Search;
	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
	private System.Windows.Forms.Label L_Duplicates;
	private System.Windows.Forms.Label L_Counts;
	private DlcListControl LC_DLCs;
}
