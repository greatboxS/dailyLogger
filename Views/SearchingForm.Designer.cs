namespace DailyLogger.Views
{
    partial class SearchingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSearchingMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.txtMins = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtSearchingDate = new System.Windows.Forms.TextBox();
            this.btnSearching = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.txtSearchingData = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date: (dd/MM/yyyy)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Searching mode:";
            // 
            // cbxSearchingMode
            // 
            this.cbxSearchingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchingMode.FormattingEnabled = true;
            this.cbxSearchingMode.Items.AddRange(new object[] {
            "dd",
            "HH",
            "HH:mm"});
            this.cbxSearchingMode.Location = new System.Drawing.Point(255, 36);
            this.cbxSearchingMode.Name = "cbxSearchingMode";
            this.cbxSearchingMode.Size = new System.Drawing.Size(72, 21);
            this.cbxSearchingMode.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mins:";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.lbStatus);
            this.HeaderPanel.Controls.Add(this.txtMins);
            this.HeaderPanel.Controls.Add(this.txtHour);
            this.HeaderPanel.Controls.Add(this.txtSearchingDate);
            this.HeaderPanel.Controls.Add(this.btnSearching);
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.label2);
            this.HeaderPanel.Controls.Add(this.label4);
            this.HeaderPanel.Controls.Add(this.cbxSearchingMode);
            this.HeaderPanel.Controls.Add(this.label3);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(703, 70);
            this.HeaderPanel.TabIndex = 8;
            // 
            // txtMins
            // 
            this.txtMins.Location = new System.Drawing.Point(115, 36);
            this.txtMins.Name = "txtMins";
            this.txtMins.Size = new System.Drawing.Size(39, 20);
            this.txtMins.TabIndex = 11;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(39, 36);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(39, 20);
            this.txtHour.TabIndex = 10;
            // 
            // txtSearchingDate
            // 
            this.txtSearchingDate.Location = new System.Drawing.Point(111, 8);
            this.txtSearchingDate.Name = "txtSearchingDate";
            this.txtSearchingDate.Size = new System.Drawing.Size(216, 20);
            this.txtSearchingDate.TabIndex = 9;
            // 
            // btnSearching
            // 
            this.btnSearching.Location = new System.Drawing.Point(333, 8);
            this.btnSearching.Name = "btnSearching";
            this.btnSearching.Size = new System.Drawing.Size(65, 49);
            this.btnSearching.TabIndex = 8;
            this.btnSearching.Text = "SEARCH";
            this.btnSearching.UseVisualStyleBackColor = true;
            this.btnSearching.Click += new System.EventHandler(this.btnSearching_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.txtSearchingData);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 70);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(703, 288);
            this.MainPanel.TabIndex = 9;
            // 
            // txtSearchingData
            // 
            this.txtSearchingData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchingData.Location = new System.Drawing.Point(0, 0);
            this.txtSearchingData.Multiline = true;
            this.txtSearchingData.Name = "txtSearchingData";
            this.txtSearchingData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearchingData.Size = new System.Drawing.Size(703, 288);
            this.txtSearchingData.TabIndex = 0;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(425, 11);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 13);
            this.lbStatus.TabIndex = 12;
            // 
            // SearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 358);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "SearchingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Searching";
            this.Load += new System.EventHandler(this.SearchingForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSearchingMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnSearching;
        private System.Windows.Forms.TextBox txtSearchingData;
        private System.Windows.Forms.TextBox txtMins;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtSearchingDate;
        private System.Windows.Forms.Label lbStatus;
    }
}