using StreamCompanion.Classes;
using StreamCompanion.Interfaces;
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
    public partial class DateTimeUserControl : UserControl, ICommuniquant, IDuplicable
    {
        

        public DateTimeUserControl()
        {
            InitializeComponent();
            Init();
        }


        Classes.ClockTimer myTimer = new ClockTimer();

        public void Init()
        {
            this.IsFirst = true;
            this.IsLast = true;

            panelCustomFormat.Location = panelPredefinedOutput.Location;                        

            var cultureList = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();
            cultureList.Sort((p1, p2) => string.Compare(p1.DisplayName, p2.DisplayName, true));
            cboCulture.DataSource = cultureList;            
            cboCulture.SelectedValue = this.CultureInfo.Name;
            cboCulture.SelectedIndexChanged += cboCultureChanged;            

            radioBtnDate.CheckedChanged += loadCboPredefinedFormat;
            radioBtnTime.CheckedChanged += loadCboPredefinedFormat;

            radioBtnDate.Checked = true;
            radioBtnPrefedinedOutputFormat.Checked = true;

            cboTimezone.DataSource = TimeZoneInfo.GetSystemTimeZones().ToList();
            cboTimezone.SelectedValue = this.TimeZoneInfo.Id;

            cboTimezone.SelectedIndexChanged += new System.EventHandler(this.cboTimezone_SelectedIndexChanged);
            
            radioBtnCustomOutputFormat.CheckedChanged += switchPredefinedOrCustomPanel;
            radioBtnPrefedinedOutputFormat.CheckedChanged += switchPredefinedOrCustomPanel;

            loadCboPredefinedFormat(this,null);

            this.cboPredefinedFormats.SelectedIndexChanged += new System.EventHandler(this.cboPredefinedFormats_SelectedIndexChanged);

            myTimer.CultureInfo = this.CultureInfo;
            myTimer.TimeFormat = cboPredefinedFormats.Text;
            myTimer.TimeChanged += MyTimer_TimeChanged;
            chkEnabled.Checked = true;

            ShowSeparatorButtons();


        }

        public int InstanceNumber { get; set; }

        private void MyTimer_TimeChanged(object sender, Classes.ThresholdReachedEventArgs e)
        {

            lblOutputSample.Text = string.Concat("[", e.DateTime.ToString(), "]");
            saveDataToFile(e.DateTime.ToString());
        }

        private CultureInfo selectedCulture = CultureInfo.CurrentUICulture;

        public CultureInfo CultureInfo
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



        private void DateTimeUserControl_Load(object sender, EventArgs e)
        {

        }

        private void cboCulture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private Boolean isfirst;
        public Boolean IsFirst
        {
            get
            {
                return isfirst;
            }
            set
            {
                isfirst = value;
                ShowSeparatorButtons();
            }
        }

        public Boolean IsLast { get; set; }

        private void cboCultureChanged(object sender, EventArgs e){

            this.CultureInfo = CultureInfo.GetCultureInfo(((CultureInfo)((ComboBox)sender).SelectedItem).Name);

            // chargement des formats

            var checkedButton = panelRadioButonFormat.Controls.OfType<RadioButton>()
              .FirstOrDefault(r => r.Checked);

            loadCboPredefinedFormat(sender, e);

            myTimer.CultureInfo = this.CultureInfo;

        }

        private void loadCboPredefinedFormat(object sender, EventArgs e)
        {

            var checkedButton = panelRadioButonFormat.Controls.OfType<RadioButton>()
                                .FirstOrDefault(r => r.Checked);


            List<string> lstdate = new List<string>();
            var f = this.CultureInfo.DateTimeFormat;
            string pattern = "";

            if (checkedButton.Name == "radioBtnDate")
            {
                if (!lstdate.Contains(f.LongDatePattern))
                {
                    lstdate.Add(f.LongDatePattern);
                }
                if (!lstdate.Contains(f.MonthDayPattern))
                {
                    lstdate.Add(f.MonthDayPattern);
                }
                if (!lstdate.Contains(f.ShortDatePattern))
                {
                    lstdate.Add(f.ShortDatePattern);
                    pattern = f.ShortDatePattern;
                }
                if (!lstdate.Contains(f.YearMonthPattern))
                {
                    lstdate.Add(f.YearMonthPattern);
                }
            }
            else
            {
                if (checkedButton.Name == "radioBtnTime")
                {
                    if (!lstdate.Contains(f.LongTimePattern))
                    {
                        lstdate.Add(f.LongTimePattern);
                        pattern = f.LongTimePattern;
                    }
                    if (!lstdate.Contains(f.ShortTimePattern))
                    {
                        lstdate.Add(f.ShortTimePattern);
                    }
                }
                else
                {
                    if (!lstdate.Contains(f.LongDatePattern))
                    {                        
                        if (!lstdate.Contains(f.LongTimePattern))
                        {
                            lstdate.Add(string.Concat(f.LongDatePattern," ",f.LongTimePattern));

                        }
                        if (!lstdate.Contains(f.ShortTimePattern))
                        {
                            lstdate.Add(string.Concat(f.LongDatePattern, " ", f.ShortTimePattern));                            
                        }
                    }
                    if (!lstdate.Contains(f.MonthDayPattern))
                    {
                        if (!lstdate.Contains(f.LongTimePattern))
                        {
                            lstdate.Add(string.Concat(f.MonthDayPattern, " ", f.LongTimePattern));
                        }
                        if (!lstdate.Contains(f.ShortTimePattern))
                        {
                            lstdate.Add(string.Concat(f.MonthDayPattern, " ", f.ShortTimePattern));
                        }
                    }
                    if (!lstdate.Contains(f.ShortDatePattern))
                    {
                        if (!lstdate.Contains(f.LongTimePattern))
                        {
                            lstdate.Add(string.Concat(f.ShortDatePattern, " ", f.LongTimePattern));
                            pattern = string.Concat(f.ShortDatePattern, " ", f.LongTimePattern);
                        }
                        if (!lstdate.Contains(f.ShortTimePattern))
                        {
                            lstdate.Add(string.Concat(f.ShortDatePattern, " ", f.ShortTimePattern));
                        }
                    }
                    if (!lstdate.Contains(f.YearMonthPattern))
                    {
                        if (!lstdate.Contains(f.LongTimePattern))
                        {
                            lstdate.Add(string.Concat(f.YearMonthPattern, " ", f.LongTimePattern));
                        }
                        if (!lstdate.Contains(f.ShortTimePattern))
                        {
                            lstdate.Add(string.Concat(f.YearMonthPattern, " ", f.ShortTimePattern));
                        }
                    }

                }
            }


            lstdate.Sort();

            cboPredefinedFormats.DataSource = lstdate;
                       
            if (radioBtnCustomOutputFormat.Checked == true)
            {                
                this.cboPredefinedFormats.SelectedIndexChanged -= new System.EventHandler(this.cboPredefinedFormats_SelectedIndexChanged);
                cboPredefinedFormats.SelectedItem = pattern;
                this.cboPredefinedFormats.SelectedIndexChanged += new System.EventHandler(this.cboPredefinedFormats_SelectedIndexChanged);
                myTimer.CustomFormat = txtCustomOutputFormat.Text.Trim();
            }
            else
            {
                cboPredefinedFormats.SelectedItem = pattern;
            }



        }


        public void switchPredefinedOrCustomPanel(object sender, EventArgs e)
        {
            var checkedButton = panelOutputFormat.Controls.OfType<RadioButton>()
              .FirstOrDefault(r => r.Checked);

            if(checkedButton.Name == "radioBtnPrefedinedOutputFormat")
            {
                panelPredefinedOutput.Visible = true;
                panelCustomFormat.Visible = false;
                myTimer.TimeFormat = cboPredefinedFormats.Text;
            }
            else
            {
                panelPredefinedOutput.Visible = false;
                panelCustomFormat.Visible = true;                
                myTimer.CustomFormat = txtCustomOutputFormat.Text.Trim();
            }
            
        }

        private void radioBtnTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboTimezone_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(((TimeZoneInfo)((ComboBox)sender).SelectedItem).Id);
            myTimer.TimeZone = this.TimeZoneInfo;
        }

        private void cboPredefinedFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            myTimer.TimeFormat = ((ComboBox)sender).Text;
        }

        private void radioBtnPrefedinedOutputFormat_CheckedChanged(object sender, EventArgs e)
        {            
            radioBtnDate.Enabled = true;
            radioBtnTime.Enabled = true;
            radioBtnDateAndTime.Enabled = true;
        }

        private void radioBtnCustomOutputFormat_CheckedChanged(object sender, EventArgs e)
        {
         
            radioBtnDate.Enabled = false;
            radioBtnTime.Enabled = false;
            radioBtnDateAndTime.Enabled = false;
        }

        private void txtCustomOutputFormat_TextChanged(object sender, EventArgs e)
        {
            myTimer.CustomFormat = ((TextBox)sender).Text.Trim();
        }

        private void chkEnabled_CheckedChanged(object sender, EventArgs e)
        {
            myTimer.Enabled = ((CheckBox)sender).Checked;
            lblOutputSample.Text = string.Empty;
            if(myTimer.Enabled == false)
            {
                saveDataToFile(string.Empty);
            }
        }

        public void defineOutput(object sender, EventArgs e)
        {
                
                string filename = "";
                if(((RadioButton)sender).Name == "radioBtnDate")
                {
                    filename = string.Concat("date", this.InstanceNumber.ToString(), ".txt");
                }
                if (((RadioButton)sender).Name == "radioBtnTime")
                {
                    filename = string.Concat("time", this.InstanceNumber.ToString(), ".txt");
                }
                if (((RadioButton)sender).Name == "radioBtnDateAndTime")
                {
                    filename = string.Concat("datetime", this.InstanceNumber.ToString(), ".txt");
                }
                txtOutputFile.Text = string.Concat(Application.StartupPath,"\\", filename);
            }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                txtOutputFile.Text = saveFileDialog1.FileName;
            }

        }

        private string previousdata = string.Empty;
        private void saveDataToFile(string datatosave)
        {

            if (previousdata != datatosave)
            {
                if (chkOutputFile.Checked == true && txtOutputFile.Text != string.Empty)
                {
                    System.IO.File.WriteAllText(txtOutputFile.Text, datatosave);
                }
                previousdata = datatosave;
            }
        }

        public void AddPort(string port)
        {
            chkCheckListBoxRemoteSerialPort.Items.Add(port);
            chkListOutputSerialPort.Items.Add(port);
        }

        public void RemovePort(string port)
        {
            chkCheckListBoxRemoteSerialPort.Items.Remove(port);
            chkListOutputSerialPort.Items.Remove(port);
        }

        private void ckcCheckListBoxRemoteSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(chkCheckListBoxRemoteSerialPort.CheckedItems.Count > 0)
            {
                txtRemoteControlSerialData.Enabled = false;
            }
            else
            {
                txtRemoteControlSerialData.Enabled = true;
            }
        }

        public void MessageReceived(string port, string message)
        {
            if (message != string.Empty && message == txtRemoteControlSerialData.Text)
            {
                if (chkCheckListBoxRemoteSerialPort.CheckedItems.Contains(port)) { 
                    chkEnabled.Invoke(new MethodInvoker(delegate
                    {
                        chkEnabled.Checked = !chkEnabled.Checked;
                    }));
                 }
            }
        }

        public void ShowSeparatorButtons()
        {
            if(IsFirst && IsLast)
            {
                lblSeparator.Visible = false;
                btnAdd.Visible = true;
                btnRemove.Visible = false;
            }
            else
            {
                if( IsFirst == false)
                {
                    lblSeparator.Visible = true;
                }
               
            }
        }

        public event EventHandler AddControl;
        public void Duplicate(object sender, EventArgs e)
        {
            
            

            AddRemoveUserControlEventArgs args = new AddRemoveUserControlEventArgs();
            args.Action = AddRemoveUserControl.Add;
            args.userControl = this;
            OnDuplicateControl(args);

            EventHandler handler = AddControl;
            if (handler != null)
            {
                handler(this, e);
            }

            btnAdd.Visible = false;

        }


        protected virtual void OnDuplicateControl(AddRemoveUserControlEventArgs e)
        {
            EventHandler<AddRemoveUserControlEventArgs> handler = DuplicateControl;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<AddRemoveUserControlEventArgs> DuplicateControl;

    }


}
