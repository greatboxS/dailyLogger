namespace DailyLogger
{
    partial class DailyLogger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyLogger));
            this.MainMenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenLogFile = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingEnvirement = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingShotKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingAutoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingFont = new System.Windows.Forms.ToolStripMenuItem();
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullScreenMode = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLogger = new System.Windows.Forms.TextBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainBottomPanel = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.RightDockPanel = new System.Windows.Forms.Panel();
            this.listHistories = new System.Windows.Forms.ListView();
            this.TopRightPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SeperatePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DLoggerNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainMenuBar.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.MainBottomPanel.SuspendLayout();
            this.RightDockPanel.SuspendLayout();
            this.TopRightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuBar
            // 
            this.MainMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuBar.Location = new System.Drawing.Point(5, 5);
            this.MainMenuBar.Name = "MainMenuBar";
            this.MainMenuBar.Size = new System.Drawing.Size(904, 24);
            this.MainMenuBar.TabIndex = 0;
            this.MainMenuBar.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSearch,
            this.MenuOpenFolder,
            this.MenuOpenLogFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuSearch
            // 
            this.MenuSearch.Name = "MenuSearch";
            this.MenuSearch.Size = new System.Drawing.Size(260, 22);
            this.MenuSearch.Text = "Search (Ctrl+F)";
            this.MenuSearch.Click += new System.EventHandler(this.MenuSearch_Click);
            // 
            // MenuOpenFolder
            // 
            this.MenuOpenFolder.Name = "MenuOpenFolder";
            this.MenuOpenFolder.Size = new System.Drawing.Size(260, 22);
            this.MenuOpenFolder.Text = "Open container folder (Ctrl+Alt+O)";
            this.MenuOpenFolder.Click += new System.EventHandler(this.MenuOpenFolder_Click);
            // 
            // MenuOpenLogFile
            // 
            this.MenuOpenLogFile.Name = "MenuOpenLogFile";
            this.MenuOpenLogFile.Size = new System.Drawing.Size(260, 22);
            this.MenuOpenLogFile.Text = "Open current log file (Ctrl+Alt+L)";
            this.MenuOpenLogFile.Click += new System.EventHandler(this.MenuOpenLogFile_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingEnvirement,
            this.SettingShotKeys,
            this.SettingAutoSave,
            this.SettingFont,
            this.topMostToolStripMenuItem,
            this.FullScreenMode});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.settingsToolStripMenuItem.Text = "Window";
            // 
            // SettingEnvirement
            // 
            this.SettingEnvirement.Name = "SettingEnvirement";
            this.SettingEnvirement.Size = new System.Drawing.Size(202, 22);
            this.SettingEnvirement.Text = "Envirement Folder";
            this.SettingEnvirement.Click += new System.EventHandler(this.SettingEnvirement_Click);
            // 
            // SettingShotKeys
            // 
            this.SettingShotKeys.Name = "SettingShotKeys";
            this.SettingShotKeys.Size = new System.Drawing.Size(202, 22);
            this.SettingShotKeys.Text = "ShotKeys";
            // 
            // SettingAutoSave
            // 
            this.SettingAutoSave.CheckOnClick = true;
            this.SettingAutoSave.Name = "SettingAutoSave";
            this.SettingAutoSave.Size = new System.Drawing.Size(202, 22);
            this.SettingAutoSave.Text = "Auto save (Ctrl+Alt+K)";
            this.SettingAutoSave.Click += new System.EventHandler(this.SettingAutoSave_Click);
            // 
            // SettingFont
            // 
            this.SettingFont.Name = "SettingFont";
            this.SettingFont.Size = new System.Drawing.Size(202, 22);
            this.SettingFont.Text = "Fonts";
            this.SettingFont.Click += new System.EventHandler(this.SettingFont_Click);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.CheckOnClick = true;
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.topMostToolStripMenuItem.Text = "TopMost (Ctrl+Alt+T)";
            this.topMostToolStripMenuItem.Click += new System.EventHandler(this.topMostToolStripMenuItem_Click);
            // 
            // FullScreenMode
            // 
            this.FullScreenMode.CheckOnClick = true;
            this.FullScreenMode.Name = "FullScreenMode";
            this.FullScreenMode.Size = new System.Drawing.Size(202, 22);
            this.FullScreenMode.Text = "Full screen (Ctrl+Alt+M)";
            this.FullScreenMode.Click += new System.EventHandler(this.FullScreenMode_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuViewHelp,
            this.MenuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MenuViewHelp
            // 
            this.MenuViewHelp.Name = "MenuViewHelp";
            this.MenuViewHelp.Size = new System.Drawing.Size(173, 22);
            this.MenuViewHelp.Text = "View Help";
            this.MenuViewHelp.Click += new System.EventHandler(this.MenuViewHelp_Click);
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(173, 22);
            this.MenuAbout.Text = "About DailyLogger";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // txtLogger
            // 
            this.txtLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogger.Location = new System.Drawing.Point(0, 0);
            this.txtLogger.Multiline = true;
            this.txtLogger.Name = "txtLogger";
            this.txtLogger.Size = new System.Drawing.Size(651, 290);
            this.txtLogger.TabIndex = 1;
            this.txtLogger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogger_KeyDown);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.txtLogger);
            this.MainPanel.Controls.Add(this.MainBottomPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(5, 29);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(651, 321);
            this.MainPanel.TabIndex = 2;
            // 
            // MainBottomPanel
            // 
            this.MainBottomPanel.Controls.Add(this.btnSubmit);
            this.MainBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainBottomPanel.Location = new System.Drawing.Point(0, 290);
            this.MainBottomPanel.Name = "MainBottomPanel";
            this.MainBottomPanel.Padding = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.MainBottomPanel.Size = new System.Drawing.Size(651, 31);
            this.MainBottomPanel.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.Location = new System.Drawing.Point(543, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 25);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Commit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // RightDockPanel
            // 
            this.RightDockPanel.Controls.Add(this.listHistories);
            this.RightDockPanel.Controls.Add(this.TopRightPanel);
            this.RightDockPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightDockPanel.Location = new System.Drawing.Point(666, 29);
            this.RightDockPanel.Name = "RightDockPanel";
            this.RightDockPanel.Size = new System.Drawing.Size(243, 321);
            this.RightDockPanel.TabIndex = 3;
            // 
            // listHistories
            // 
            this.listHistories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listHistories.HideSelection = false;
            this.listHistories.Location = new System.Drawing.Point(0, 39);
            this.listHistories.Name = "listHistories";
            this.listHistories.Size = new System.Drawing.Size(243, 282);
            this.listHistories.TabIndex = 1;
            this.listHistories.UseCompatibleStateImageBehavior = false;
            this.listHistories.View = System.Windows.Forms.View.List;
            // 
            // TopRightPanel
            // 
            this.TopRightPanel.Controls.Add(this.label1);
            this.TopRightPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopRightPanel.Location = new System.Drawing.Point(0, 0);
            this.TopRightPanel.Name = "TopRightPanel";
            this.TopRightPanel.Size = new System.Drawing.Size(243, 39);
            this.TopRightPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Commit histories";
            // 
            // SeperatePanel
            // 
            this.SeperatePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SeperatePanel.Location = new System.Drawing.Point(656, 29);
            this.SeperatePanel.Name = "SeperatePanel";
            this.SeperatePanel.Size = new System.Drawing.Size(10, 321);
            this.SeperatePanel.TabIndex = 4;
            // 
            // DLoggerNotifyIcon
            // 
            this.DLoggerNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("DLoggerNotifyIcon.Icon")));
            this.DLoggerNotifyIcon.Text = "DailyLogger";
            this.DLoggerNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DLoggerNotifyIcon_MouseClick);
            this.DLoggerNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DLoggerNotifyIcon_MouseDoubleClick);
            // 
            // DailyLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 355);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SeperatePanel);
            this.Controls.Add(this.RightDockPanel);
            this.Controls.Add(this.MainMenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenuBar;
            this.Name = "DailyLogger";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Logger";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DailyLogger_FormClosing);
            this.Load += new System.EventHandler(this.DailyLogger_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DailyLogger_KeyDown);
            this.MainMenuBar.ResumeLayout(false);
            this.MainMenuBar.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.MainBottomPanel.ResumeLayout(false);
            this.RightDockPanel.ResumeLayout(false);
            this.TopRightPanel.ResumeLayout(false);
            this.TopRightPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuBar;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingEnvirement;
        private System.Windows.Forms.ToolStripMenuItem SettingShotKeys;
        private System.Windows.Forms.ToolStripMenuItem SettingAutoSave;
        private System.Windows.Forms.TextBox txtLogger;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel MainBottomPanel;
        private System.Windows.Forms.Panel RightDockPanel;
        private System.Windows.Forms.ListView listHistories;
        private System.Windows.Forms.Panel TopRightPanel;
        private System.Windows.Forms.FlowLayoutPanel SeperatePanel;
        private System.Windows.Forms.ToolStripMenuItem SettingFont;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSearch;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenLogFile;
        private System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FullScreenMode;
        private System.Windows.Forms.NotifyIcon DLoggerNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuViewHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
    }
}

