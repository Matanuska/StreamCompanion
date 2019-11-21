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
            panelCustomFormat.Location = panelPredefinedOutputCulture.Location;
            panelPredefinedOutputDate.Location = panelPredefinedOutputCulture.Location;
            panelPredefinedOutputTime.Location = panelPredefinedOutputCulture.Location;

            radioBtnDate.Checked = true;
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


        public void DefineFormatPanel(object sender, EventArgs e)
        {
            if (radioBtnDate.Checked == true)
            {
                panelPredefinedOutputCulture.Visible = false;
                panelPredefinedOutputTime.Visible = false;
                if (radioBtnPrefedinedOutputFormat.Checked == true)
                {
                    panelCustomFormat.Visible = false;
                    panelPredefinedOutputDate.Visible = true;
                }
                else
                {
                    panelPredefinedOutputDate.Visible = false;
                    panelCustomFormat.Visible = true;
                    
                }
            }
            if (radioBtnTime.Checked == true)
            {
                panelPredefinedOutputDate.Visible = false;
                panelPredefinedOutputCulture.Visible = false;
                if (radioBtnPrefedinedOutputFormat.Checked == true)
                {
                    panelCustomFormat.Visible = false;
                    panelPredefinedOutputTime.Visible = true;
                }
                else
                {
                    panelCustomFormat.Visible = true;
                    panelPredefinedOutputTime.Visible = false;
                }
            }
            if (radioBtnDateAndTime.Checked == true)
            {
                panelPredefinedOutputDate.Visible = false;
                panelPredefinedOutputTime.Visible = false;
                if (radioBtnPrefedinedOutputFormat.Checked == true)
                {
                    panelCustomFormat.Visible = false;
                    panelPredefinedOutputCulture.Visible = true;
                }
                else
                {
                    panelCustomFormat.Visible = true;
                    panelPredefinedOutputCulture.Visible = false;
                }

            }

        }
    }
}
