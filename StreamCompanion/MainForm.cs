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


namespace StreamCompanion
{
    public partial class MainForm : Form
    {

        string[] portnames;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            portnames = SerialPort.GetPortNames();
            loadComPorts();
            dateTimeUserControl1.InstanceNumber = 1;
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
                    //cboSerialPortsList.Items.Add(new ComboboxItem(portnames[i].ToString(), tList[i].ToString()));
                    checkedListBox1.Items.Add(tList[i].ToString());
                }

            }


        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var portslist = (CheckedListBox)sender;
            foreach(var port in portslist.CheckedItems)
            {
                //Console.WriteLine(port);
            }

            if(e.NewValue == CheckState.Checked)
            {
                Console.WriteLine(portnames[e.Index]);
                foreach(UserControl control in flowLayoutPanel1.Controls.OfType<ICommuniquant>())
                {
                    (control as DateTimeUserControl).AddPort(portnames[e.Index]);                    
                }
            }
            else
            {
                foreach (UserControl control in flowLayoutPanel1.Controls.OfType<ICommuniquant>())
                {
                    (control as DateTimeUserControl).RemovePort(portnames[e.Index]);
                }
            }

        }
    }
}
