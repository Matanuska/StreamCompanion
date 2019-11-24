﻿namespace StreamCompanion
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
            System.Windows.Forms.TabPage tabCountdownZero;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1tabDateAndTime = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabChrono = new System.Windows.Forms.TabPage();
            this.tabCountdownToDate = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TimersPanel = new System.Windows.Forms.Panel();
            this.grpComPorts = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dateTimeUserControl1 = new StreamCompanion.Controls.DateTimeUserControl();
            tabCountdownZero = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1tabDateAndTime.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.TimersPanel.SuspendLayout();
            this.grpComPorts.SuspendLayout();
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
            this.flowLayoutPanel1.Controls.Add(this.dateTimeUserControl1);
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.button1);
            resources.ApplyResources(this.settingsPanel, "settingsPanel");
            this.settingsPanel.Name = "settingsPanel";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // TimersPanel
            // 
            this.TimersPanel.Controls.Add(this.grpComPorts);
            this.TimersPanel.Controls.Add(this.tabControl1);
            resources.ApplyResources(this.TimersPanel, "TimersPanel");
            this.TimersPanel.Name = "TimersPanel";
            // 
            // grpComPorts
            // 
            this.grpComPorts.Controls.Add(this.checkedListBox1);
            resources.ApplyResources(this.grpComPorts, "grpComPorts");
            this.grpComPorts.Name = "grpComPorts";
            this.grpComPorts.TabStop = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // dateTimeUserControl1
            // 
            this.dateTimeUserControl1.CultureInfo = new System.Globalization.CultureInfo("fr-FR");
            this.dateTimeUserControl1.InstanceNumber = 0;
            resources.ApplyResources(this.dateTimeUserControl1, "dateTimeUserControl1");
            this.dateTimeUserControl1.Name = "dateTimeUserControl1";
            this.dateTimeUserControl1.TimeZoneInfo = ((System.TimeZoneInfo)(resources.GetObject("dateTimeUserControl1.TimeZoneInfo")));
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimersPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1tabDateAndTime.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.TimersPanel.ResumeLayout(false);
            this.grpComPorts.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabCountdownToDate;
        private Controls.DateTimeUserControl dateTimeUserControl1;
        private System.Windows.Forms.Panel TimersPanel;
        private System.Windows.Forms.GroupBox grpComPorts;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}