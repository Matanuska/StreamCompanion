using System;
using System.ComponentModel;
using System.Windows.Forms;
using StreamCompanion.Classes;
using StreamCompanion.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StreamCompanion.Controls
{
    [ComplexBindingProperties("DataSource")]
    public partial class TimeUserControl : UserControl, ICommuniquant
    {

        public event EventHandler<TimeZoneChangedEventArgs> TimeZoneChanged;

        Classes.ClockTimer ct;

        public TimeUserControl()
        {
            ct = new Classes.ClockTimer();
            InitializeComponent();
            ct.TimeChanged += ClockTimer1_TimeChanged;
            lstTimeFormat.SelectedIndex = 0;
        }

        private void ClockTimer1_TimeChanged(object sender, ThresholdReachedEventArgs e)
        {
            OutputResult.Text = e.DateTime.ToString();
        }

        private object MyDataSource;

        [Browsable(true)]
        [TypeConverter("System.Windows.Forms.Design.DataSourceConverter")]
        [System.ComponentModel.Bindable(true)]
        public object DataSource
        {
            get
            {
                return MyDataSource;
            }
            set
            {
                if (MyDataSource != value)
                {
                    MyDataSource = value;
                    textOutputFile.DataBindings.Add(new Binding("Text", MyDataSource, "CustomerName",false,DataSourceUpdateMode.OnPropertyChanged));
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

            lstTimezones.DataSource = TimeZoneInfo.GetSystemTimeZones().ToList();

            lstTimezones.SelectedValue = TimeZoneInfo.Local.Id;

            OutputResult.Text = DateTime.UtcNow.ToString("HH:mm:ss");
            radioButton1.Checked = true;
            panel2.Location = panel1.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        public TimeZoneInfo TimeZone
        {
            get
            {
                return (lstTimezones.SelectedValue != null) ? (TimeZoneInfo)lstTimezones.SelectedItem : null;

            }
            set
            {
                if (value != null)
                {
                    lstTimezones.SelectedValue = value.Id;
                }
            }
        }
        
        private void lstTimeFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ct.TimeFormat = lstTimeFormat.SelectedItem.ToString();
        }

        private TimeZoneInfo initTZ;
        private void lstTimezones_SelectedIndexChanged(object sender, EventArgs e)
        {
                        
            if (initTZ != lstTimezones.SelectedValue)
            {
               TimeZoneChangedEventArgs args = new TimeZoneChangedEventArgs();
                args.NewTimeZone = (TimeZoneInfo)lstTimezones.SelectedItem; 

               EventHandler<TimeZoneChangedEventArgs> handler = TimeZoneChanged;
               if (handler != null)
               {
                   handler(this, args);
               }

                ct.TimeZone = initTZ = TimeZoneInfo.FindSystemTimeZoneById(lstTimezones.SelectedValue.ToString()); 
                
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void AddPort(string port)
        {
            throw new NotImplementedException();
        }

        public void RemovePort(string port)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string port, string message)
        {
            throw new NotImplementedException();
        }

        public void MessageReceived(string port, string message)
        {
            throw new NotImplementedException();
        }
    }

    public class TimeZoneChangedEventArgs : EventArgs
    {
        public TimeZoneInfo NewTimeZone { get; set; }

    }



}
