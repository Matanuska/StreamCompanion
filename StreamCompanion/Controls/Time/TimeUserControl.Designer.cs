namespace StreamCompanion.Controls
{
    partial class TimeUserControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblOutputResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textOutputFile = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstTimeFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDisplayFormat = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lstTimezones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.lblOutputResult);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textOutputFile);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lblDisplayFormat);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.lstTimezones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(691, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(691, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(523, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 20);
            this.textBox3.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Output file :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "MQTT Topic :";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(523, 57);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(162, 21);
            this.comboBox3.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Serial shortkey :";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(523, 28);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Clear output file";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(438, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Enabled";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblOutputResult
            // 
            this.lblOutputResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputResult.Location = new System.Drawing.Point(94, 129);
            this.lblOutputResult.Name = "lblOutputResult";
            this.lblOutputResult.Size = new System.Drawing.Size(170, 23);
            this.lblOutputResult.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Output result :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(9, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 40);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(289, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "%HHh %mmm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Custom format :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(686, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textOutputFile
            // 
            this.textOutputFile.Location = new System.Drawing.Point(337, 130);
            this.textOutputFile.Name = "textOutputFile";
            this.textOutputFile.Size = new System.Drawing.Size(343, 20);
            this.textOutputFile.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstTimeFormat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 40);
            this.panel1.TabIndex = 7;
            // 
            // lstTimeFormat
            // 
            this.lstTimeFormat.FormattingEnabled = true;
            this.lstTimeFormat.Items.AddRange(new object[] {
            "HH:mm:ss",
            "HH:mm:s",
            "HH:mm",
            "HH:m:ss",
            "HH:m:s",
            "HH:m",
            "HH:ss",
            "HH:s",
            "HH",
            "H:mm:ss",
            "H:mm:s",
            "H:mm",
            "H:m:ss",
            "H:m:s",
            "H:m",
            "H:ss",
            "H:s",
            "hh:mm:ss tt",
            "hh:mm:ss t",
            "hh:mm:ss",
            "hh:mm:s tt",
            "hh:mm:s t",
            "hh:mm:s",
            "hh:mm tt",
            "hh:mm t",
            "hh:mm",
            "hh:m:ss tt",
            "hh:m:ss t",
            "hh:m:ss",
            "hh:m:s tt",
            "hh:m:s t",
            "hh:m:s",
            "hh:m tt",
            "hh:m t",
            "hh:m",
            "hh:ss tt",
            "hh:ss t",
            "hh:ss",
            "hh:s tt",
            "hh:s t",
            "hh:s",
            "hh tt",
            "hh t",
            "hh",
            "h:mm:ss tt",
            "h:mm:ss t",
            "h:mm:ss",
            "h:mm:s tt",
            "h:mm:s t",
            "h:mm:s",
            "h:mm tt",
            "h:mm t",
            "h:mm",
            "h:m:ss tt",
            "h:m:ss t",
            "h:m:ss",
            "h:m:s tt",
            "h:m:s t",
            "h:m:s",
            "h:m tt",
            "h:m t",
            "h:m",
            "h:ss tt",
            "h:ss t",
            "h:ss",
            "h:s tt",
            "h:s t",
            "h:s",
            "h tt",
            "h t",
            "mm:ss tt",
            "mm:ss t",
            "mm:ss",
            "mm:s tt",
            "mm:s t",
            "mm:s",
            "mm tt",
            "mm t",
            "mm",
            "m:ss tt",
            "m:ss t",
            "m:ss",
            "m:s tt",
            "m:s t",
            "m:s",
            "m tt",
            "m t",
            "ss tt",
            "ss t",
            "ss",
            "s tt",
            "s t"});
            this.lstTimeFormat.Location = new System.Drawing.Point(74, 5);
            this.lstTimeFormat.Name = "lstTimeFormat";
            this.lstTimeFormat.Size = new System.Drawing.Size(307, 21);
            this.lstTimeFormat.TabIndex = 5;
            this.lstTimeFormat.SelectedIndexChanged += new System.EventHandler(this.lstTimeFormat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time format :";
            // 
            // lblDisplayFormat
            // 
            this.lblDisplayFormat.AutoSize = true;
            this.lblDisplayFormat.Location = new System.Drawing.Point(6, 57);
            this.lblDisplayFormat.Name = "lblDisplayFormat";
            this.lblDisplayFormat.Size = new System.Drawing.Size(79, 13);
            this.lblDisplayFormat.TabIndex = 6;
            this.lblDisplayFormat.Text = "Display format :";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(169, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Custom";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(87, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Predefined";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lstTimezones
            // 
            this.lstTimezones.FormattingEnabled = true;
            this.lstTimezones.Location = new System.Drawing.Point(64, 24);
            this.lstTimezones.Name = "lstTimezones";
            this.lstTimezones.Size = new System.Drawing.Size(326, 21);
            this.lstTimezones.TabIndex = 2;
            this.lstTimezones.SelectedIndexChanged += new System.EventHandler(this.lstTimezones_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TimeZone :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TimeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "TimeUserControl";
            this.Size = new System.Drawing.Size(725, 177);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblOutputResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textOutputFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox lstTimeFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisplayFormat;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox lstTimezones;
        private System.Windows.Forms.Label label1;
    }
}
