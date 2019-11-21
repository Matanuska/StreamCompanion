using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace StreamCompanion.Controls
{
    public partial class DateTimeUserControl : UserControl
    {
        public DateTimeUserControl()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            panelCustomFormat.Location = panelPredefinedOutputFormat.Location;
            radioBtnPrefedinedOutputFormat.Checked = true;
            cboTimezone.DataSource = TimeZoneInfo.GetSystemTimeZones().ToList();
            cboTimezone.SelectedValue = TimeZoneInfo.Local.Id;

            var cultureList = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();            
            cultureList.Sort((p1, p2) => string.Compare(p1.DisplayName, p2.DisplayName, true));            
            cboCulture.DataSource = cultureList;
            cboCulture.SelectedValue = CultureInfo.CurrentUICulture.Name;
            


            timer1.Interval = 250;
            timer1.Enabled = true;


        }

        private void txtCustomOutputFormat_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimeUserControl_Load(object sender, EventArgs e)
        {

        }

        private void lblRemoteControlSerialData_Click(object sender, EventArgs e)
        {

        }

        private void radioBtnPrefedinedOutputFormat_CheckedChanged(object sender, EventArgs e)
        {
            panelPredefinedOutputFormat.Visible = true;
            panelCustomFormat.Visible = false;
        }

        private void radioBtnCustomOutputFormat_CheckedChanged(object sender, EventArgs e)
        {
            panelPredefinedOutputFormat.Visible = false;
            panelCustomFormat.Visible = true;
        }
    }
}
