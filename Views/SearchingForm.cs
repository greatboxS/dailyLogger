using DailyLogger.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DailyLogger.Models.DLogger;

namespace DailyLogger.Views
{
    public partial class SearchingForm : Form
    {
        public SearchingForm()
        {
            InitializeComponent();
            cbxSearchingMode.SelectedIndex = 0;
        }

        private void SearchingForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchingDate.Text))
                txtSearchingDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (string.IsNullOrEmpty(txtHour.Text))
                txtHour.Text = DateTime.Now.Hour.ToString();
            if (string.IsNullOrEmpty(txtMins.Text))
                txtMins.Text = DateTime.Now.Minute.ToString();
        }

        private void btnSearching_Click(object sender, EventArgs e)
        {
            DateTime searchingDate = new DateTime();
            DateTime.TryParseExact(txtSearchingDate.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, 
                System.Globalization.DateTimeStyles.None, out searchingDate);
            int hour = 0;
            int min = 0;
            int.TryParse(txtHour.Text, out hour);
            int.TryParse(txtMins.Text, out min);

            lbStatus.Text = $"Searching for data in {searchingDate.ToString("dd/MM/yyyy")} at {hour.ToString("00")}:{min.ToString("00")}";
            switch(cbxSearchingMode.SelectedIndex)
            {
                case 0: // searching by dd
                    DLogger.SearchingData(searchingDate, hour, min, DLogger.SearchingMode.SDAY)
                        .ContinueWith(data => txtSearchingData.SetPropertyThreadSafe(() => txtSearchingData.Text, data.Result));
                    break;
                case 1: // searching by HH
                    DLogger.SearchingData(searchingDate, hour, min, DLogger.SearchingMode.SHOUR)
                        .ContinueWith(data => txtSearchingData.SetPropertyThreadSafe(() => txtSearchingData.Text, data.Result));
                    break;
                case 2: // searching by HH:mm
                    DLogger.SearchingData(searchingDate, hour, min, DLogger.SearchingMode.SHOUR_AND_MIN)
                        .ContinueWith(data => txtSearchingData.SetPropertyThreadSafe(() => txtSearchingData.Text, data.Result));
                    break;
            }
        }
    }
}
