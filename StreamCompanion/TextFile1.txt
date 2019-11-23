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


        Classes.ClockTimer myTimer = new Classes.ClockTimer();

        public void Init()
        {
            panelCustomFormat.Location = panelPredefinedOutputDate.Location;            
            panelPredefinedOutputTime.Location = panelPredefinedOutputDate.Location;

            radioBtnDate.Checked = true;
            radioBtnPrefedinedOutputFormat.Checked = true;
            cboTimezone.DataSource = TimeZoneInfo.GetSystemTimeZones().ToList();
            cboTimezone.SelectedValue = this.TimeZoneInfo.Id;
            this.cboTimezone.SelectedIndexChanged += new System.EventHandler(this.cboTimezone_SelectedIndexChanged);


            var cultureList = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();            
            cultureList.Sort((p1, p2) => string.Compare(p1.DisplayName, p2.DisplayName, true));            
            cboCulture.DataSource = cultureList;
            cboCulture.SelectedValue = this.Culture.Name;// CultureInfo.CurrentUICulture.Name;
            this.cboCulture.SelectedIndexChanged += new System.EventHandler(this.cboCulture_SelectedIndexChanged);


            loadCboPredefinedDate();

            //timer1.Interval = 250;
            //timer1.Enabled = true;
            
            myTimer.TimeChanged += MyTimer_TimeChanged;
            chkEnabled.Checked = true;


            radioBtnDate.CheckedChanged += setClockTimerParameters;
            radioBtnTime.CheckedChanged += setClockTimerParameters;
            radioBtnDateAndTime.CheckedChanged += setClockTimerParameters;

        }


        private void setClockTimerParameters(object sender, EventArgs e)
        {
            var checkedButton = panelRadioButonFormat.Controls.OfType<RadioButton>()
              .FirstOrDefault(r => r.Checked);

            var displayformat = "";

            switch (checkedButton.Name)
            {
                case "radioBtnDate":
                    displayformat = predefineddateformatselected;
                    break;
                case "radioBtnTime":
                    displayformat = cboPredefinedTimeFormat.Text;
                    break;
                case "radioBtnDateAndTime":
                    displayformat = this.getCultureDateTimeFormat();
                    break;

            }

            myTimer.TimeFormat = displayformat;
            myTimer.TimeZone = this.TimeZoneInfo;
        }

        private void MyTimer_TimeChanged(object sender, Classes.ThresholdReachedEventArgs e)
        {
            //label1.Text = e.DateTime.ToString();
            lblOutputSample.Text = string.Concat("[", e.DateTime.ToString(), "]");
        }

        private CultureInfo selectedCulture = CultureInfo.CurrentUICulture;

        public CultureInfo Culture
        {
            get { return selectedCulture ; }
            set { selectedCulture  = value; }
        }



        private TimeZoneInfo selectedTimeZone = TimeZoneInfo.Local;

        public TimeZoneInfo TimeZoneInfo
        {
            get { return selectedTimeZone; }
            set { selectedTimeZone = value; }
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
                cboPredefinedDateFormat.SelectedItem = predefineddateformatselected =  CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;                 
            }

            
            this.cboPredefinedDateFormat.SelectedIndexChanged += new System.EventHandler(this.cboPredefinedDateFormat_SelectedIndexChanged);

        }

        public void DefineFormatPanel(object sender, EventArgs e)
        {
            if (radioBtnDate.Checked == true)
            {
                panelPredefinedOutputCulture.Visible = true;                
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
            CultureInfo ci = CultureInfo.GetCultureInfo(((CultureInfo)((ComboBox)sender).SelectedItem).Name);
            this.Culture = ci;
            
            myTimer.TimeFormat = this.getCultureDateTimeFormat();

        }

        private string getCultureDateTimeFormat()
        {
           return string.Concat(this.Culture.DateTimeFormat.ShortDatePattern, " ", this.Culture.DateTimeFormat.LongTimePattern);
            
        }

        private void cboPredefinedDateFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            predefineddateformatselected = cboPredefinedDateFormat.SelectedItem.ToString();
        }


        private void toto()
        {
            var checkedButton = panelRadioButonFormat.Controls.OfType<RadioButton>()
                          .FirstOrDefault(r => r.Checked);

            var displayformat = "";

            switch (checkedButton.Name)
            {
                case "radioBtnDate":
                    displayformat = predefineddateformatselected;
                    break;
                case "radioBtnTime":
                    displayformat = cboPredefinedTimeFormat.Text;
                    break;
                case "radioBtnDateAndTime":
                    displayformat = this.getCultureDateTimeFormat();
                    break;

            }
            DateTime timeUtc = DateTime.UtcNow;
            DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, selectedTimeZone);

            lblOutputSample.Text = string.Concat("[", cstTime.ToString(displayformat), "]");
        }
        

        private void cboTimezone_SelectedIndexChanged(object sender, EventArgs e)
        {
                this.TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(((TimeZoneInfo)((ComboBox)sender).SelectedItem).Id);
            myTimer.TimeZone = this.TimeZoneInfo;

        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {            
            openFileDialog1.ShowDialog();
        }

        private void cboPredefinedTimeFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            myTimer.TimeFormat = cboPredefinedTimeFormat.Text;
        }

        private void chkEnabled_CheckedChanged(object sender, EventArgs e)
        {
            myTimer.Enabled = ((CheckBox)sender).Checked;
        }

        private void cboPredefinedDateFormat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            myTimer.TimeFormat = ((ComboBox)sender).Text;
        }
    }
}
