using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StreamCompanion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();                       
        
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
            
            timeUserControl1.DataSource = st;
            
            st.PropertyChanged += St_PropertyChanged;            
            l.Add(st);
        }


        private void St_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
           label1.Text = sender.GetType().GetProperty(e.PropertyName).GetValue(sender).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            st.CustomerName = "test";
        }

        private void timeUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
