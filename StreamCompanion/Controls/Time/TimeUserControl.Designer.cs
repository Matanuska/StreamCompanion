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
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.lblMqttTopic = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.OutputResult = new System.Windows.Forms.Label();
            this.lblOutputResult = new System.Windows.Forms.Label();
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
            this.lblTimezone = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.lblOutputFile);
            this.groupBox1.Controls.Add(this.lblMqttTopic);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.lblSerialPort);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.OutputResult);
            this.groupBox1.Controls.Add(this.lblOutputResult);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textOutputFile);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lblDisplayFormat);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.lstTimezones);
            this.groupBox1.Controls.Add(this.lblTimezone);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(674, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(674, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(506, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 20);
            this.textBox3.TabIndex = 19;
            // 
            // lblOutputFile
            // 
            this.lblOutputFile.AutoSize = true;
            this.lblOutputFile.Location = new System.Drawing.Point(223, 134);
            this.lblOutputFile.Name = "lblOutputFile";
            this.lblOutputFile.Size = new System.Drawing.Size(61, 13);
            this.lblOutputFile.TabIndex = 9;
            this.lblOutputFile.Text = "Output file :";
            // 
            // lblMqttTopic
            // 
            this.lblMqttTopic.AutoSize = true;
            this.lblMqttTopic.Location = new System.Drawing.Point(418, 92);
            this.lblMqttTopic.Name = "lblMqttTopic";
            this.lblMqttTopic.Size = new System.Drawing.Size(74, 13);
            this.lblMqttTopic.TabIndex = 18;
            this.lblMqttTopic.Text = "MQTT Topic :";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(506, 58);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(162, 21);
            this.comboBox3.TabIndex = 17;
            // 
            // lblSerialPort
            // 
            this.lblSerialPort.AutoSize = true;
            this.lblSerialPort.Location = new System.Drawing.Point(418, 60);
            this.lblSerialPort.Name = "lblSerialPort";
            this.lblSerialPort.Size = new System.Drawing.Size(60, 13);
            this.lblSerialPort.TabIndex = 16;
            this.lblSerialPort.Text = "Serial port :";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(506, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Clear output file";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(421, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Enabled";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // OutputResult
            // 
            this.OutputResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputResult.Location = new System.Drawing.Point(94, 129);
            this.OutputResult.Name = "OutputResult";
            this.OutputResult.Size = new System.Drawing.Size(109, 23);
            this.OutputResult.TabIndex = 13;
            // 
            // lblOutputResult
            // 
            this.lblOutputResult.AutoSize = true;
            this.lblOutputResult.Location = new System.Drawing.Point(6, 134);
            this.lblOutputResult.Name = "lblOutputResult";
            this.lblOutputResult.Size = new System.Drawing.Size(73, 13);
            this.lblOutputResult.TabIndex = 12;
            this.lblOutputResult.Text = "Output result :";
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
            this.button1.Location = new System.Drawing.Point(674, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textOutputFile
            // 
            this.textOutputFile.Location = new System.Drawing.Point(290, 130);
            this.textOutputFile.Name = "textOutputFile";
            this.textOutputFile.Size = new System.Drawing.Size(378, 20);
            this.textOutputFile.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstTimeFormat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 40);
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
            this.lstTimeFormat.Size = new System.Drawing.Size(149, 21);
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
            this.lstTimezones.SelectedIndexChanged += new System.EventHandler(this.lstTimezones_SelectedIndexChanged);
            // 
            // lblTimezone
            // 
            this.lblTimezone.AutoSize = true;
            this.lblTimezone.Location = new System.Drawing.Point(6, 27);
            this.lblTimezone.Name = "lblTimezone";
            this.lblTimezone.Size = new System.Drawing.Size(59, 13);
            this.lblTimezone.TabIndex = 0;
            this.lblTimezone.Text = "Timezone :";
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
        private System.Windows.Forms.Label lblOutputFile;
        private System.Windows.Forms.Label lblMqttTopic;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblSerialPort;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label OutputResult;
        private System.Windows.Forms.Label lblOutputResult;
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
        private System.Windows.Forms.Label lblTimezone;
    }
}
