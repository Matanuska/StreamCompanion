using StreamCompanion.Objects;
using StreamCompanion.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO.Ports;
using System.Management;
using LogicNP.CryptoLicensing;
using System.Resources;
using System.Reflection;
using System.Runtime.Serialization;



namespace StreamCompanion
{
    public partial class MainForm : Form
    {
        ResourceManager rm = new ResourceManager("StreamCompanion.MainForm", Assembly.GetExecutingAssembly());
        string[] portnames;
        CryptoLicense license;

        List<KeyValuePair<string, EnhancedSerialPort>> DetectedSerialPorts = new List<KeyValuePair<string, EnhancedSerialPort>>();
        List<KeyValuePair<string, EnhancedSerialPort>> ListenSerialPorts = new List<KeyValuePair<string, EnhancedSerialPort>>();        


        public MainForm(CryptoLicense lic)
        {
            
            license = lic;
            InitializeComponent();
            CreateFirstsControls();
            Init();
        }

        private void CreateFirstsControls()
        {

            createOneDateTimeUserControl();

        }

        List<DateTimeUserControl> listDateTimeUserControl = new List<DateTimeUserControl>();
        private void createOneDateTimeUserControl()
        {
            DateTimeUserControl dateTimeUserControl;
            dateTimeUserControl = new DateTimeUserControl();
            // 
            // dateTimeUserControl1
            // 
            //dateTimeUserControl.CultureInfo = new System.Globalization.CultureInfo("fr-FR");
            // resources.ApplyResources(dateTimeUserControl1, "dateTimeUserControl1");
            dateTimeUserControl.Name = string.Concat("dateTimeUserControl", dateTimeUserControl.InstanceNumber.ToString());
            //dateTimeUserControl1.TimeZoneInfo = ((System.TimeZoneInfo)(resources.GetObject("dateTimeUserControl1.TimeZoneInfo")));
            //dateTimeUserControl.Load += new System.EventHandler(this.dateTimeUserControl1_Load);
            this.flowLayoutPanel1.Controls.Add(dateTimeUserControl);
            DateTimeClass _dt = new DateTimeClass();
            _dt.TimeZone = TimeZoneInfo.Local;
            dateTimeUserControl.DataSource = _dt;
            dateTimeUserControl.DuplicateControl += DuplicateControl;

            dateTimeUserControl.SendMessageToSerialPort += DateTimeUserControl1_SendMessageToSerialPort;

            int numoutput = 1;
            Boolean trouve = true;
            while (trouve) {
                trouve = false;
                for (int i = 0; i < listDateTimeUserControl.Count; i++)
                {
                    if (((IDuplicable)listDateTimeUserControl[i]).Num_Output == numoutput)
                    {
                        trouve = true;
                        numoutput += 1;
                        break;
                    }
                }
            }

            dateTimeUserControl.Num_Output = numoutput;

            dateTimeUserControl.OutputPath = Application.StartupPath;


            listDateTimeUserControl.Add(dateTimeUserControl);

            for(int i = 0; i< listDateTimeUserControl.Count; i++)
            {
                
                if (i == 0)
                {
                    ((IDuplicable)listDateTimeUserControl[i]).IsFirst = true;
                }
                else
                {
                    ((IDuplicable)listDateTimeUserControl[i]).IsFirst = false;
                }
                
                if (i == listDateTimeUserControl.Count - 1)
                {
                    ((IDuplicable)listDateTimeUserControl[i]).IsLast = true;
                }
                else
                {
                    ((IDuplicable)listDateTimeUserControl[i]).IsLast = false;
                }

            }


        }

        private void DuplicateControl(object sender, AddRemoveUserControlEventArgs e)
        {

            if (e.Action == AddRemoveUserControl.Add)
            {
                switch (e.UserControl.GetType().Name)
                {
                    case "DateTimeUserControl":
                        createOneDateTimeUserControl();

                        break;
                }
            }
            else
            {
                switch (e.UserControl.GetType().Name)
                {
                    case "DateTimeUserControl":
                       int index =  listDateTimeUserControl.FindIndex(a => a == e.UserControl);
                        if (index > -1)
                        {
                            listDateTimeUserControl.RemoveAt(index);                            
                        }

                        break;
                }
                e.ControlContainer.Controls.Remove((UserControl)sender);
                for (int i = 0; i < listDateTimeUserControl.Count; i++)
                {

                    if (i == 0)
                    {
                        ((IDuplicable)listDateTimeUserControl[i]).IsFirst = true;
                    }
                    else
                    {
                        ((IDuplicable)listDateTimeUserControl[i]).IsFirst = false;
                    }

                    if (i == listDateTimeUserControl.Count - 1)
                    {
                        ((IDuplicable)listDateTimeUserControl[i]).IsLast = true;
                    }
                    else
                    {
                        ((IDuplicable)listDateTimeUserControl[i]).IsLast = false;
                    }

                }



            }
           
            //UserControl control = (UserControl)Activator.CreateInstance(e.UserControl.GetType());


            //DateTimeClass _dt = new DateTimeClass();
            //_dt.TimeZone = TimeZoneInfo.Local;
            //((IDuplicable)control).DataSource = _dt;

            //e.ControlContainer.Controls.Add(control);


            //((IDuplicable)control).IsFirst = false;

            //((IDuplicable)control).DuplicateControl += DuplicateControl;

        }

        private void Init()
        {


            TimersPanel.Dock = DockStyle.Fill;
            comPanel.Dock = DockStyle.Fill;
            settingsPanel.Dock = DockStyle.Fill;
            
            portnames = SerialPort.GetPortNames();
            loadComPorts();
            
            //// standard
            //if(license.Features == LicenseFeatures.Feature1)
            //{
            //    toolStripStatusLabel1.Text = string.Concat("Standard version expire on"," ", license.DateExpires.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern));
            //    toolStripStatusLabel1.ToolTipText = string.Concat(rm.GetString("licenceexpirationdate", CultureInfo.CurrentCulture), " : ", license.DateExpires.ToString());
            //}
            //if (license.Features == LicenseFeatures.Feature2)
            //{
            //    toolStripStatusLabel1.Text = string.Concat("Pro version");
            //    toolStripStatusLabel1.ToolTipText = string.Concat(rm.GetString("licenceexpirationdate", CultureInfo.CurrentCulture), " : ", license.DateExpires.ToString());
            //}
            //if (license.Features == LicenseFeatures.Feature3)
            //{
            //    toolStripStatusLabel1.Text = "Stream Companion Ultimate";
            //}
            
        }

        private void DateTimeUserControl1_SendMessageToSerialPort(object sender, SendComMessageEventArgs e)
        {
            

            KeyValuePair<string, EnhancedSerialPort> _p = ListenSerialPorts.SingleOrDefault(kvp => kvp.Key == e.SerialPort);

            EnhancedSerialPort _port = _p.Value;
            
            _port.WriteLine(e.Message.ToString());
            
            String[] lines = rtxtComConsole.Text.Split('\n');

            string txt = string.Concat("->", e.SerialPort, " : ", e.Message, Environment.NewLine);


            if(rtxtComConsole.Lines.Length > 10)
            {
                List<string> l = rtxtComConsole.Lines.ToList();
                l.RemoveAt(0);
                rtxtComConsole.Lines = l.ToArray();
                rtxtComConsole.Refresh();
            }
            
            rtxtComConsole.AppendText(txt);
            
            rtxtComConsole.SelectionStart = rtxtComConsole.Text.Length;
            rtxtComConsole.ScrollToCaret();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            comPanel.Visible = false;
            TimersPanel.Visible = false;
            settingsPanel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
            TimersPanel.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void St_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
           //label1.Text = sender.GetType().GetProperty(e.PropertyName).GetValue(sender).ToString();
        }

        private void loadComPorts(){

            using (var searcher = new ManagementObjectSearcher
                ("SELECT * FROM WIN32_SerialPort"))
            {                
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                var tList = (from n in portnames
                             join p in ports on n equals p["DeviceID"].ToString()
                             select n + " - " + p["Caption"]).ToList();


                for (int i = 0; i < portnames.Length; i++)
                {
                    if (i < tList.Count)
                    {
                        checkedListBox1.Items.Add(tList[i].ToString());
                    }
                    else
                    {
                        checkedListBox1.Items.Add(portnames[i].ToString());
                    }

                    EnhancedSerialPort _serialPort = new EnhancedSerialPort(portnames[i].ToString());
                   

                    DetectedSerialPorts.Add(new KeyValuePair<string, EnhancedSerialPort>(portnames[i], _serialPort));

                }

                

            }


        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var portslist = (CheckedListBox)sender;
           

            if (e.NewValue == CheckState.Checked)
            {

                 KeyValuePair<string, EnhancedSerialPort> x = DetectedSerialPorts.SingleOrDefault(kvp => kvp.Key == portnames[e.Index]);

                EnhancedSerialPort _port = x.Value;

                _port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);              
                
                try
                {
                    _port.Open();

                    ListenSerialPorts.Add(new KeyValuePair<string, EnhancedSerialPort>(portnames[e.Index], _port));                    

                    foreach (UserControl control in flowLayoutPanel1.Controls.OfType<ICommuniquant>())
                    {
                        (control as DateTimeUserControl).AddPort(portnames[e.Index]);
                    }
                }
                catch (Exception ex) {
                    e.NewValue = CheckState.Unchecked;
                    MessageBox.Show(ex.Message);                    
                }
            }
            else
            {

                KeyValuePair<string, EnhancedSerialPort> _port = ListenSerialPorts.SingleOrDefault(kvp => kvp.Key == portnames[e.Index]);
                
                (_port.Value as EnhancedSerialPort).Close();

                ListenSerialPorts.Remove(ListenSerialPorts.SingleOrDefault(kvp => kvp.Key == portnames[e.Index]));

                foreach (UserControl control in flowLayoutPanel1.Controls.OfType<ICommuniquant>())
                {
                    (control as DateTimeUserControl).RemovePort(portnames[e.Index]);
                }

                
            }

        }


        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort spm = (SerialPort)sender;
            string indata = spm.ReadExisting();

            rtxtComConsole.Invoke(new MethodInvoker(delegate
            {
                rtxtComConsole.Text = string.Concat(rtxtComConsole.Text, spm.PortName,"->",indata);
            }));
            

           foreach (UserControl control in flowLayoutPanel1.Controls.OfType<ICommuniquant>())
            {
                (control as DateTimeUserControl).MessageReceived(spm.PortName,indata.Replace("\r\n",string.Empty));
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var portslist = (CheckedListBox)sender;
            KeyValuePair<string, EnhancedSerialPort> _port = DetectedSerialPorts.SingleOrDefault(kvp => kvp.Key == portnames[portslist.SelectedIndex]);
            if(_port.Value != null)
                propertyGrid1.SelectedObject = (SerialPort)_port.Value;

            if(((CheckedListBox)sender).GetItemCheckState(portslist.SelectedIndex) == CheckState.Checked)
            {
                propertyGrid1.Enabled = false;
            }
            else
            {
                propertyGrid1.Enabled = true;
            }
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void TimersPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            comPanel.Visible = true;
            TimersPanel.Visible = false;
            settingsPanel.Visible = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            TimersPanel.Visible = true;
            comPanel.Visible = false;
            settingsPanel.Visible = false;
        }
    }
}
