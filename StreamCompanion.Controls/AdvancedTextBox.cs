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
    public partial class AdvancedTextBox : UserControl
    {
        
        
        private string text;

        public string Text

        {

            get { return textBox.Text; }

            set { textBox.Text = value; }

        }

        TextBox textBox = new TextBox();

        public AdvancedTextBox()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(AdvancedTextBox_Paint);

            this.Resize += new EventHandler(AdvancedTextBox_Resize);

//            textBox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);   

            textBox.Multiline = false;            

            textBox.BorderStyle = BorderStyle.Fixed3D;

            this.Controls.Add(textBox);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {            
        }

        private void AdvancedTextBox_KeyPress(object sender, EventArgs e)
        {
            
        }

        private void AdvancedTextBox_Load(object sender, EventArgs e)
        {
            
        }

        private void AdvancedTextBox_Resize(object sender, EventArgs e)
        {
            textBox.Size = new Size(this.Width - 8, this.Height - 4);
            textBox.Location = new Point(4, 4);
        }

        private Color currentBorderColor = Color.Transparent;

        private void AdvancedTextBox_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, currentBorderColor, ButtonBorderStyle.Solid);
        }

        public void Highligth(Color? color)
        {
            if (color != null)
            {
                currentBorderColor = (Color)color;
            }
            else
            {
                currentBorderColor = Color.Transparent;
            }
            this.Refresh();
        }
    }
}
