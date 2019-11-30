using StreamCompanion.Classes;
using StreamCompanion.Interfaces;
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
            Init();
        }

        private void Init()
        {
            TimersPanel.Dock = DockStyle.Fill;
            comPanel.Dock = DockStyle.Fill;
            settingsPanel.Dock = DockStyle.Fill;


            portnames = SerialPort.GetPortNames();
            loadComPorts();
            dateTimeUserControl1.InstanceNumber = 1;
            // standard
            if(license.Features == LicenseFeatures.Feature1)
            {
                toolStripStatusLabel1.Text = string.Concat("Standard version expire on"," ", license.DateExpires.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern));
                toolStripStatusLabel1.ToolTipText = string.Concat(rm.GetString("licenceexpirationdate", CultureInfo.CurrentCulture), " : ", license.DateExpires.ToString());
            }
            if (license.Features == LicenseFeatures.Feature2)
            {
                toolStripStatusLabel1.Text = string.Concat("Pro version");
                toolStripStatusLabel1.ToolTipText = string.Concat(rm.GetString("licenceexpirationdate", CultureInfo.CurrentCulture), " : ", license.DateExpires.ToString());
            }
            if (license.Features == LicenseFeatures.Feature3)
            {
                toolStripStatusLabel1.Text = "Stream Companion Ultimate";
            }

            dateTimeUserControl1.DuplicateControl += DuplicateControl;

            dateTimeUserControl1.SendMessageToSerialPort += DateTimeUserControl1_SendMessageToSerialPort;

        }

        private void DateTimeUserControl1_SendMessageToSerialPort(object sender, SendComMessageEventArgs e)
        {
            Console.WriteLine(e.Message);

            KeyValuePair<string, EnhancedSerialPort> _p = ListenSerialPorts.SingleOrDefault(kvp => kvp.Key == e.SerialPort);

            EnhancedSerialPort _port = _p.Value;

            _port.Write(e.Message);
            rtxtComConsole.Text = string.Concat(rtxtComConsole.Text, "->", e.SerialPort, " : " ,e.Message,"\r\n");

            Console.WriteLine(e.Message);

        }

        private void DuplicateControl(object sender, AddRemoveUserControlEventArgs e)
        {
            DateTimeUserControl control = new DateTimeUserControl();

            

            e.ControlContainer.Controls.Add(control);


            //  var z = Type.GetType(e.TypeUserControl);
            //            ((UserControl)e.GetType()).Parent.Controls.Add(typecontrol);


            var textBoxType = typeof(Control).Assembly.GetType("System.Windows.Forms.TextBox", true);
            var textBox = Activator.CreateInstance(textBoxType);


            var t = typeof(UserControl).Assembly.GetType(e.TypeUserControl.FullName, true);
            //  e.ControlContainer.Controls.Add(textBox);



            control.IsFirst = false;            

            control.DuplicateControl += DuplicateControl;
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
       // Classes.SimpleTime st;
        //List<Classes.SimpleTime> l = new List<Classes.SimpleTime>();
        private void MainForm_Load(object sender, EventArgs e)
        {
           // st = new Classes.SimpleTime();

            //timeUserControl1.DataSource = st;

            //  st.PropertyChanged += St_PropertyChanged;            
            //  l.Add(st);

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

        private void dateTimeUserControl1_Load(object sender, EventArgs e)
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
