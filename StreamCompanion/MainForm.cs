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

        List<KeyValuePair<string, SerialPortManager>> ListenSerialPorts = new List<KeyValuePair<string, SerialPortManager>>();

        public MainForm(CryptoLicense lic)
        {
            license = lic;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
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
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            settingsPanel.Visible = true;
            TimersPanel.Visible = false;
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
                }

            }


        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var portslist = (CheckedListBox)sender;

            SerialPortManager _serialPort = new SerialPortManager();

            if (e.NewValue == CheckState.Checked)
            {
                
                _serialPort.PortName = SetPortName(portnames[e.Index]);
                _serialPort.PortBaudRate = SetPortBaudRate(9600);
                _serialPort.Parity = SetPortParity(Parity.None);
                _serialPort.DataBits = SetPortDataBits(8);
                _serialPort.StopBits = SetPortStopBits(StopBits.One);
                _serialPort.Handshake = SetPortHandshake(Handshake.None);
                
                _serialPort.ReadTimeout = 500;
                _serialPort.WriteTimeout = 500;

                SerialPortManager.OnMessageReceived += SerialPortManager_OnMessageReceived;

                _serialPort.Open();

                ListenSerialPorts.Add(new KeyValuePair<string, SerialPortManager>(portnames[e.Index], _serialPort));

                foreach (UserControl control in flowLayoutPanel1.Controls.OfType<ICommuniquant>())
                {
                    (control as DateTimeUserControl).AddPort(portnames[e.Index]);                    
                }
            }
            else
            {

                KeyValuePair<string, SerialPortManager> _port = ListenSerialPorts.SingleOrDefault(kvp => kvp.Key == portnames[e.Index]);
                
                (_port.Value as SerialPortManager).Close();

                ListenSerialPorts.Remove(ListenSerialPorts.SingleOrDefault(kvp => kvp.Key == portnames[e.Index]));

                foreach (UserControl control in flowLayoutPanel1.Controls.OfType<ICommuniquant>())
                {
                    (control as DateTimeUserControl).RemovePort(portnames[e.Index]);
                }
            }

        }

        private void SerialPortManager_OnMessageReceived(string message, bool isCompleted, bool isSuccess)
        {
            throw new NotImplementedException();
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
        }

        public string SetPortName(string defaultPortName)
        {
            return defaultPortName;
        }

        public int SetPortBaudRate(int defaultPortBaudRate)
        {

            return defaultPortBaudRate;
        }

        public static Parity SetPortParity(Parity defaultPortParity)
        {

        //https://docs.microsoft.com/fr-fr/dotnet/api/system.io.ports.serialport?view=netframework-4.8
            
            return defaultPortParity;
        }

        public  int SetPortDataBits(int defaultPortDataBits)
        {

            return defaultPortDataBits;
        }

        public static StopBits SetPortStopBits(StopBits defaultPortStopBits)
        {

            return defaultPortStopBits;
        }

        public static Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            return defaultPortHandshake;
        }

    }
}
