using DailyLogger.MainViewModels;
using DailyLogger.Models;
using DailyLogger.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyLogger
{
    public partial class DailyLogger : Form
    {
        private DailyLoggerViewModels DailyLoggerViewModels { get; set; }
        private SearchingForm SearchingForm { get; set; }
        private AboutForm AboutForm { get; set; }
        private HelpForm HelpForm { get; set; }
        private bool WindowShowing = true;
        private bool Quit = false;
        private Timer Timer { get; set; }

        ContextMenu NofiyIconContextMenu { get; set; }
        public DailyLogger()
        {
            InitializeComponent();

            var viewModel = JsonConvert.DeserializeObject<DailyLoggerViewModels>(DailyLoggerSetting.Default.DailyLoggerViewModels);

            if (viewModel != null)
                DailyLoggerViewModels = viewModel;
            else
            {
                DailyLoggerViewModels = new DailyLoggerViewModels();
                DailyLoggerSetting.Default.DailyLoggerViewModels = JsonConvert.SerializeObject(DailyLoggerViewModels);
                DailyLoggerSetting.Default.Save();
            }

            Timer = new Timer
            {
                Interval = DailyLoggerViewModels.AppSettingModels.AutoSaveTime * 60 * 1000,
                Enabled = true
            };
            Timer.Tick += Timer_Tick;

            this.txtLogger.Font = DailyLoggerViewModels.AppSettingModels.Font;
            this.TopMost = DailyLoggerViewModels.AppSettingModels.AlwaysOnTop;

            SearchingForm = new SearchingForm();
            AboutForm = new AboutForm();
            HelpForm = new HelpForm();
            NofiyIconContextMenu = new ContextMenu();
            NofiyIconContextMenu.MenuItems.Add("Show", NotifyShowEvent);
            NofiyIconContextMenu.MenuItems.Add("Quit DailyLogger", NotifyQuitEvent);
            DLoggerNotifyIcon.ContextMenu = NofiyIconContextMenu;
        }

        private void NotifyQuitEvent(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you realy want to quit DailyLogger tool?",
                "Quit DailyLogger tool", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Quit = true;
                Application.Exit();
            }
        }

        private void NotifyShowEvent(object sender, EventArgs e)
        {
            ShowHideWindow();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (DailyLoggerViewModels.AppSettingModels.AutoSave)
            {
                DailyLoggerCommit();
            }
        }

        private void DailyLogger_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DailyLoggerCommit();
        }

        private void DailyLoggerCommit()
        {
            string cm = txtLogger.Text;
            txtLogger.Text = "";

            if (string.IsNullOrEmpty(cm))
                return;

            if (DailyLoggerViewModels.OldCommit.Contains(cm))
                return;
            DLogger.WriteCommit(DLogger.LoggerDirectory, cm);
            DailyLoggerViewModels.OldCommit.Add(cm);
            txtLogger.Text = "";
            listHistories.Items.Add($"{DateTime.Now.ToString("-> HH:mm:ss")} : {cm.Length} characters");
        }

        private void DailyLogger_KeyDown(object sender, KeyEventArgs e)
        {
            CheckKeyData(e.KeyData);
        }

        private void txtLogger_KeyDown(object sender, KeyEventArgs e)
        {
            CheckKeyData(e.KeyData);
        }

        private void CheckKeyData(Keys keyData)
        {
            if (keyData == (DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.OpenCurrentLogFolder[0]    // Open log folder
                   | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.OpenCurrentLogFolder[1]
                   | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.OpenCurrentLogFolder[2]))
            {
                try
                {
                    System.Diagnostics.Process.Start(DLogger.LoggerDirectory);
                }
                catch { }
            }
            else
            if (keyData == (DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.ShowHideForm[0]    // show hide window
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.ShowHideForm[1]
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.ShowHideForm[2]))
            {
                ShowHideWindow();
            }
            else
            if (keyData == (DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.ShowHideNewCommit[0]
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.ShowHideNewCommit[1]
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.ShowHideNewCommit[2]))
            {

            }
            else
            if (keyData == (DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.LogCommit[0]       // Commit
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.LogCommit[1]
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.LogCommit[2]))
            {
                DailyLoggerCommit();
            }
            else
            if (keyData == (DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.ShowLogFile[0]     // Open log file
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.ShowLogFile[1]
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.ShowLogFile[2]))
            {
                try
                {
                    System.Diagnostics.Process.Start(DLogger.TodayLoggerFile);
                }
                catch { }
            }
            else
            if (keyData == (DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.AlwaysOnTop[0]     // Set on top mode
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.AlwaysOnTop[1]
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.AlwaysOnTop[2]))
            {
                DailyLoggerViewModels.AppSettingModels.AlwaysOnTop = !DailyLoggerViewModels.AppSettingModels.AlwaysOnTop;
                this.TopMost = topMostToolStripMenuItem.Checked = DailyLoggerViewModels.AppSettingModels.AlwaysOnTop;
                DailyLoggerViewModels.SaveSetting();
            }
            else
            if (keyData == (DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.Searching[0]     // Set searching 
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.Searching[1]))
            {
                Searching();
            }
            else
            if (keyData == (DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.AutoSave[0]     // Set Auto save mode 
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.AutoSave[1]
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.AutoSave[2]))

            {
                DailyLoggerViewModels.AppSettingModels.AutoSave = !DailyLoggerViewModels.AppSettingModels.AutoSave;
                SettingAutoSave.Checked = DailyLoggerViewModels.AppSettingModels.AutoSave;
                DailyLoggerViewModels.SaveSetting();
            }
            else
            if (keyData == (DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.FullScreen[0]     // Set Full screen mode 
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.FullScreen[1]
                | DailyLoggerViewModels.AppSettingModels.ShotKeysSettingModels.FullScreen[2]))

            {
                FullScreenMode.Checked = !FullScreenMode.Checked;
                if (FullScreenMode.Checked)
                    this.WindowState = FormWindowState.Maximized;
                else
                    this.WindowState = FormWindowState.Normal;
            }
        }

        private void Searching()
        {
            if (SearchingForm == null)
                SearchingForm = new SearchingForm();
            else
                if (SearchingForm.IsDisposed)
                SearchingForm = new SearchingForm();

            SearchingForm.Show();
            SearchingForm.BringToFront();
        }

        private void SettingFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() != DialogResult.OK)
                return;

            DailyLoggerViewModels.UpdateSetting(fontDialog.Font);
            listHistories.Items.Add($"Update font: {fontDialog.Font.ToString()}");
            txtLogger.Font = fontDialog.Font;
        }

        private void SettingEnvirement_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;

            DailyLoggerViewModels.UpdateSetting(folderBrowserDialog.SelectedPath);
            listHistories.Items.Add($"Update log folder: {folderBrowserDialog.SelectedPath}");
        }

        private void AutoSaveMode()
        {
            DailyLoggerViewModels.AppSettingModels.AutoSave = SettingAutoSave.Checked;
            DailyLoggerViewModels.SaveSetting();
        }
        private void SettingAutoSave_Click(object sender, EventArgs e)
        {
            AutoSaveMode();
        }


        private void OnTopMode()
        {
            this.TopMost = DailyLoggerViewModels.AppSettingModels.AlwaysOnTop = topMostToolStripMenuItem.Checked;
            DailyLoggerViewModels.SaveSetting();

        }
        private void topMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnTopMode();
        }

        private void MenuSearch_Click(object sender, EventArgs e)
        {
            Searching();
        }

        private void MenuOpenLogFile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(DLogger.TodayLoggerFile);
            }
            catch { }
        }

        private void MenuOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(DLogger.LoggerDirectory);
            }
            catch { }
        }

        private void FullScreenMode_Click(object sender, EventArgs e)
        {
            if (FullScreenMode.Checked)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void DailyLogger_FormClosing(object sender, FormClosingEventArgs e)
        {
            DailyLoggerSetting.Default.DailyLoggerViewModels = JsonConvert.SerializeObject(DailyLoggerViewModels);
            DailyLoggerSetting.Default.Save();
            if (Quit)
                return;
            e.Cancel = true;
            ShowHideWindow();

        }

        private void DLoggerNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowHideWindow();
        }

        private void ShowHideWindow()
        {
            if (WindowShowing == false)
            {
                WindowShowing = true;
                this.Show();
                this.WindowState = FormWindowState.Normal;
                DLoggerNotifyIcon.Visible = false;
            }
            else
            {
                WindowShowing = false;
                this.Hide();
                DLoggerNotifyIcon.Visible = true;
            }
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            if (AboutForm == null || AboutForm.IsDisposed)
                AboutForm = new AboutForm();
            AboutForm.ShowDialog();
        }

        private void MenuViewHelp_Click(object sender, EventArgs e)
        {
            if (HelpForm == null || HelpForm.IsDisposed)
                HelpForm = new HelpForm();
            HelpForm.ShowDialog();
        }

        private void DLoggerNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

            }
        }
    }
}
