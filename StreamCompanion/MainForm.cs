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
        private void MainForm_Load(object sender, EventArgs e)
        {
            st = new Classes.SimpleTime();

            st.CustomerName = "155";
            timeUserControl1.DataSource = st;

            st.PropertyChanged += St_PropertyChanged;
        }


        private void St_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            st.CustomerName = "lll";
        }
    }
}
