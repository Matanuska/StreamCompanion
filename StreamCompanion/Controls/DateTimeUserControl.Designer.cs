namespace StreamCompanion.Controls
{
    partial class DateTimeUserControl
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
            this.lblTimeZone = new System.Windows.Forms.Label();
            this.cboTimezone = new System.Windows.Forms.ComboBox();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.grpFormat = new System.Windows.Forms.GroupBox();
            this.panelPredefinedOutput = new System.Windows.Forms.Panel();
            this.cboPredefinedFormats = new System.Windows.Forms.ComboBox();
            this.lblPredefinedDateFormat = new System.Windows.Forms.Label();
            this.panelPredefinedOutputCulture = new System.Windows.Forms.Panel();
            this.cboCulture = new System.Windows.Forms.ComboBox();
            this.lblCulture = new System.Windows.Forms.Label();
            this.panelOutputFormat = new System.Windows.Forms.Panel();
            this.radioBtnCustomOutputFormat = new System.Windows.Forms.RadioButton();
            this.radioBtnPrefedinedOutputFormat = new System.Windows.Forms.RadioButton();
            this.lblOutputFormat = new System.Windows.Forms.Label();
            this.panelCustomFormat = new System.Windows.Forms.Panel();
            this.txtCustomOutputFormat = new System.Windows.Forms.TextBox();
            this.lblCustomFormat = new System.Windows.Forms.Label();
            this.panelRadioButonFormat = new System.Windows.Forms.Panel();
            this.radioBtnDateAndTime = new System.Windows.Forms.RadioButton();
            this.radioBtnTime = new System.Windows.Forms.RadioButton();
            this.radioBtnDate = new System.Windows.Forms.RadioButton();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.chkOutputFile = new System.Windows.Forms.CheckBox();
            this.txtMQTTTopic = new System.Windows.Forms.TextBox();
            this.lblMQTTTopic = new System.Windows.Forms.Label();
            this.txtOutputMQTTSubscription = new System.Windows.Forms.TextBox();
            this.lblOutputMqttSubscription = new System.Windows.Forms.Label();
            this.lblOutputSample = new System.Windows.Forms.Label();
            this.txtOutputDataSerialPort = new System.Windows.Forms.TextBox();
            this.lblOutputDataSerialPort = new System.Windows.Forms.Label();
            this.chkListOutputSerialPort = new System.Windows.Forms.CheckedListBox();
            this.lblOutputSerialPort = new System.Windows.Forms.Label();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.grpRemoteControle = new System.Windows.Forms.GroupBox();
            this.txtRemoteControlMQTTTopic = new System.Windows.Forms.TextBox();
            this.lblRemoteControlMQTTTopic = new System.Windows.Forms.Label();
            this.txtRemoteControlMQTTSubscription = new System.Windows.Forms.TextBox();
            this.lblRemoteControlMQTTSubscription = new System.Windows.Forms.Label();
            this.txtRemoteControlSerialData = new System.Windows.Forms.TextBox();
            this.lblRemoteControlSerialData = new System.Windows.Forms.Label();
            this.chkCheckListBoxRemoteSerialPort = new System.Windows.Forms.CheckedListBox();
            this.lblRemoteControlSerialPort = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpFormat.SuspendLayout();
            this.panelPredefinedOutput.SuspendLayout();
            this.panelPredefinedOutputCulture.SuspendLayout();
            this.panelOutputFormat.SuspendLayout();
            this.panelCustomFormat.SuspendLayout();
            this.panelRadioButonFormat.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpRemoteControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimeZone
            // 
            this.lblTimeZone.AutoSize = true;
            this.lblTimeZone.Location = new System.Drawing.Point(5, 21);
            this.lblTimeZone.Name = "lblTimeZone";
            this.lblTimeZone.Size = new System.Drawing.Size(53, 13);
            this.lblTimeZone.TabIndex = 0;
            this.lblTimeZone.Text = "Timezone";
            // 
            // cboTimezone
            // 
            this.cboTimezone.DisplayMember = "DisplayName";
            this.cboTimezone.FormattingEnabled = true;
            this.cboTimezone.Location = new System.Drawing.Point(79, 21);
            this.cboTimezone.Name = "cboTimezone";
            this.cboTimezone.Size = new System.Drawing.Size(344, 21);
            this.cboTimezone.TabIndex = 1;
            this.cboTimezone.ValueMember = "Id";
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Location = new System.Drawing.Point(688, 23);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(65, 17);
            this.chkEnabled.TabIndex = 2;
            this.chkEnabled.Text = "Enabled";
            this.chkEnabled.UseVisualStyleBackColor = true;
            this.chkEnabled.CheckedChanged += new System.EventHandler(this.chkEnabled_CheckedChanged);
            // 
            // grpFormat
            // 
            this.grpFormat.Controls.Add(this.panelPredefinedOutput);
            this.grpFormat.Controls.Add(this.panelPredefinedOutputCulture);
            this.grpFormat.Controls.Add(this.panelOutputFormat);
            this.grpFormat.Controls.Add(this.panelCustomFormat);
            this.grpFormat.Controls.Add(this.panelRadioButonFormat);
            this.grpFormat.Location = new System.Drawing.Point(8, 48);
            this.grpFormat.Name = "grpFormat";
            this.grpFormat.Size = new System.Drawing.Size(324, 128);
            this.grpFormat.TabIndex = 3;
            this.grpFormat.TabStop = false;
            this.grpFormat.Text = "Format";
            // 
            // panelPredefinedOutput
            // 
            this.panelPredefinedOutput.Controls.Add(this.cboPredefinedFormats);
            this.panelPredefinedOutput.Controls.Add(this.lblPredefinedDateFormat);
            this.panelPredefinedOutput.Location = new System.Drawing.Point(6, 95);
            this.panelPredefinedOutput.Name = "panelPredefinedOutput";
            this.panelPredefinedOutput.Size = new System.Drawing.Size(309, 25);
            this.panelPredefinedOutput.TabIndex = 10;
            // 
            // cboPredefinedFormats
            // 
            this.cboPredefinedFormats.FormattingEnabled = true;
            this.cboPredefinedFormats.Location = new System.Drawing.Point(51, 1);
            this.cboPredefinedFormats.Name = "cboPredefinedFormats";
            this.cboPredefinedFormats.Size = new System.Drawing.Size(250, 21);
            this.cboPredefinedFormats.TabIndex = 1;
            // 
            // lblPredefinedDateFormat
            // 
            this.lblPredefinedDateFormat.AutoSize = true;
            this.lblPredefinedDateFormat.Location = new System.Drawing.Point(3, 5);
            this.lblPredefinedDateFormat.Name = "lblPredefinedDateFormat";
            this.lblPredefinedDateFormat.Size = new System.Drawing.Size(39, 13);
            this.lblPredefinedDateFormat.TabIndex = 0;
            this.lblPredefinedDateFormat.Text = "Format";
            // 
            // panelPredefinedOutputCulture
            // 
            this.panelPredefinedOutputCulture.Controls.Add(this.cboCulture);
            this.panelPredefinedOutputCulture.Controls.Add(this.lblCulture);
            this.panelPredefinedOutputCulture.Location = new System.Drawing.Point(6, 64);
            this.panelPredefinedOutputCulture.Name = "panelPredefinedOutputCulture";
            this.panelPredefinedOutputCulture.Size = new System.Drawing.Size(309, 25);
            this.panelPredefinedOutputCulture.TabIndex = 2;
            // 
            // cboCulture
            // 
            this.cboCulture.DisplayMember = "DisplayName";
            this.cboCulture.FormattingEnabled = true;
            this.cboCulture.Location = new System.Drawing.Point(51, 2);
            this.cboCulture.Name = "cboCulture";
            this.cboCulture.Size = new System.Drawing.Size(250, 21);
            this.cboCulture.TabIndex = 1;
            this.cboCulture.ValueMember = "Name";
            this.cboCulture.SelectedIndexChanged += new System.EventHandler(this.cboCulture_SelectedIndexChanged);
            // 
            // lblCulture
            // 
            this.lblCulture.AutoSize = true;
            this.lblCulture.Location = new System.Drawing.Point(4, 6);
            this.lblCulture.Name = "lblCulture";
            this.lblCulture.Size = new System.Drawing.Size(40, 13);
            this.lblCulture.TabIndex = 0;
            this.lblCulture.Text = "Culture";
            // 
            // panelOutputFormat
            // 
            this.panelOutputFormat.Controls.Add(this.radioBtnCustomOutputFormat);
            this.panelOutputFormat.Controls.Add(this.radioBtnPrefedinedOutputFormat);
            this.panelOutputFormat.Controls.Add(this.lblOutputFormat);
            this.panelOutputFormat.Location = new System.Drawing.Point(6, 43);
            this.panelOutputFormat.Name = "panelOutputFormat";
            this.panelOutputFormat.Size = new System.Drawing.Size(200, 16);
            this.panelOutputFormat.TabIndex = 1;
            // 
            // radioBtnCustomOutputFormat
            // 
            this.radioBtnCustomOutputFormat.AutoSize = true;
            this.radioBtnCustomOutputFormat.Location = new System.Drawing.Point(131, -1);
            this.radioBtnCustomOutputFormat.Name = "radioBtnCustomOutputFormat";
            this.radioBtnCustomOutputFormat.Size = new System.Drawing.Size(60, 17);
            this.radioBtnCustomOutputFormat.TabIndex = 2;
            this.radioBtnCustomOutputFormat.TabStop = true;
            this.radioBtnCustomOutputFormat.Text = "Custom";
            this.radioBtnCustomOutputFormat.UseVisualStyleBackColor = true;
            this.radioBtnCustomOutputFormat.CheckedChanged += new System.EventHandler(this.radioBtnCustomOutputFormat_CheckedChanged);
            // 
            // radioBtnPrefedinedOutputFormat
            // 
            this.radioBtnPrefedinedOutputFormat.AutoSize = true;
            this.radioBtnPrefedinedOutputFormat.Location = new System.Drawing.Point(49, -1);
            this.radioBtnPrefedinedOutputFormat.Name = "radioBtnPrefedinedOutputFormat";
            this.radioBtnPrefedinedOutputFormat.Size = new System.Drawing.Size(76, 17);
            this.radioBtnPrefedinedOutputFormat.TabIndex = 1;
            this.radioBtnPrefedinedOutputFormat.TabStop = true;
            this.radioBtnPrefedinedOutputFormat.Text = "Predefined";
            this.radioBtnPrefedinedOutputFormat.UseVisualStyleBackColor = true;
            this.radioBtnPrefedinedOutputFormat.CheckedChanged += new System.EventHandler(this.radioBtnPrefedinedOutputFormat_CheckedChanged);
            // 
            // lblOutputFormat
            // 
            this.lblOutputFormat.AutoSize = true;
            this.lblOutputFormat.Location = new System.Drawing.Point(4, -1);
            this.lblOutputFormat.Name = "lblOutputFormat";
            this.lblOutputFormat.Size = new System.Drawing.Size(39, 13);
            this.lblOutputFormat.TabIndex = 0;
            this.lblOutputFormat.Text = "Output";
            // 
            // panelCustomFormat
            // 
            this.panelCustomFormat.Controls.Add(this.txtCustomOutputFormat);
            this.panelCustomFormat.Controls.Add(this.lblCustomFormat);
            this.panelCustomFormat.Location = new System.Drawing.Point(212, 42);
            this.panelCustomFormat.Name = "panelCustomFormat";
            this.panelCustomFormat.Size = new System.Drawing.Size(309, 25);
            this.panelCustomFormat.TabIndex = 3;
            // 
            // txtCustomOutputFormat
            // 
            this.txtCustomOutputFormat.Location = new System.Drawing.Point(83, 2);
            this.txtCustomOutputFormat.Name = "txtCustomOutputFormat";
            this.txtCustomOutputFormat.Size = new System.Drawing.Size(215, 20);
            this.txtCustomOutputFormat.TabIndex = 1;
            this.txtCustomOutputFormat.TextChanged += new System.EventHandler(this.txtCustomOutputFormat_TextChanged);
            // 
            // lblCustomFormat
            // 
            this.lblCustomFormat.AutoSize = true;
            this.lblCustomFormat.Location = new System.Drawing.Point(3, 5);
            this.lblCustomFormat.Name = "lblCustomFormat";
            this.lblCustomFormat.Size = new System.Drawing.Size(74, 13);
            this.lblCustomFormat.TabIndex = 0;
            this.lblCustomFormat.Text = "Custom format";
            // 
            // panelRadioButonFormat
            // 
            this.panelRadioButonFormat.Controls.Add(this.radioBtnDateAndTime);
            this.panelRadioButonFormat.Controls.Add(this.radioBtnTime);
            this.panelRadioButonFormat.Controls.Add(this.radioBtnDate);
            this.panelRadioButonFormat.Location = new System.Drawing.Point(6, 19);
            this.panelRadioButonFormat.Name = "panelRadioButonFormat";
            this.panelRadioButonFormat.Size = new System.Drawing.Size(230, 21);
            this.panelRadioButonFormat.TabIndex = 0;
            // 
            // radioBtnDateAndTime
            // 
            this.radioBtnDateAndTime.AutoSize = true;
            this.radioBtnDateAndTime.Location = new System.Drawing.Point(152, 0);
            this.radioBtnDateAndTime.Name = "radioBtnDateAndTime";
            this.radioBtnDateAndTime.Size = new System.Drawing.Size(74, 17);
            this.radioBtnDateAndTime.TabIndex = 2;
            this.radioBtnDateAndTime.TabStop = true;
            this.radioBtnDateAndTime.Text = "Date Time";
            this.radioBtnDateAndTime.UseVisualStyleBackColor = true;
            // 
            // radioBtnTime
            // 
            this.radioBtnTime.AutoSize = true;
            this.radioBtnTime.Location = new System.Drawing.Point(78, 0);
            this.radioBtnTime.Name = "radioBtnTime";
            this.radioBtnTime.Size = new System.Drawing.Size(48, 17);
            this.radioBtnTime.TabIndex = 1;
            this.radioBtnTime.TabStop = true;
            this.radioBtnTime.Text = "Time";
            this.radioBtnTime.UseVisualStyleBackColor = true;
            this.radioBtnTime.CheckedChanged += new System.EventHandler(this.radioBtnTime_CheckedChanged);
            // 
            // radioBtnDate
            // 
            this.radioBtnDate.AutoSize = true;
            this.radioBtnDate.Location = new System.Drawing.Point(4, 0);
            this.radioBtnDate.Name = "radioBtnDate";
            this.radioBtnDate.Size = new System.Drawing.Size(48, 17);
            this.radioBtnDate.TabIndex = 0;
            this.radioBtnDate.TabStop = true;
            this.radioBtnDate.Text = "Date";
            this.radioBtnDate.UseVisualStyleBackColor = true;
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(3, 2);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(750, 2);
            this.lblSeparator.TabIndex = 4;
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.chkOutputFile);
            this.grpOutput.Controls.Add(this.txtMQTTTopic);
            this.grpOutput.Controls.Add(this.lblMQTTTopic);
            this.grpOutput.Controls.Add(this.txtOutputMQTTSubscription);
            this.grpOutput.Controls.Add(this.lblOutputMqttSubscription);
            this.grpOutput.Controls.Add(this.lblOutputSample);
            this.grpOutput.Controls.Add(this.txtOutputDataSerialPort);
            this.grpOutput.Controls.Add(this.lblOutputDataSerialPort);
            this.grpOutput.Controls.Add(this.chkListOutputSerialPort);
            this.grpOutput.Controls.Add(this.lblOutputSerialPort);
            this.grpOutput.Controls.Add(this.btnOpenFileDialog);
            this.grpOutput.Controls.Add(this.txtOutputFile);
            this.grpOutput.Location = new System.Drawing.Point(8, 182);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(745, 135);
            this.grpOutput.TabIndex = 5;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Outputs";
            // 
            // chkOutputFile
            // 
            this.chkOutputFile.AutoSize = true;
            this.chkOutputFile.Location = new System.Drawing.Point(16, 22);
            this.chkOutputFile.Name = "chkOutputFile";
            this.chkOutputFile.Size = new System.Drawing.Size(42, 17);
            this.chkOutputFile.TabIndex = 14;
            this.chkOutputFile.Text = "File";
            this.chkOutputFile.UseVisualStyleBackColor = true;
            // 
            // txtMQTTTopic
            // 
            this.txtMQTTTopic.Location = new System.Drawing.Point(420, 99);
            this.txtMQTTTopic.Name = "txtMQTTTopic";
            this.txtMQTTTopic.Size = new System.Drawing.Size(100, 20);
            this.txtMQTTTopic.TabIndex = 13;
            // 
            // lblMQTTTopic
            // 
            this.lblMQTTTopic.AutoSize = true;
            this.lblMQTTTopic.Location = new System.Drawing.Point(330, 103);
            this.lblMQTTTopic.Name = "lblMQTTTopic";
            this.lblMQTTTopic.Size = new System.Drawing.Size(68, 13);
            this.lblMQTTTopic.TabIndex = 12;
            this.lblMQTTTopic.Text = "MQTT Topic";
            // 
            // txtOutputMQTTSubscription
            // 
            this.txtOutputMQTTSubscription.Location = new System.Drawing.Point(119, 99);
            this.txtOutputMQTTSubscription.Name = "txtOutputMQTTSubscription";
            this.txtOutputMQTTSubscription.Size = new System.Drawing.Size(196, 20);
            this.txtOutputMQTTSubscription.TabIndex = 11;
            // 
            // lblOutputMqttSubscription
            // 
            this.lblOutputMqttSubscription.AutoSize = true;
            this.lblOutputMqttSubscription.Location = new System.Drawing.Point(13, 103);
            this.lblOutputMqttSubscription.Name = "lblOutputMqttSubscription";
            this.lblOutputMqttSubscription.Size = new System.Drawing.Size(99, 13);
            this.lblOutputMqttSubscription.TabIndex = 10;
            this.lblOutputMqttSubscription.Text = "MQTT Subscription";
            // 
            // lblOutputSample
            // 
            this.lblOutputSample.Location = new System.Drawing.Point(474, 62);
            this.lblOutputSample.Name = "lblOutputSample";
            this.lblOutputSample.Size = new System.Drawing.Size(264, 13);
            this.lblOutputSample.TabIndex = 8;
            // 
            // txtOutputDataSerialPort
            // 
            this.txtOutputDataSerialPort.Location = new System.Drawing.Point(356, 58);
            this.txtOutputDataSerialPort.Name = "txtOutputDataSerialPort";
            this.txtOutputDataSerialPort.Size = new System.Drawing.Size(100, 20);
            this.txtOutputDataSerialPort.TabIndex = 6;
            // 
            // lblOutputDataSerialPort
            // 
            this.lblOutputDataSerialPort.AutoSize = true;
            this.lblOutputDataSerialPort.Location = new System.Drawing.Point(319, 62);
            this.lblOutputDataSerialPort.Name = "lblOutputDataSerialPort";
            this.lblOutputDataSerialPort.Size = new System.Drawing.Size(30, 13);
            this.lblOutputDataSerialPort.TabIndex = 5;
            this.lblOutputDataSerialPort.Text = "Data";
            // 
            // chkListOutputSerialPort
            // 
            this.chkListOutputSerialPort.CheckOnClick = true;
            this.chkListOutputSerialPort.FormattingEnabled = true;
            this.chkListOutputSerialPort.Location = new System.Drawing.Point(81, 51);
            this.chkListOutputSerialPort.Name = "chkListOutputSerialPort";
            this.chkListOutputSerialPort.ScrollAlwaysVisible = true;
            this.chkListOutputSerialPort.Size = new System.Drawing.Size(234, 34);
            this.chkListOutputSerialPort.Sorted = true;
            this.chkListOutputSerialPort.TabIndex = 4;
            // 
            // lblOutputSerialPort
            // 
            this.lblOutputSerialPort.AutoSize = true;
            this.lblOutputSerialPort.Location = new System.Drawing.Point(10, 62);
            this.lblOutputSerialPort.Name = "lblOutputSerialPort";
            this.lblOutputSerialPort.Size = new System.Drawing.Size(54, 13);
            this.lblOutputSerialPort.TabIndex = 3;
            this.lblOutputSerialPort.Text = "Serial port";
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(711, 19);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(27, 23);
            this.btnOpenFileDialog.TabIndex = 2;
            this.btnOpenFileDialog.Text = "...";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(64, 20);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(641, 20);
            this.txtOutputFile.TabIndex = 1;
            // 
            // grpRemoteControle
            // 
            this.grpRemoteControle.Controls.Add(this.txtRemoteControlMQTTTopic);
            this.grpRemoteControle.Controls.Add(this.lblRemoteControlMQTTTopic);
            this.grpRemoteControle.Controls.Add(this.txtRemoteControlMQTTSubscription);
            this.grpRemoteControle.Controls.Add(this.lblRemoteControlMQTTSubscription);
            this.grpRemoteControle.Controls.Add(this.txtRemoteControlSerialData);
            this.grpRemoteControle.Controls.Add(this.lblRemoteControlSerialData);
            this.grpRemoteControle.Controls.Add(this.chkCheckListBoxRemoteSerialPort);
            this.grpRemoteControle.Controls.Add(this.lblRemoteControlSerialPort);
            this.grpRemoteControle.Location = new System.Drawing.Point(341, 48);
            this.grpRemoteControle.Name = "grpRemoteControle";
            this.grpRemoteControle.Size = new System.Drawing.Size(412, 128);
            this.grpRemoteControle.TabIndex = 6;
            this.grpRemoteControle.TabStop = false;
            this.grpRemoteControle.Text = "Remote control on";
            // 
            // txtRemoteControlMQTTTopic
            // 
            this.txtRemoteControlMQTTTopic.Location = new System.Drawing.Point(308, 67);
            this.txtRemoteControlMQTTTopic.Name = "txtRemoteControlMQTTTopic";
            this.txtRemoteControlMQTTTopic.Size = new System.Drawing.Size(97, 20);
            this.txtRemoteControlMQTTTopic.TabIndex = 7;
            // 
            // lblRemoteControlMQTTTopic
            // 
            this.lblRemoteControlMQTTTopic.AutoSize = true;
            this.lblRemoteControlMQTTTopic.Location = new System.Drawing.Point(268, 71);
            this.lblRemoteControlMQTTTopic.Name = "lblRemoteControlMQTTTopic";
            this.lblRemoteControlMQTTTopic.Size = new System.Drawing.Size(34, 13);
            this.lblRemoteControlMQTTTopic.TabIndex = 6;
            this.lblRemoteControlMQTTTopic.Text = "Topic";
            // 
            // txtRemoteControlMQTTSubscription
            // 
            this.txtRemoteControlMQTTSubscription.Location = new System.Drawing.Point(118, 67);
            this.txtRemoteControlMQTTSubscription.Name = "txtRemoteControlMQTTSubscription";
            this.txtRemoteControlMQTTSubscription.Size = new System.Drawing.Size(137, 20);
            this.txtRemoteControlMQTTSubscription.TabIndex = 5;
            // 
            // lblRemoteControlMQTTSubscription
            // 
            this.lblRemoteControlMQTTSubscription.AutoSize = true;
            this.lblRemoteControlMQTTSubscription.Location = new System.Drawing.Point(15, 71);
            this.lblRemoteControlMQTTSubscription.Name = "lblRemoteControlMQTTSubscription";
            this.lblRemoteControlMQTTSubscription.Size = new System.Drawing.Size(97, 13);
            this.lblRemoteControlMQTTSubscription.TabIndex = 4;
            this.lblRemoteControlMQTTSubscription.Text = "MQTT subscription";
            // 
            // txtRemoteControlSerialData
            // 
            this.txtRemoteControlSerialData.Location = new System.Drawing.Point(311, 26);
            this.txtRemoteControlSerialData.Name = "txtRemoteControlSerialData";
            this.txtRemoteControlSerialData.Size = new System.Drawing.Size(95, 20);
            this.txtRemoteControlSerialData.TabIndex = 3;
            this.txtRemoteControlSerialData.Text = "OnOff";
            // 
            // lblRemoteControlSerialData
            // 
            this.lblRemoteControlSerialData.AutoSize = true;
            this.lblRemoteControlSerialData.Location = new System.Drawing.Point(268, 29);
            this.lblRemoteControlSerialData.Name = "lblRemoteControlSerialData";
            this.lblRemoteControlSerialData.Size = new System.Drawing.Size(30, 13);
            this.lblRemoteControlSerialData.TabIndex = 2;
            this.lblRemoteControlSerialData.Text = "Data";
            // 
            // chkCheckListBoxRemoteSerialPort
            // 
            this.chkCheckListBoxRemoteSerialPort.FormattingEnabled = true;
            this.chkCheckListBoxRemoteSerialPort.Location = new System.Drawing.Point(81, 18);
            this.chkCheckListBoxRemoteSerialPort.Name = "chkCheckListBoxRemoteSerialPort";
            this.chkCheckListBoxRemoteSerialPort.ScrollAlwaysVisible = true;
            this.chkCheckListBoxRemoteSerialPort.Size = new System.Drawing.Size(181, 34);
            this.chkCheckListBoxRemoteSerialPort.Sorted = true;
            this.chkCheckListBoxRemoteSerialPort.TabIndex = 1;
            this.chkCheckListBoxRemoteSerialPort.SelectedIndexChanged += new System.EventHandler(this.ckcCheckListBoxRemoteSerialPort_SelectedIndexChanged);
            // 
            // lblRemoteControlSerialPort
            // 
            this.lblRemoteControlSerialPort.AutoSize = true;
            this.lblRemoteControlSerialPort.Location = new System.Drawing.Point(15, 29);
            this.lblRemoteControlSerialPort.Name = "lblRemoteControlSerialPort";
            this.lblRemoteControlSerialPort.Size = new System.Drawing.Size(54, 13);
            this.lblRemoteControlSerialPort.TabIndex = 0;
            this.lblRemoteControlSerialPort.Text = "Serial port";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(681, 324);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(28, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(718, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text file|*.txt";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(538, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "SCfile.txt";
            this.saveFileDialog1.Filter = "Text file|*.txt";
            // 
            // DateTimeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.grpRemoteControle);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.grpFormat);
            this.Controls.Add(this.chkEnabled);
            this.Controls.Add(this.cboTimezone);
            this.Controls.Add(this.lblTimeZone);
            this.Name = "DateTimeUserControl";
            this.Size = new System.Drawing.Size(760, 355);
            this.Load += new System.EventHandler(this.DateTimeUserControl_Load);
            this.grpFormat.ResumeLayout(false);
            this.panelPredefinedOutput.ResumeLayout(false);
            this.panelPredefinedOutput.PerformLayout();
            this.panelPredefinedOutputCulture.ResumeLayout(false);
            this.panelPredefinedOutputCulture.PerformLayout();
            this.panelOutputFormat.ResumeLayout(false);
            this.panelOutputFormat.PerformLayout();
            this.panelCustomFormat.ResumeLayout(false);
            this.panelCustomFormat.PerformLayout();
            this.panelRadioButonFormat.ResumeLayout(false);
            this.panelRadioButonFormat.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpRemoteControle.ResumeLayout(false);
            this.grpRemoteControle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeZone;
        private System.Windows.Forms.ComboBox cboTimezone;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.GroupBox grpFormat;
        private System.Windows.Forms.Panel panelCustomFormat;
        private System.Windows.Forms.TextBox txtCustomOutputFormat;
        private System.Windows.Forms.Label lblCustomFormat;
        private System.Windows.Forms.Panel panelPredefinedOutputCulture;
        private System.Windows.Forms.ComboBox cboCulture;
        private System.Windows.Forms.Label lblCulture;
        private System.Windows.Forms.Panel panelOutputFormat;
        private System.Windows.Forms.RadioButton radioBtnCustomOutputFormat;
        private System.Windows.Forms.RadioButton radioBtnPrefedinedOutputFormat;
        private System.Windows.Forms.Label lblOutputFormat;
        private System.Windows.Forms.Panel panelRadioButonFormat;
        private System.Windows.Forms.RadioButton radioBtnDateAndTime;
        private System.Windows.Forms.RadioButton radioBtnTime;
        private System.Windows.Forms.RadioButton radioBtnDate;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.CheckedListBox chkListOutputSerialPort;
        private System.Windows.Forms.Label lblOutputSerialPort;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.TextBox txtMQTTTopic;
        private System.Windows.Forms.Label lblMQTTTopic;
        private System.Windows.Forms.TextBox txtOutputMQTTSubscription;
        private System.Windows.Forms.Label lblOutputMqttSubscription;
        private System.Windows.Forms.Label lblOutputSample;
        private System.Windows.Forms.TextBox txtOutputDataSerialPort;
        private System.Windows.Forms.Label lblOutputDataSerialPort;
        private System.Windows.Forms.GroupBox grpRemoteControle;
        private System.Windows.Forms.TextBox txtRemoteControlMQTTTopic;
        private System.Windows.Forms.Label lblRemoteControlMQTTTopic;
        private System.Windows.Forms.TextBox txtRemoteControlMQTTSubscription;
        private System.Windows.Forms.Label lblRemoteControlMQTTSubscription;
        private System.Windows.Forms.TextBox txtRemoteControlSerialData;
        private System.Windows.Forms.Label lblRemoteControlSerialData;
        private System.Windows.Forms.CheckedListBox chkCheckListBoxRemoteSerialPort;
        private System.Windows.Forms.Label lblRemoteControlSerialPort;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelPredefinedOutput;
        private System.Windows.Forms.ComboBox cboPredefinedFormats;
        private System.Windows.Forms.Label lblPredefinedDateFormat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox chkOutputFile;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
