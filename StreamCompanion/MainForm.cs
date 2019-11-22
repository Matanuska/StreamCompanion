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


namespace StreamCompanion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            dateTimeUserControl1.isFirst = true;
            dateTimeUserControl1.isLast = true;
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            settingsPanel.Visible = true;
            tabControl1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
            tabControl1.Visible = true;
        }
        Classes.SimpleTime st;
        List<Classes.SimpleTime> l = new List<Classes.SimpleTime>();
        private void MainForm_Load(object sender, EventArgs e)
        {
            st = new Classes.SimpleTime();

            //timeUserControl1.DataSource = st;

            //  st.PropertyChanged += St_PropertyChanged;            
            //  l.Add(st);


            List<string> lstdate = new List<string>();
            foreach(CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures)){
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

            listBox1.DataSource = lstdate;

        }


        private void St_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
           //label1.Text = sender.GetType().GetProperty(e.PropertyName).GetValue(sender).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            st.CustomerName = "test";
        }

        private void timeUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void timeUserControl2_Load(object sender, EventArgs e)
        {

        }

        private void dateTimeUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
