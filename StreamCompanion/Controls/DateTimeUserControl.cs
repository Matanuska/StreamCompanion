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

            loadCboPredefinedDate();

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

        private Boolean isfirst = true ;
        public Boolean isFirst { 
            get { 
                return isfirst;
            } 
            set { 
                isfirst = value;
                show();
            }
        }

        private Boolean islast = true;
        public  Boolean isLast { 
            get { 
                return islast; 
            } 
            set { 
                islast = value;
                show();
            } 
        }

        private void show()
        {
            if(isfirst && islast)
            {
                lblSeparator.Visible = false;
                btnRemove.Visible = false;
                btnAdd.Visible = true;
            }
            else
            {
                if(!isfirst && !islast)
                {
                    lblSeparator.Visible = true;
                    btnRemove.Visible = true;
                    btnAdd.Visible = false;
                }
                else
                {
                    if(isfirst && !islast)
                    {
                        lblSeparator.Visible = false;
                        btnRemove.Visible = false;
                        btnAdd.Visible = false;
                    }
                    else
                    {
                        lblSeparator.Visible = true;
                        btnRemove.Visible = true;
                        btnAdd.Visible = true;
                    }

                }
            }
        }

        string predefineddateformatselected = null;
        void loadCboPredefinedDate()
        {
            List<string> lstdate = new List<string>();
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                var f = ci.DateTimeFormat;
                if (!lstdate.Contains(f.LongDatePattern))
                {
                    lstdate.Add(f.LongDatePattern);
                }
                if (!lstdate.Contains(f.MonthDayPattern))
                {
                    lstdate.Add(f.MonthDayPattern);
                }
                if (!lstdate.Contains(f.RFC1123Pattern))
                {
                    lstdate.Add(f.RFC1123Pattern);
                }
                if (!lstdate.Contains(f.ShortDatePattern))
                {
                    lstdate.Add(f.ShortDatePattern);
                }
                if (!lstdate.Contains(f.YearMonthPattern))
                {
                    lstdate.Add(f.YearMonthPattern);
                }
            }

            lstdate.Sort();

            cboPredefinedDateFormat.DataSource = lstdate;

            if(string.IsNullOrEmpty(predefineddateformatselected) )
            {
                cboPredefinedDateFormat.SelectedItem = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            }

            this.cboPredefinedDateFormat.SelectedIndexChanged += new System.EventHandler(this.cboPredefinedDateFormat_SelectedIndexChanged);

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
                    if(cboPredefinedTimeFormat.SelectedIndex == -1) { 
                        cboPredefinedTimeFormat.SelectedIndex = 0;
                    }
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

        private void cboCulture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboPredefinedDateFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            predefineddateformatselected = cboPredefinedDateFormat.SelectedItem.ToString();
        }
    }
}
