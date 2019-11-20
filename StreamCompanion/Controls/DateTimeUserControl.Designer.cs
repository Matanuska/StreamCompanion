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
            this.lblTimeZone = new System.Windows.Forms.Label();
            this.cboTimezone = new System.Windows.Forms.ComboBox();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.grpFormat = new System.Windows.Forms.GroupBox();
            this.panelRadioButonFormat = new System.Windows.Forms.Panel();
            this.radioBtnDate = new System.Windows.Forms.RadioButton();
            this.radioBtnTime = new System.Windows.Forms.RadioButton();
            this.radioBtnDateAndTime = new System.Windows.Forms.RadioButton();
            this.panelOutputFormat = new System.Windows.Forms.Panel();
            this.lblOutputFormat = new System.Windows.Forms.Label();
            this.radioBtnPrefedinedOutputFormat = new System.Windows.Forms.RadioButton();
            this.radioBtnCustomOutputFormat = new System.Windows.Forms.RadioButton();
            this.panelPredefinedOutputFormat = new System.Windows.Forms.Panel();
            this.lblCulture = new System.Windows.Forms.Label();
            this.cboCulture = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCustomFormat = new System.Windows.Forms.Label();
            this.txtCustomOutputFormat = new System.Windows.Forms.TextBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.grpFormat.SuspendLayout();
            this.panelRadioButonFormat.SuspendLayout();
            this.panelOutputFormat.SuspendLayout();
            this.panelPredefinedOutputFormat.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.cboTimezone.Size = new System.Drawing.Size(284, 21);
            this.cboTimezone.TabIndex = 1;
            this.cboTimezone.ValueMember = "Id";
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Location = new System.Drawing.Point(458, 24);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(65, 17);
            this.chkEnabled.TabIndex = 2;
            this.chkEnabled.Text = "Enabled";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // grpFormat
            // 
            this.grpFormat.Controls.Add(this.panel1);
            this.grpFormat.Controls.Add(this.panelPredefinedOutputFormat);
            this.grpFormat.Controls.Add(this.panelOutputFormat);
            this.grpFormat.Controls.Add(this.panelRadioButonFormat);
            this.grpFormat.Location = new System.Drawing.Point(8, 48);
            this.grpFormat.Name = "grpFormat";
            this.grpFormat.Size = new System.Drawing.Size(324, 159);
            this.grpFormat.TabIndex = 3;
            this.grpFormat.TabStop = false;
            this.grpFormat.Text = "Format";
            // 
            // panelRadioButonFormat
            // 
            this.panelRadioButonFormat.Controls.Add(this.radioBtnDateAndTime);
            this.panelRadioButonFormat.Controls.Add(this.radioBtnTime);
            this.panelRadioButonFormat.Controls.Add(this.radioBtnDate);
            this.panelRadioButonFormat.Location = new System.Drawing.Point(6, 19);
            this.panelRadioButonFormat.Name = "panelRadioButonFormat";
            this.panelRadioButonFormat.Size = new System.Drawing.Size(230, 29);
            this.panelRadioButonFormat.TabIndex = 0;
            // 
            // radioBtnDate
            // 
            this.radioBtnDate.AutoSize = true;
            this.radioBtnDate.Location = new System.Drawing.Point(4, 4);
            this.radioBtnDate.Name = "radioBtnDate";
            this.radioBtnDate.Size = new System.Drawing.Size(48, 17);
            this.radioBtnDate.TabIndex = 0;
            this.radioBtnDate.TabStop = true;
            this.radioBtnDate.Text = "Date";
            this.radioBtnDate.UseVisualStyleBackColor = true;
            // 
            // radioBtnTime
            // 
            this.radioBtnTime.AutoSize = true;
            this.radioBtnTime.Location = new System.Drawing.Point(75, 4);
            this.radioBtnTime.Name = "radioBtnTime";
            this.radioBtnTime.Size = new System.Drawing.Size(48, 17);
            this.radioBtnTime.TabIndex = 1;
            this.radioBtnTime.TabStop = true;
            this.radioBtnTime.Text = "Time";
            this.radioBtnTime.UseVisualStyleBackColor = true;
            // 
            // radioBtnDateAndTime
            // 
            this.radioBtnDateAndTime.AutoSize = true;
            this.radioBtnDateAndTime.Location = new System.Drawing.Point(152, 4);
            this.radioBtnDateAndTime.Name = "radioBtnDateAndTime";
            this.radioBtnDateAndTime.Size = new System.Drawing.Size(74, 17);
            this.radioBtnDateAndTime.TabIndex = 2;
            this.radioBtnDateAndTime.TabStop = true;
            this.radioBtnDateAndTime.Text = "Date Time";
            this.radioBtnDateAndTime.UseVisualStyleBackColor = true;
            // 
            // panelOutputFormat
            // 
            this.panelOutputFormat.Controls.Add(this.radioBtnCustomOutputFormat);
            this.panelOutputFormat.Controls.Add(this.radioBtnPrefedinedOutputFormat);
            this.panelOutputFormat.Controls.Add(this.lblOutputFormat);
            this.panelOutputFormat.Location = new System.Drawing.Point(6, 54);
            this.panelOutputFormat.Name = "panelOutputFormat";
            this.panelOutputFormat.Size = new System.Drawing.Size(200, 30);
            this.panelOutputFormat.TabIndex = 1;
            // 
            // lblOutputFormat
            // 
            this.lblOutputFormat.AutoSize = true;
            this.lblOutputFormat.Location = new System.Drawing.Point(4, 4);
            this.lblOutputFormat.Name = "lblOutputFormat";
            this.lblOutputFormat.Size = new System.Drawing.Size(39, 13);
            this.lblOutputFormat.TabIndex = 0;
            this.lblOutputFormat.Text = "Output";
            // 
            // radioBtnPrefedinedOutputFormat
            // 
            this.radioBtnPrefedinedOutputFormat.AutoSize = true;
            this.radioBtnPrefedinedOutputFormat.Location = new System.Drawing.Point(50, 4);
            this.radioBtnPrefedinedOutputFormat.Name = "radioBtnPrefedinedOutputFormat";
            this.radioBtnPrefedinedOutputFormat.Size = new System.Drawing.Size(76, 17);
            this.radioBtnPrefedinedOutputFormat.TabIndex = 1;
            this.radioBtnPrefedinedOutputFormat.TabStop = true;
            this.radioBtnPrefedinedOutputFormat.Text = "Predefined";
            this.radioBtnPrefedinedOutputFormat.UseVisualStyleBackColor = true;
            // 
            // radioBtnCustomOutputFormat
            // 
            this.radioBtnCustomOutputFormat.AutoSize = true;
            this.radioBtnCustomOutputFormat.Location = new System.Drawing.Point(132, 4);
            this.radioBtnCustomOutputFormat.Name = "radioBtnCustomOutputFormat";
            this.radioBtnCustomOutputFormat.Size = new System.Drawing.Size(60, 17);
            this.radioBtnCustomOutputFormat.TabIndex = 2;
            this.radioBtnCustomOutputFormat.TabStop = true;
            this.radioBtnCustomOutputFormat.Text = "Custom";
            this.radioBtnCustomOutputFormat.UseVisualStyleBackColor = true;
            // 
            // panelPredefinedOutputFormat
            // 
            this.panelPredefinedOutputFormat.Controls.Add(this.cboCulture);
            this.panelPredefinedOutputFormat.Controls.Add(this.lblCulture);
            this.panelPredefinedOutputFormat.Location = new System.Drawing.Point(6, 90);
            this.panelPredefinedOutputFormat.Name = "panelPredefinedOutputFormat";
            this.panelPredefinedOutputFormat.Size = new System.Drawing.Size(309, 32);
            this.panelPredefinedOutputFormat.TabIndex = 2;
            // 
            // lblCulture
            // 
            this.lblCulture.AutoSize = true;
            this.lblCulture.Location = new System.Drawing.Point(4, 4);
            this.lblCulture.Name = "lblCulture";
            this.lblCulture.Size = new System.Drawing.Size(40, 13);
            this.lblCulture.TabIndex = 0;
            this.lblCulture.Text = "Culture";
            // 
            // cboCulture
            // 
            this.cboCulture.FormattingEnabled = true;
            this.cboCulture.Location = new System.Drawing.Point(51, 4);
            this.cboCulture.Name = "cboCulture";
            this.cboCulture.Size = new System.Drawing.Size(244, 21);
            this.cboCulture.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCustomOutputFormat);
            this.panel1.Controls.Add(this.lblCustomFormat);
            this.panel1.Location = new System.Drawing.Point(6, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 25);
            this.panel1.TabIndex = 3;
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
            // txtCustomOutputFormat
            // 
            this.txtCustomOutputFormat.Location = new System.Drawing.Point(83, 2);
            this.txtCustomOutputFormat.Name = "txtCustomOutputFormat";
            this.txtCustomOutputFormat.Size = new System.Drawing.Size(215, 20);
            this.txtCustomOutputFormat.TabIndex = 1;
            this.txtCustomOutputFormat.TextChanged += new System.EventHandler(this.txtCustomOutputFormat_TextChanged);
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(3, 10);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(865, 2);
            this.lblSeparator.TabIndex = 4;
            // 
            // DateTimeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.grpFormat);
            this.Controls.Add(this.chkEnabled);
            this.Controls.Add(this.cboTimezone);
            this.Controls.Add(this.lblTimeZone);
            this.Name = "DateTimeUserControl";
            this.Size = new System.Drawing.Size(984, 652);
            this.grpFormat.ResumeLayout(false);
            this.panelRadioButonFormat.ResumeLayout(false);
            this.panelRadioButonFormat.PerformLayout();
            this.panelOutputFormat.ResumeLayout(false);
            this.panelOutputFormat.PerformLayout();
            this.panelPredefinedOutputFormat.ResumeLayout(false);
            this.panelPredefinedOutputFormat.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeZone;
        private System.Windows.Forms.ComboBox cboTimezone;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.GroupBox grpFormat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCustomOutputFormat;
        private System.Windows.Forms.Label lblCustomFormat;
        private System.Windows.Forms.Panel panelPredefinedOutputFormat;
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
    }
}
