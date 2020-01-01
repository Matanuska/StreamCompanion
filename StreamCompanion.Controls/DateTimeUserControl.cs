using StreamCompanion.Objects;
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
using System.IO;

namespace StreamCompanion.Controls
{


    public enum DisplayType
    {
        Date = 1,
        Time = 2,
        DateTime = 3
    }
    [System.ComponentModel.ComplexBindingProperties("DataSource")]
    public partial class DateTimeUserControl : UserControl, ICommuniquant, IDuplicable
    {


        public static int instance_num = 0;

        private object _ds;


        public object DataSource
        {
            get { return _ds; }
            set {
                _ds = value;
                BindControls();
            }
        }

        private void BindControls()
        {
            if (_ds != null)
            {             
                cboTimezone.DataBindings.Add(new Binding("SelectedValue", _ds, "TimeZone.Id", true, DataSourceUpdateMode.OnPropertyChanged));                
                

            }

        }

        public int Num_Output { get; set; }

        public string OutputFile { get; set; }

        private string outputPath;

        public string OutputPath
        {
            get { return outputPath; }
            set { outputPath = value;
                saveFileDialog1.InitialDirectory = value;
            }
        }



        public DateTimeUserControl()
        {
            instance_num += 1;
            InitializeComponent();
            Init();
        }


        ClockTimer myTimer = new ClockTimer();

        public void Init()
        {
            this.IsFirst = true;
            this.IsLast = true;

            saveFileDialog1.FileOk += SaveFileDialog1_FileOk;
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


        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; timerchange(); }
        }

        public int DisplayType { get; set; }

        private string timervalue = null;
        private void timerchange()
        {
            timervalue = this.Value;
            lblOutputSample.Text = string.Concat("[", this.Value, "]");
            saveDataToFile(this.Value);
            sendToSerials();
        }

        private void sendToSerials()
        {
            SendComMessageEventArgs args = new SendComMessageEventArgs();
            args.Message = string.Concat(txtOutputDataSerialPort.Text, lblOutputSample.Text);
            foreach (var item in chkListOutputSerialPort.CheckedItems)
            {
                args.SerialPort = item.ToString();
                OnReceivedMessage(args);
            }
            
        }

        public int InstanceNumber
        {
            get
            {
                return instance_num;
            }
            set
            {
                instance_num = value;
            }
        }
        
        private void MyTimer_TimeChanged(object sender, ThresholdReachedEventArgs e)
        {
            if (e.DateTime.ToString() != this.Value)
            {
                this.Value = e.DateTime.ToString();                
            }            
        }


        public event EventHandler<SendComMessageEventArgs> SendMessageToSerialPort;
        private void OnReceivedMessage(SendComMessageEventArgs e)
        {
            EventHandler<SendComMessageEventArgs> handler = SendMessageToSerialPort;
            if (handler != null)
            {
                handler(this, e);
            }
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
            setOutputFile();
        }

        private void setOutputFile()
        {
            if (string.IsNullOrEmpty(this.OutputFile))
            {
                var checkedButton = panelRadioButonFormat.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
                defineOutput(checkedButton, null);
            }
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
        
        private Boolean islast;

        public Boolean IsLast
        {
            get { return islast; }
            set { islast = value; ShowSeparatorButtons();  }
        }


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


            this.DisplayType = int.Parse(((RadioButton)checkedButton).Tag.ToString());

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
            setOutputFile();
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
            if (((ComboBox)sender).SelectedItem != null){
                this.TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(((TimeZoneInfo)((ComboBox)sender).SelectedItem).Id);
                myTimer.TimeZone = this.TimeZoneInfo;
            }
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

                SendComMessageEventArgs args = new SendComMessageEventArgs();
                args.Message = "";
                foreach (var item in chkListOutputSerialPort.CheckedItems)
                {
                    args.SerialPort = item.ToString();
                    OnReceivedMessage(args);
                }
            }
        }

        private string userDefinedOutputFilename = null;
        public void defineOutput(object sender, EventArgs e)
        {
                
                string filename = "";
                if(((RadioButton)sender).Name == "radioBtnDate")
                {
                    filename =  (string.IsNullOrEmpty(userDefinedOutputFilename))?string.Concat("date", this.Num_Output.ToString(), ".txt"): userDefinedOutputFilename;
                }
                if (((RadioButton)sender).Name == "radioBtnTime")
                {                    
                    filename = (string.IsNullOrEmpty(userDefinedOutputFilename)) ? string.Concat("time", this.Num_Output.ToString(), ".txt") : userDefinedOutputFilename;
                }
                if (((RadioButton)sender).Name == "radioBtnDateAndTime")
                {                    
                    filename = (string.IsNullOrEmpty(userDefinedOutputFilename)) ? string.Concat("datetime", this.Num_Output.ToString(), ".txt") : userDefinedOutputFilename;
            }
                txtOutputFile.Text = string.Concat(this.OutputPath,"\\", filename);
                saveFileDialog1.FileName = filename;
            }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {            
            saveFileDialog1.ShowDialog();
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (saveFileDialog1.FileName != "")
            {
                txtOutputFile.Text = saveFileDialog1.FileName;

                if (!string.IsNullOrEmpty(Path.GetDirectoryName(saveFileDialog1.FileName)))
                {
                    this.OutputPath = Path.GetDirectoryName(saveFileDialog1.FileName);
                }

                if (
                    Path.GetFileName(saveFileDialog1.FileName) != string.Concat("date", this.Num_Output.ToString(), ".txt")
                    &&
                    Path.GetFileName(saveFileDialog1.FileName) != string.Concat("time", this.Num_Output.ToString(), ".txt")
                    &&
                    Path.GetFileName(saveFileDialog1.FileName) != string.Concat("datetime", this.Num_Output.ToString(), ".txt")
                    )
                {
                    userDefinedOutputFilename = Path.GetFileName(saveFileDialog1.FileName);
                    
                }
                else
                {
                    userDefinedOutputFilename = null;
                }
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

        private void chkCheckListBoxRemoteSerialPort_SelectedIndexChanged(object sender, EventArgs e)
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
            if(IsFirst && IsLast) // true/true
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
                
                if(IsFirst && !IsLast) // true/false
                {

                }
                else
                {
                    if( !IsFirst && IsLast) // false/true
                    {
                        btnAdd.Visible = true;
                        btnRemove.Visible = true;
                    }
                    else // false/false
                    {
                        btnAdd.Visible = false;
                        btnRemove.Visible = true;
                    }
                }
               
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            AddRemoveUserControlEventArgs args = new AddRemoveUserControlEventArgs();
            args.Action = AddRemoveUserControl.Add;
            args.TypeUserControl = this.GetType();
            args.UserControl = this;
            args.ControlContainer = this.Parent;
            OnDuplicateControl(args);

            btnAdd.Visible = false;
            if (!isfirst)
            {
                //btnRemove.Location = btnAdd.Location;
                btnRemove.Visible = true;
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            AddRemoveUserControlEventArgs args = new AddRemoveUserControlEventArgs();
            args.Action = AddRemoveUserControl.Remove;
            args.TypeUserControl = this.GetType();
            args.UserControl = this;
            args.ControlContainer = this.Parent;
            OnDuplicateControl(args);

        }

        private void chkListOutputSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkListOutputSerialPort.CheckedItems.Count > 0)
            {
                txtOutputDataSerialPort.Enabled = false;
            }
            else
            {
                txtOutputDataSerialPort.Enabled = true;
            }
        }

        private void chkListOutputSerialPort_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            SendComMessageEventArgs args = new SendComMessageEventArgs();
            args.SerialPort = ((CheckedListBox)sender).Text;

            if (e.NewValue == CheckState.Checked)
            {
                args.Message = string.Concat(txtOutputDataSerialPort.Text, lblOutputSample.Text);
            }
            else
            {
                args.Message = "";
            }

            OnReceivedMessage(args);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
        }

        private void txtOutputFile_TextChanged(object sender, EventArgs e)
        {            
            this.OutputPath = Path.GetDirectoryName(txtOutputFile.Text);

            if (
                Path.GetFileName(txtOutputFile.Text) != string.Concat("date", this.Num_Output.ToString(), ".txt")
                &&
                Path.GetFileName(txtOutputFile.Text) != string.Concat("time", this.Num_Output.ToString(), ".txt")
                &&
                Path.GetFileName(txtOutputFile.Text) != string.Concat("datetime", this.Num_Output.ToString(), ".txt")
                )
            {
                userDefinedOutputFilename = Path.GetFileName(txtOutputFile.Text);
                saveFileDialog1.FileName = Path.GetFileName(txtOutputFile.Text);
            }
            else
            {
                userDefinedOutputFilename = null;
            }
        }

        private void chkOutputFile_CheckedChanged(object sender, EventArgs e)
        {
            if (Path.GetExtension(txtOutputFile.Text) != ".txt")
            {
                txtOutputFile.Text = string.Concat(txtOutputFile.Text, ".txt");
            }
            if(chkOutputFile.CheckState == CheckState.Checked)
            {
                previousdata = null;
                saveDataToFile(timervalue);
                sendToSerials();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = Path.GetDirectoryName(txtOutputFile.Text),
                UseShellExecute = true,
                Verb = "open"
            });
        }
    }


}
