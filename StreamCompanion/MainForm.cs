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

        List<KeyValuePair<string, SerialPortManager>> DetectedSerialPorts = new List<KeyValuePair<string, SerialPortManager>>();
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

                    SerialPortManager _serialPort = new SerialPortManager();                    

                    DetectedSerialPorts.Add(new KeyValuePair<string, SerialPortManager>(portnames[i], _serialPort));

                }

                

            }


        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var portslist = (CheckedListBox)sender;
           

            if (e.NewValue == CheckState.Checked)
            {

                KeyValuePair<string, SerialPortManager> x = DetectedSerialPorts.SingleOrDefault(kvp => kvp.Key == portnames[e.Index]);

                SerialPortManager _port = x.Value;

                _port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                _port.Open();

                ListenSerialPorts.Add(new KeyValuePair<string, SerialPortManager>(portnames[e.Index], _port));

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

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var portslist = (CheckedListBox)sender;
            KeyValuePair<string, SerialPortManager> _port = DetectedSerialPorts.SingleOrDefault(kvp => kvp.Key == portnames[portslist.SelectedIndex]);
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
    }
}
