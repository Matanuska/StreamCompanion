using System;
using System.ComponentModel;
using System.Windows.Forms;
using StreamCompanion.Interfaces;

namespace StreamCompanion.Controls
{
    [ComplexBindingProperties("DataSource")]
    public partial class TimeUserControl : UserControl, ICommuniquant
    {
        public TimeUserControl()
        {
            InitializeComponent();

            
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
                    textBox1.DataBindings.Add(new Binding("Text", MyDataSource, "CustomerName"));
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            label7.Text = DateTime.UtcNow.ToString("HH:mm:ss");
            radioButton1.Checked = true;
            panel2.Location = panel1.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
