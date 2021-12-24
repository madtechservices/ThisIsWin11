﻿
namespace ThisIsWin11
{
    partial class AppsWindow
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
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem menuAppsExport;
            this.checkAppsSystem = new System.Windows.Forms.CheckBox();
            this.btnRemoveApps = new System.Windows.Forms.Button();
            this.btnAppsMenu = new System.Windows.Forms.Button();
            this.menuApps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAppsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsPopOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAppsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblAppsBinOptions = new System.Windows.Forms.LinkLabel();
            this.lblAppsBinCount = new System.Windows.Forms.Label();
            this.rtbPS = new System.Windows.Forms.RichTextBox();
            this.lstAppsRemove = new System.Windows.Forms.ListBox();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnAppsRefresh = new System.Windows.Forms.Button();
            this.lstApps = new System.Windows.Forms.ListBox();
            this.lblAppsInstalledCount = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            menuAppsExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApps.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAppsExport
            // 
            menuAppsExport.Name = "menuAppsExport";
            menuAppsExport.Size = new System.Drawing.Size(347, 30);
            menuAppsExport.Text = "Export bloatware in Recycle bin";
            menuAppsExport.Click += new System.EventHandler(this.menuAppsExport_Click);
            // 
            // checkAppsSystem
            // 
            this.checkAppsSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAppsSystem.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkAppsSystem.BackColor = System.Drawing.Color.Black;
            this.checkAppsSystem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkAppsSystem.FlatAppearance.BorderSize = 2;
            this.checkAppsSystem.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumVioletRed;
            this.checkAppsSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAppsSystem.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAppsSystem.ForeColor = System.Drawing.Color.White;
            this.checkAppsSystem.Location = new System.Drawing.Point(68, 788);
            this.checkAppsSystem.Margin = new System.Windows.Forms.Padding(2);
            this.checkAppsSystem.Name = "checkAppsSystem";
            this.checkAppsSystem.Size = new System.Drawing.Size(184, 32);
            this.checkAppsSystem.TabIndex = 103;
            this.checkAppsSystem.Text = "Show system apps";
            this.checkAppsSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkAppsSystem.UseVisualStyleBackColor = false;
            this.checkAppsSystem.CheckedChanged += new System.EventHandler(this.checkAppsSystem_CheckedChanged);
            // 
            // btnRemoveApps
            // 
            this.btnRemoveApps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveApps.AutoEllipsis = true;
            this.btnRemoveApps.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRemoveApps.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveApps.FlatAppearance.BorderSize = 2;
            this.btnRemoveApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveApps.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveApps.ForeColor = System.Drawing.Color.White;
            this.btnRemoveApps.Location = new System.Drawing.Point(19, 388);
            this.btnRemoveApps.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveApps.Name = "btnRemoveApps";
            this.btnRemoveApps.Size = new System.Drawing.Size(262, 32);
            this.btnRemoveApps.TabIndex = 104;
            this.btnRemoveApps.Text = "Empty bin";
            this.btnRemoveApps.UseVisualStyleBackColor = false;
            this.btnRemoveApps.Click += new System.EventHandler(this.btnRemoveApps_Click);
            // 
            // btnAppsMenu
            // 
            this.btnAppsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppsMenu.BackColor = System.Drawing.Color.White;
            this.btnAppsMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAppsMenu.FlatAppearance.BorderSize = 0;
            this.btnAppsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAppsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppsMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppsMenu.Location = new System.Drawing.Point(252, 0);
            this.btnAppsMenu.Name = "btnAppsMenu";
            this.btnAppsMenu.Size = new System.Drawing.Size(48, 51);
            this.btnAppsMenu.TabIndex = 156;
            this.btnAppsMenu.UseVisualStyleBackColor = false;
            this.btnAppsMenu.Click += new System.EventHandler(this.btnAppsMenu_Click);
            // 
            // menuApps
            // 
            this.menuApps.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuApps.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuApps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAppsImport,
            menuAppsExport,
            this.menuAppsRemoveAll,
            this.menuAppsPopOut,
            this.toolStripSeparator1,
            this.menuAppsInfo});
            this.menuApps.Name = "menuMain";
            this.menuApps.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuApps.Size = new System.Drawing.Size(348, 160);
            this.menuApps.Text = "Info";
            // 
            // menuAppsImport
            // 
            this.menuAppsImport.Name = "menuAppsImport";
            this.menuAppsImport.Size = new System.Drawing.Size(347, 30);
            this.menuAppsImport.Text = "Import bloatware list";
            this.menuAppsImport.Click += new System.EventHandler(this.menuAppsImport_Click);
            // 
            // menuAppsRemoveAll
            // 
            this.menuAppsRemoveAll.Name = "menuAppsRemoveAll";
            this.menuAppsRemoveAll.Size = new System.Drawing.Size(347, 30);
            this.menuAppsRemoveAll.Text = "Uninstall all apps";
            this.menuAppsRemoveAll.Click += new System.EventHandler(this.menuAppsRemoveAll_Click);
            // 
            // menuAppsPopOut
            // 
            this.menuAppsPopOut.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAppsPopOut.Name = "menuAppsPopOut";
            this.menuAppsPopOut.Size = new System.Drawing.Size(347, 30);
            this.menuAppsPopOut.Text = "Pop-out-App";
            this.menuAppsPopOut.Click += new System.EventHandler(this.menuAppsPopOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(344, 6);
            // 
            // menuAppsInfo
            // 
            this.menuAppsInfo.Name = "menuAppsInfo";
            this.menuAppsInfo.Size = new System.Drawing.Size(347, 30);
            this.menuAppsInfo.Text = "Info";
            this.menuAppsInfo.Click += new System.EventHandler(this.menuAppsInfo_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.lblAppsBinOptions);
            this.pnlRight.Controls.Add(this.lblAppsBinCount);
            this.pnlRight.Controls.Add(this.rtbPS);
            this.pnlRight.Controls.Add(this.lstAppsRemove);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Font = new System.Drawing.Font("Segoe UI Variable Small Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRight.Location = new System.Drawing.Point(781, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(429, 862);
            this.pnlRight.TabIndex = 157;
            // 
            // lblAppsBinOptions
            // 
            this.lblAppsBinOptions.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppsBinOptions.AutoEllipsis = true;
            this.lblAppsBinOptions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblAppsBinOptions.LinkColor = System.Drawing.Color.Black;
            this.lblAppsBinOptions.Location = new System.Drawing.Point(23, 128);
            this.lblAppsBinOptions.Name = "lblAppsBinOptions";
            this.lblAppsBinOptions.Size = new System.Drawing.Size(336, 46);
            this.lblAppsBinOptions.TabIndex = 158;
            this.lblAppsBinOptions.TabStop = true;
            this.lblAppsBinOptions.Text = "Move the apps you want to uninstall here \r\nor import via file...";
            this.lblAppsBinOptions.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppsBinOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAppsBinOptions_LinkClicked);
            // 
            // lblAppsBinCount
            // 
            this.lblAppsBinCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppsBinCount.AutoEllipsis = true;
            this.lblAppsBinCount.BackColor = System.Drawing.Color.White;
            this.lblAppsBinCount.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppsBinCount.ForeColor = System.Drawing.Color.Black;
            this.lblAppsBinCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAppsBinCount.Location = new System.Drawing.Point(21, 50);
            this.lblAppsBinCount.Name = "lblAppsBinCount";
            this.lblAppsBinCount.Size = new System.Drawing.Size(308, 32);
            this.lblAppsBinCount.TabIndex = 135;
            this.lblAppsBinCount.Text = "Recycle bin";
            // 
            // rtbPS
            // 
            this.rtbPS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPS.BackColor = System.Drawing.Color.White;
            this.rtbPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPS.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbPS.HideSelection = false;
            this.rtbPS.Location = new System.Drawing.Point(27, 175);
            this.rtbPS.Name = "rtbPS";
            this.rtbPS.ReadOnly = true;
            this.rtbPS.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbPS.Size = new System.Drawing.Size(399, 673);
            this.rtbPS.TabIndex = 138;
            this.rtbPS.Text = "";
            this.rtbPS.Visible = false;
            this.rtbPS.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbPS_LinkClicked);
            // 
            // lstAppsRemove
            // 
            this.lstAppsRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAppsRemove.BackColor = System.Drawing.Color.White;
            this.lstAppsRemove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstAppsRemove.Font = new System.Drawing.Font("Segoe UI Variable Small Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAppsRemove.FormattingEnabled = true;
            this.lstAppsRemove.ItemHeight = 22;
            this.lstAppsRemove.Location = new System.Drawing.Point(27, 175);
            this.lstAppsRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstAppsRemove.Name = "lstAppsRemove";
            this.lstAppsRemove.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAppsRemove.Size = new System.Drawing.Size(399, 660);
            this.lstAppsRemove.Sorted = true;
            this.lstAppsRemove.TabIndex = 136;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMiddle.BackColor = System.Drawing.Color.White;
            this.pnlMiddle.Controls.Add(this.lblSubHeader);
            this.pnlMiddle.Controls.Add(this.btnRemoveApps);
            this.pnlMiddle.Controls.Add(this.btnAppsMenu);
            this.pnlMiddle.Controls.Add(this.btnAddAll);
            this.pnlMiddle.Controls.Add(this.btnAdd);
            this.pnlMiddle.Controls.Add(this.btnRemove);
            this.pnlMiddle.Controls.Add(this.btnRemoveAll);
            this.pnlMiddle.Location = new System.Drawing.Point(472, 3);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(303, 856);
            this.pnlMiddle.TabIndex = 158;
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubHeader.AutoEllipsis = true;
            this.lblSubHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.ForeColor = System.Drawing.Color.Black;
            this.lblSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSubHeader.Location = new System.Drawing.Point(13, 54);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(249, 32);
            this.lblSubHeader.TabIndex = 158;
            this.lblSubHeader.Text = "Apps && features";
            // 
            // btnAddAll
            // 
            this.btnAddAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAll.AutoEllipsis = true;
            this.btnAddAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAddAll.FlatAppearance.BorderSize = 0;
            this.btnAddAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAll.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddAll.Location = new System.Drawing.Point(19, 194);
            this.btnAddAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(262, 32);
            this.btnAddAll.TabIndex = 21;
            this.btnAddAll.Text = "Move all >>";
            this.btnAddAll.UseVisualStyleBackColor = false;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoEllipsis = true;
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(19, 234);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(262, 32);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Move selected >";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.AutoEllipsis = true;
            this.btnRemove.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemove.Location = new System.Drawing.Point(19, 332);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(262, 32);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "< Restore selected";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAll.AutoEllipsis = true;
            this.btnRemoveAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveAll.FlatAppearance.BorderSize = 0;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemoveAll.Location = new System.Drawing.Point(19, 292);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(262, 32);
            this.btnRemoveAll.TabIndex = 22;
            this.btnRemoveAll.Text = "<< Restore all";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.btnAppsRefresh);
            this.pnlLeft.Controls.Add(this.lstApps);
            this.pnlLeft.Controls.Add(this.lblAppsInstalledCount);
            this.pnlLeft.Controls.Add(this.checkAppsSystem);
            this.pnlLeft.Controls.Add(this.lblHeader);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(470, 862);
            this.pnlLeft.TabIndex = 159;
            // 
            // btnAppsRefresh
            // 
            this.btnAppsRefresh.BackColor = System.Drawing.Color.White;
            this.btnAppsRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAppsRefresh.FlatAppearance.BorderSize = 0;
            this.btnAppsRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAppsRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppsRefresh.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppsRefresh.Location = new System.Drawing.Point(481, 3);
            this.btnAppsRefresh.Name = "btnAppsRefresh";
            this.btnAppsRefresh.Size = new System.Drawing.Size(48, 51);
            this.btnAppsRefresh.TabIndex = 163;
            this.btnAppsRefresh.UseVisualStyleBackColor = false;
            this.btnAppsRefresh.Click += new System.EventHandler(this.btnAppsRefresh_Click);
            // 
            // lstApps
            // 
            this.lstApps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstApps.BackColor = System.Drawing.Color.White;
            this.lstApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstApps.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstApps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstApps.FormattingEnabled = true;
            this.lstApps.ItemHeight = 22;
            this.lstApps.Location = new System.Drawing.Point(68, 175);
            this.lstApps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstApps.Name = "lstApps";
            this.lstApps.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstApps.Size = new System.Drawing.Size(398, 594);
            this.lstApps.Sorted = true;
            this.lstApps.TabIndex = 138;
            // 
            // lblAppsInstalledCount
            // 
            this.lblAppsInstalledCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppsInstalledCount.AutoEllipsis = true;
            this.lblAppsInstalledCount.AutoSize = true;
            this.lblAppsInstalledCount.BackColor = System.Drawing.Color.DeepPink;
            this.lblAppsInstalledCount.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppsInstalledCount.ForeColor = System.Drawing.Color.White;
            this.lblAppsInstalledCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAppsInstalledCount.Location = new System.Drawing.Point(211, 58);
            this.lblAppsInstalledCount.Name = "lblAppsInstalledCount";
            this.lblAppsInstalledCount.Size = new System.Drawing.Size(79, 38);
            this.lblAppsInstalledCount.TabIndex = 26;
            this.lblAppsInstalledCount.Text = "apps";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(60, 50);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(396, 94);
            this.lblHeader.TabIndex = 162;
            this.lblHeader.Text = "Remove\r\nwith PumpedApp";
            // 
            // AppsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 862);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlMiddle);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AppsWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PumpedApp";
            this.Shown += new System.EventHandler(this.AppsWindow_Shown);
            this.menuApps.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlMiddle.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkAppsSystem;
        private System.Windows.Forms.Button btnRemoveApps;
        private System.Windows.Forms.Button btnAppsMenu;
        private System.Windows.Forms.ContextMenuStrip menuApps;
        private System.Windows.Forms.ToolStripMenuItem menuAppsPopOut;
        private System.Windows.Forms.ToolStripMenuItem menuAppsRemoveAll;
        private System.Windows.Forms.ToolStripMenuItem menuAppsImport;
        private System.Windows.Forms.ToolStripMenuItem menuAppsInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblAppsBinCount;
        public System.Windows.Forms.RichTextBox rtbPS;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblAppsInstalledCount;
        private System.Windows.Forms.ListBox lstAppsRemove;
        private System.Windows.Forms.ListBox lstApps;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Button btnAppsRefresh;
        private System.Windows.Forms.LinkLabel lblAppsBinOptions;
    }
}