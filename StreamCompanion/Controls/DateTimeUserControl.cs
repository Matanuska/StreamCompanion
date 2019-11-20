using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamCompanion.Controls
{
    public partial class DateTimeUserControl : UserControl
    {
        public DateTimeUserControl()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            panelCustomFormat.Location = panelPredefinedOutputFormat.Location;
            radioBtnPrefedinedOutputFormat.Checked = true;
        }

        private void txtCustomOutputFormat_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimeUserControl_Load(object sender, EventArgs e)
        {

        }

        private void lblRemoteControlSerialData_Click(object sender, EventArgs e)
        {

        }

        private void radioBtnPrefedinedOutputFormat_CheckedChanged(object sender, EventArgs e)
        {
            panelPredefinedOutputFormat.Visible = true;
            panelCustomFormat.Visible = false;
        }

        private void radioBtnCustomOutputFormat_CheckedChanged(object sender, EventArgs e)
        {
            panelPredefinedOutputFormat.Visible = false;
            panelCustomFormat.Visible = true;
        }
    }
}
