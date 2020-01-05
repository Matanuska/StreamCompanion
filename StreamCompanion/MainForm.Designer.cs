namespace StreamCompanion
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage tabCountdownZero;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1tabDateAndTime = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabChrono = new System.Windows.Forms.TabPage();
            this.tabCountdownToDate = new System.Windows.Forms.TabPage();
            this.tabScheduler = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimersPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpComPorts = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rtxtComConsole = new System.Windows.Forms.RichTextBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comPanel = new System.Windows.Forms.Panel();
            this.grpMqtt = new System.Windows.Forms.GroupBox();
            this.rtxtMqttConsole = new System.Windows.Forms.RichTextBox();
            this.chkMqttBroker = new System.Windows.Forms.CheckBox();
            this.btnTestLocalMqttBroker = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SettingstxtEmbeddedBrokerPort = new System.Windows.Forms.TextBox();
            this.SettingstxtEmbeddedBrokerUserName = new System.Windows.Forms.TextBox();
            this.SettingstxtEmbeddedBrokerUserPassword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SettingstxtExternalMqttBrokerName = new System.Windows.Forms.TextBox();
            this.SettingstxtExternalMqttBrokerPort = new System.Windows.Forms.TextBox();
            this.SettingstxtExternalMqttBrokerUserName = new System.Windows.Forms.TextBox();
            this.SettingstxtExternalMqttBrokerUserPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.advancedTextBox1 = new StreamCompanion.Controls.AdvancedTextBox();
            tabCountdownZero = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1tabDateAndTime.SuspendLayout();
            this.tabScheduler.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.TimersPanel.SuspendLayout();
            this.grpComPorts.SuspendLayout();
            this.comPanel.SuspendLayout();
            this.grpMqtt.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCountdownZero
            // 
            resources.ApplyResources(tabCountdownZero, "tabCountdownZero");
            tabCountdownZero.Name = "tabCountdownZero";
            tabCountdownZero.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1tabDateAndTime);
            this.tabControl1.Controls.Add(this.tabChrono);
            this.tabControl1.Controls.Add(tabCountdownZero);
            this.tabControl1.Controls.Add(this.tabCountdownToDate);
            this.tabControl1.Controls.Add(this.tabScheduler);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1tabDateAndTime
            // 
            this.tabPage1tabDateAndTime.Controls.Add(this.flowLayoutPanel1);
            resources.ApplyResources(this.tabPage1tabDateAndTime, "tabPage1tabDateAndTime");
            this.tabPage1tabDateAndTime.Name = "tabPage1tabDateAndTime";
            this.tabPage1tabDateAndTime.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // tabChrono
            // 
            resources.ApplyResources(this.tabChrono, "tabChrono");
            this.tabChrono.Name = "tabChrono";
            this.tabChrono.UseVisualStyleBackColor = true;
            // 
            // tabCountdownToDate
            // 
            resources.ApplyResources(this.tabCountdownToDate, "tabCountdownToDate");
            this.tabCountdownToDate.Name = "tabCountdownToDate";
            this.tabCountdownToDate.UseVisualStyleBackColor = true;
            // 
            // tabScheduler
            // 
            this.tabScheduler.Controls.Add(this.label1);
            resources.ApplyResources(this.tabScheduler, "tabScheduler");
            this.tabScheduler.Name = "tabScheduler";
            this.tabScheduler.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton1});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.ShowItemToolTips = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoToolTip = false;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.tabControl2);
            this.settingsPanel.Controls.Add(this.btnSaveSettings);
            resources.ApplyResources(this.settingsPanel, "settingsPanel");
            this.settingsPanel.Name = "settingsPanel";
            // 
            // btnSaveSettings
            // 
            resources.ApplyResources(this.btnSaveSettings, "btnSaveSettings");
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // TimersPanel
            // 
            this.TimersPanel.Controls.Add(this.tabControl1);
            resources.ApplyResources(this.TimersPanel, "TimersPanel");
            this.TimersPanel.Name = "TimersPanel";
            this.TimersPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TimersPanel_Paint);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            // 
            // grpComPorts
            // 
            this.grpComPorts.Controls.Add(this.label2);
            this.grpComPorts.Controls.Add(this.comboBox1);
            this.grpComPorts.Controls.Add(this.rtxtComConsole);
            this.grpComPorts.Controls.Add(this.propertyGrid1);
            this.grpComPorts.Controls.Add(this.checkedListBox1);
            resources.ApplyResources(this.grpComPorts, "grpComPorts");
            this.grpComPorts.Name = "grpComPorts";
            this.grpComPorts.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // rtxtComConsole
            // 
            this.rtxtComConsole.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtxtComConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.rtxtComConsole, "rtxtComConsole");
            this.rtxtComConsole.Name = "rtxtComConsole";
            this.rtxtComConsole.ReadOnly = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.propertyGrid1, "propertyGrid1");
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Click += new System.EventHandler(this.propertyGrid1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // comPanel
            // 
            this.comPanel.Controls.Add(this.grpMqtt);
            this.comPanel.Controls.Add(this.grpComPorts);
            resources.ApplyResources(this.comPanel, "comPanel");
            this.comPanel.Name = "comPanel";
            // 
            // grpMqtt
            // 
            this.grpMqtt.Controls.Add(this.rtxtMqttConsole);
            this.grpMqtt.Controls.Add(this.chkMqttBroker);
            this.grpMqtt.Controls.Add(this.btnTestLocalMqttBroker);
            resources.ApplyResources(this.grpMqtt, "grpMqtt");
            this.grpMqtt.Name = "grpMqtt";
            this.grpMqtt.TabStop = false;
            // 
            // rtxtMqttConsole
            // 
            resources.ApplyResources(this.rtxtMqttConsole, "rtxtMqttConsole");
            this.rtxtMqttConsole.Name = "rtxtMqttConsole";
            this.rtxtMqttConsole.ReadOnly = true;
            // 
            // chkMqttBroker
            // 
            resources.ApplyResources(this.chkMqttBroker, "chkMqttBroker");
            this.chkMqttBroker.Name = "chkMqttBroker";
            this.chkMqttBroker.UseVisualStyleBackColor = true;
            this.chkMqttBroker.CheckedChanged += new System.EventHandler(this.chkMqttBroker_CheckedChanged);
            // 
            // btnTestLocalMqttBroker
            // 
            resources.ApplyResources(this.btnTestLocalMqttBroker, "btnTestLocalMqttBroker");
            this.btnTestLocalMqttBroker.Name = "btnTestLocalMqttBroker";
            this.btnTestLocalMqttBroker.UseVisualStyleBackColor = true;
            this.btnTestLocalMqttBroker.Click += new System.EventHandler(this.btnTestLocalMqttBroker_Click);
            // 
            // tabControl2
            // 
            resources.ApplyResources(this.tabControl2, "tabControl2");
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.advancedTextBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SettingstxtEmbeddedBrokerUserPassword);
            this.groupBox1.Controls.Add(this.SettingstxtEmbeddedBrokerUserName);
            this.groupBox1.Controls.Add(this.SettingstxtEmbeddedBrokerPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // SettingstxtEmbeddedBrokerPort
            // 
            resources.ApplyResources(this.SettingstxtEmbeddedBrokerPort, "SettingstxtEmbeddedBrokerPort");
            this.SettingstxtEmbeddedBrokerPort.Name = "SettingstxtEmbeddedBrokerPort";
            this.SettingstxtEmbeddedBrokerPort.TextChanged += new System.EventHandler(this.SettingstxtEmbeddedBrokerPort_TextChanged);
            this.SettingstxtEmbeddedBrokerPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingstxtEmbeddedBrokerPort_KeyPress);
            // 
            // SettingstxtEmbeddedBrokerUserName
            // 
            resources.ApplyResources(this.SettingstxtEmbeddedBrokerUserName, "SettingstxtEmbeddedBrokerUserName");
            this.SettingstxtEmbeddedBrokerUserName.Name = "SettingstxtEmbeddedBrokerUserName";
            this.SettingstxtEmbeddedBrokerUserName.TextChanged += new System.EventHandler(this.SettingstxtEmbeddedBrokerUserName_TextChanged);
            // 
            // SettingstxtEmbeddedBrokerUserPassword
            // 
            resources.ApplyResources(this.SettingstxtEmbeddedBrokerUserPassword, "SettingstxtEmbeddedBrokerUserPassword");
            this.SettingstxtEmbeddedBrokerUserPassword.Name = "SettingstxtEmbeddedBrokerUserPassword";
            this.SettingstxtEmbeddedBrokerUserPassword.TextChanged += new System.EventHandler(this.SettingstxtEmbeddedBrokerUserPassword_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SettingstxtExternalMqttBrokerUserPassword);
            this.groupBox2.Controls.Add(this.SettingstxtExternalMqttBrokerUserName);
            this.groupBox2.Controls.Add(this.SettingstxtExternalMqttBrokerPort);
            this.groupBox2.Controls.Add(this.SettingstxtExternalMqttBrokerName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // SettingstxtExternalMqttBrokerName
            // 
            resources.ApplyResources(this.SettingstxtExternalMqttBrokerName, "SettingstxtExternalMqttBrokerName");
            this.SettingstxtExternalMqttBrokerName.Name = "SettingstxtExternalMqttBrokerName";
            this.SettingstxtExternalMqttBrokerName.TextChanged += new System.EventHandler(this.SettingstxtExternalMqttBrokerName_TextChanged);
            // 
            // SettingstxtExternalMqttBrokerPort
            // 
            resources.ApplyResources(this.SettingstxtExternalMqttBrokerPort, "SettingstxtExternalMqttBrokerPort");
            this.SettingstxtExternalMqttBrokerPort.Name = "SettingstxtExternalMqttBrokerPort";
            this.SettingstxtExternalMqttBrokerPort.TextChanged += new System.EventHandler(this.SettingstxtExternalMqttBrokerPort_TextChanged);
            this.SettingstxtExternalMqttBrokerPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingstxtExternalMqttBrokerPort_KeyPress);
            // 
            // SettingstxtExternalMqttBrokerUserName
            // 
            resources.ApplyResources(this.SettingstxtExternalMqttBrokerUserName, "SettingstxtExternalMqttBrokerUserName");
            this.SettingstxtExternalMqttBrokerUserName.Name = "SettingstxtExternalMqttBrokerUserName";
            this.SettingstxtExternalMqttBrokerUserName.TextChanged += new System.EventHandler(this.SettingstxtExternalMqttBrokerUserName_TextChanged);
            // 
            // SettingstxtExternalMqttBrokerUserPassword
            // 
            resources.ApplyResources(this.SettingstxtExternalMqttBrokerUserPassword, "SettingstxtExternalMqttBrokerUserPassword");
            this.SettingstxtExternalMqttBrokerUserPassword.Name = "SettingstxtExternalMqttBrokerUserPassword";
            this.SettingstxtExternalMqttBrokerUserPassword.TextChanged += new System.EventHandler(this.SettingstxtExternalMqttBrokerUserPassword_TextChanged);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // advancedTextBox1
            // 
            resources.ApplyResources(this.advancedTextBox1, "advancedTextBox1");
            this.advancedTextBox1.Name = "advancedTextBox1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comPanel);
            this.Controls.Add(this.TimersPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1tabDateAndTime.ResumeLayout(false);
            this.tabScheduler.ResumeLayout(false);
            this.tabScheduler.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TimersPanel.ResumeLayout(false);
            this.grpComPorts.ResumeLayout(false);
            this.grpComPorts.PerformLayout();
            this.comPanel.ResumeLayout(false);
            this.grpMqtt.ResumeLayout(false);
            this.grpMqtt.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1tabDateAndTime;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tabChrono;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabCountdownToDate;
       // private Controls.DateTimeUserControl dateTimeUserControl1;
        private System.Windows.Forms.Panel TimersPanel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel comPanel;
        private System.Windows.Forms.GroupBox grpComPorts;
        private System.Windows.Forms.RichTextBox rtxtComConsole;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TabPage tabScheduler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpMqtt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnTestLocalMqttBroker;
        private System.Windows.Forms.CheckBox chkMqttBroker;
        private System.Windows.Forms.RichTextBox rtxtMqttConsole;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SettingstxtEmbeddedBrokerPort;
        private System.Windows.Forms.TextBox SettingstxtEmbeddedBrokerUserName;
        private System.Windows.Forms.TextBox SettingstxtEmbeddedBrokerUserPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SettingstxtExternalMqttBrokerUserPassword;
        private System.Windows.Forms.TextBox SettingstxtExternalMqttBrokerUserName;
        private System.Windows.Forms.TextBox SettingstxtExternalMqttBrokerPort;
        private System.Windows.Forms.TextBox SettingstxtExternalMqttBrokerName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Controls.AdvancedTextBox advancedTextBox1;
    }
}