using System;
using System.Windows.Forms;

namespace UI
{
    partial class processMonitorUIMain
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
            this.processGrid = new System.Windows.Forms.DataGridView();
            this.ProcessSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartupParameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.TimeSampleLabel = new System.Windows.Forms.Label();
            this.outputPathLabel = new System.Windows.Forms.Label();
            this.fileFormatLabel = new System.Windows.Forms.Label();
            this.SamplingRate = new System.Windows.Forms.NumericUpDown();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.fileFormatBox = new System.Windows.Forms.ComboBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.selectedProcessGrid = new System.Windows.Forms.DataGridView();
            this.SelectedCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SelectedProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedProcessStartupParameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedProcessLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.systemProcessesLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorProcessBar = new System.Windows.Forms.ProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.processGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplingRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedProcessGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // processGrid
            // 
            this.processGrid.AllowUserToAddRows = false;
            this.processGrid.AllowUserToDeleteRows = false;
            this.processGrid.AllowUserToOrderColumns = true;
            this.processGrid.AllowUserToResizeRows = false;
            this.processGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.processGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessSelected,
            this.ProcessID,
            this.ProcessName,
            this.StartupParameters});
            this.processGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processGrid.Location = new System.Drawing.Point(0, 0);
            this.processGrid.Margin = new System.Windows.Forms.Padding(4);
            this.processGrid.Name = "processGrid";
            this.processGrid.Size = new System.Drawing.Size(513, 388);
            this.processGrid.TabIndex = 0;
            this.processGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProcessGrid_CellContentClick);
            this.processGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProcessGrid_CellContentClick);
            // 
            // ProcessSelected
            // 
            this.ProcessSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProcessSelected.FillWeight = 5F;
            this.ProcessSelected.Frozen = true;
            this.ProcessSelected.HeaderText = "";
            this.ProcessSelected.MinimumWidth = 20;
            this.ProcessSelected.Name = "ProcessSelected";
            this.ProcessSelected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProcessSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProcessSelected.Width = 23;
            // 
            // ProcessID
            // 
            this.ProcessID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProcessID.FillWeight = 20F;
            this.ProcessID.HeaderText = "Process ID";
            this.ProcessID.MinimumWidth = 82;
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.ReadOnly = true;
            this.ProcessID.Width = 97;
            // 
            // ProcessName
            // 
            this.ProcessName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProcessName.FillWeight = 120F;
            this.ProcessName.HeaderText = "Process Name";
            this.ProcessName.MinimumWidth = 99;
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            this.ProcessName.Width = 118;
            // 
            // StartupParameters
            // 
            this.StartupParameters.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StartupParameters.FillWeight = 120F;
            this.StartupParameters.HeaderText = "Startup Parameters";
            this.StartupParameters.MinimumWidth = 332;
            this.StartupParameters.Name = "StartupParameters";
            this.StartupParameters.ReadOnly = true;
            this.StartupParameters.Width = 332;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(392, 101);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(144, 22);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.Location = new System.Drawing.Point(929, 33);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(100, 28);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // TimeSampleLabel
            // 
            this.TimeSampleLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TimeSampleLabel.AutoSize = true;
            this.TimeSampleLabel.Location = new System.Drawing.Point(92, 554);
            this.TimeSampleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeSampleLabel.Name = "TimeSampleLabel";
            this.TimeSampleLabel.Size = new System.Drawing.Size(108, 17);
            this.TimeSampleLabel.TabIndex = 6;
            this.TimeSampleLabel.Text = "Sampling Rate :";
            // 
            // outputPathLabel
            // 
            this.outputPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.outputPathLabel.AutoSize = true;
            this.outputPathLabel.Location = new System.Drawing.Point(108, 586);
            this.outputPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputPathLabel.Name = "outputPathLabel";
            this.outputPathLabel.Size = new System.Drawing.Size(92, 17);
            this.outputPathLabel.TabIndex = 7;
            this.outputPathLabel.Text = "Output Path :";
            // 
            // fileFormatLabel
            // 
            this.fileFormatLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fileFormatLabel.AutoSize = true;
            this.fileFormatLabel.Location = new System.Drawing.Point(116, 615);
            this.fileFormatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileFormatLabel.Name = "fileFormatLabel";
            this.fileFormatLabel.Size = new System.Drawing.Size(86, 17);
            this.fileFormatLabel.TabIndex = 8;
            this.fileFormatLabel.Text = "File Format :";
            // 
            // SamplingRate
            // 
            this.SamplingRate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SamplingRate.Location = new System.Drawing.Point(223, 548);
            this.SamplingRate.Margin = new System.Windows.Forms.Padding(4);
            this.SamplingRate.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.SamplingRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SamplingRate.Name = "SamplingRate";
            this.SamplingRate.Size = new System.Drawing.Size(140, 22);
            this.SamplingRate.TabIndex = 9;
            this.SamplingRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.outputFileTextBox.Location = new System.Drawing.Point(223, 580);
            this.outputFileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(572, 22);
            this.outputFileTextBox.TabIndex = 10;
            this.outputFileTextBox.Text = "C:\\Users\\Administrator\\Documents\\ProcessMonitoringSystem\\MonitorData\\";
            // 
            // browseBtn
            // 
            this.browseBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.browseBtn.Location = new System.Drawing.Point(804, 576);
            this.browseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(100, 31);
            this.browseBtn.TabIndex = 11;
            this.browseBtn.Text = "Browse..";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // fileFormatBox
            // 
            this.fileFormatBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fileFormatBox.FormattingEnabled = true;
            this.fileFormatBox.Location = new System.Drawing.Point(223, 612);
            this.fileFormatBox.Margin = new System.Windows.Forms.Padding(4);
            this.fileFormatBox.Name = "fileFormatBox";
            this.fileFormatBox.Size = new System.Drawing.Size(139, 24);
            this.fileFormatBox.TabIndex = 12;
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startBtn.Location = new System.Drawing.Point(16, 645);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(104, 31);
            this.startBtn.TabIndex = 13;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBtn.Location = new System.Drawing.Point(925, 645);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(104, 31);
            this.stopBtn.TabIndex = 14;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // selectedProcessGrid
            // 
            this.selectedProcessGrid.AllowUserToAddRows = false;
            this.selectedProcessGrid.AllowUserToDeleteRows = false;
            this.selectedProcessGrid.AllowUserToOrderColumns = true;
            this.selectedProcessGrid.AllowUserToResizeRows = false;
            this.selectedProcessGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectedProcessGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedProcessGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectedCheckBox,
            this.SelectedProcessID,
            this.SelectedProcessName,
            this.SelectedProcessStartupParameters});
            this.selectedProcessGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedProcessGrid.Location = new System.Drawing.Point(0, 0);
            this.selectedProcessGrid.Margin = new System.Windows.Forms.Padding(4);
            this.selectedProcessGrid.Name = "selectedProcessGrid";
            this.selectedProcessGrid.Size = new System.Drawing.Size(517, 388);
            this.selectedProcessGrid.TabIndex = 0;
            this.selectedProcessGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectedProcessGrid_CellContentClick);
            this.selectedProcessGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectedProcessGrid_CellContentClick);
            // 
            // SelectedCheckBox
            // 
            this.SelectedCheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SelectedCheckBox.FillWeight = 20F;
            this.SelectedCheckBox.Frozen = true;
            this.SelectedCheckBox.HeaderText = "";
            this.SelectedCheckBox.MinimumWidth = 20;
            this.SelectedCheckBox.Name = "SelectedCheckBox";
            this.SelectedCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SelectedCheckBox.Width = 20;
            // 
            // SelectedProcessID
            // 
            this.SelectedProcessID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SelectedProcessID.FillWeight = 119.797F;
            this.SelectedProcessID.HeaderText = "Process ID";
            this.SelectedProcessID.MinimumWidth = 82;
            this.SelectedProcessID.Name = "SelectedProcessID";
            this.SelectedProcessID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedProcessID.Width = 97;
            // 
            // SelectedProcessName
            // 
            this.SelectedProcessName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SelectedProcessName.FillWeight = 119.797F;
            this.SelectedProcessName.HeaderText = "Process Name";
            this.SelectedProcessName.MinimumWidth = 99;
            this.SelectedProcessName.Name = "SelectedProcessName";
            this.SelectedProcessName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedProcessName.Width = 118;
            // 
            // SelectedProcessStartupParameters
            // 
            this.SelectedProcessStartupParameters.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SelectedProcessStartupParameters.FillWeight = 119.797F;
            this.SelectedProcessStartupParameters.HeaderText = "Startup Parameters";
            this.SelectedProcessStartupParameters.MinimumWidth = 500;
            this.SelectedProcessStartupParameters.Name = "SelectedProcessStartupParameters";
            this.SelectedProcessStartupParameters.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedProcessStartupParameters.Width = 500;
            // 
            // selectedProcessLabel
            // 
            this.selectedProcessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedProcessLabel.AutoSize = true;
            this.selectedProcessLabel.Location = new System.Drawing.Point(727, 123);
            this.selectedProcessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedProcessLabel.Name = "selectedProcessLabel";
            this.selectedProcessLabel.Size = new System.Drawing.Size(133, 17);
            this.selectedProcessLabel.TabIndex = 16;
            this.selectedProcessLabel.Text = "Selected Processes";
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(231, 101);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(153, 17);
            this.searchLabel.TabIndex = 17;
            this.searchLabel.Text = "Search by name or ID :";
            // 
            // systemProcessesLabel
            // 
            this.systemProcessesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.systemProcessesLabel.AutoSize = true;
            this.systemProcessesLabel.Location = new System.Drawing.Point(168, 123);
            this.systemProcessesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.systemProcessesLabel.Name = "systemProcessesLabel";
            this.systemProcessesLabel.Size = new System.Drawing.Size(124, 17);
            this.systemProcessesLabel.TabIndex = 18;
            this.systemProcessesLabel.Text = "System Processes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // monitorProcessBar
            // 
            this.monitorProcessBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monitorProcessBar.Location = new System.Drawing.Point(128, 645);
            this.monitorProcessBar.Margin = new System.Windows.Forms.Padding(4);
            this.monitorProcessBar.Name = "monitorProcessBar";
            this.monitorProcessBar.Size = new System.Drawing.Size(789, 31);
            this.monitorProcessBar.TabIndex = 21;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(9, 145);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.processGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.selectedProcessGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1035, 388);
            this.splitContainer1.SplitterDistance = 513;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 22;
            // 
            // processMonitorUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.monitorProcessBar);
            this.Controls.Add(this.systemProcessesLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.selectedProcessLabel);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.fileFormatBox);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.outputFileTextBox);
            this.Controls.Add(this.SamplingRate);
            this.Controls.Add(this.fileFormatLabel);
            this.Controls.Add(this.outputPathLabel);
            this.Controls.Add(this.TimeSampleLabel);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "processMonitorUIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Monitoring";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.processMonitorUIMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplingRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedProcessGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView processGrid;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label TimeSampleLabel;
        private System.Windows.Forms.Label outputPathLabel;
        private System.Windows.Forms.Label fileFormatLabel;
        private System.Windows.Forms.NumericUpDown SamplingRate;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.ComboBox fileFormatBox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.DataGridView selectedProcessGrid;
        private System.Windows.Forms.Label selectedProcessLabel;
        private Label searchLabel;
        internal Label systemProcessesLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem viewHelpToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private DataGridViewCheckBoxColumn ProcessSelected;
        private DataGridViewTextBoxColumn ProcessID;
        private DataGridViewTextBoxColumn ProcessName;
        private DataGridViewTextBoxColumn StartupParameters;
        private ProgressBar monitorProcessBar;
        private SplitContainer splitContainer1;
        private DataGridViewCheckBoxColumn SelectedCheckBox;
        private DataGridViewTextBoxColumn SelectedProcessID;
        private DataGridViewTextBoxColumn SelectedProcessName;
        private DataGridViewTextBoxColumn SelectedProcessStartupParameters;
    }
}

