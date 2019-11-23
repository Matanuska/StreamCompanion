﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace StreamCompanion.Controls
{
    public partial class DateTimeUserControl : UserControl
    {
        public DateTimeUserControl()
        {
            InitializeComponent();
            Init();
        }


        Classes.ClockTimer myTimer = new Classes.ClockTimer();

        public void Init()
        {
            panelCustomFormat.Location = panelPredefinedOutput.Location;            
            


            var cultureList = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();
            cultureList.Sort((p1, p2) => string.Compare(p1.DisplayName, p2.DisplayName, true));
            cboCulture.DataSource = cultureList;            
            cboCulture.SelectedValue = this.CultureInfo.Name;
            cboCulture.SelectedIndexChanged += cboCultureChanged;            



            radioBtnDate.CheckedChanged += loadCboPredefinedFormat;
            radioBtnTime.CheckedChanged += loadCboPredefinedFormat;

            radioBtnDate.Checked = true;
            radioBtnPrefedinedOutputFormat.Checked = true;

            cboTimezone.DataSource = TimeZoneInfo.GetSystemTimeZones().ToList();
            cboTimezone.SelectedValue = this.TimeZoneInfo.Id;

            cboTimezone.SelectedIndexChanged += new System.EventHandler(this.cboTimezone_SelectedIndexChanged);

            
            radioBtnCustomOutputFormat.CheckedChanged += switchPredefinedOrCustomPanel;
            radioBtnPrefedinedOutputFormat.CheckedChanged += switchPredefinedOrCustomPanel;


            loadCboPredefinedFormat(this,null);

            this.cboPredefinedFormats.SelectedIndexChanged += new System.EventHandler(this.cboPredefinedFormats_SelectedIndexChanged);


            myTimer.CultureInfo = this.CultureInfo;
            myTimer.TimeChanged += MyTimer_TimeChanged;
            chkEnabled.Checked = true;
            

        }

        private void MyTimer_TimeChanged(object sender, Classes.ThresholdReachedEventArgs e)
        {
            lblOutputSample.Text = string.Concat("[", e.DateTime.ToString(), "]");
        }

        private CultureInfo selectedCulture = CultureInfo.CurrentUICulture;

        public CultureInfo CultureInfo
        {
            get { return selectedCulture ; }
            set { selectedCulture  = value; }
        }


        private TimeZoneInfo selectedTimeZone = TimeZoneInfo.Local;

        public TimeZoneInfo TimeZoneInfo
        {
            get { return selectedTimeZone; }
            set { selectedTimeZone = value; }
        }



        private void DateTimeUserControl_Load(object sender, EventArgs e)
        {

        }

        private void cboCulture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCultureChanged(object sender, EventArgs e){

            this.CultureInfo = CultureInfo.GetCultureInfo(((CultureInfo)((ComboBox)sender).SelectedItem).Name);

            // chargement des formats

            var checkedButton = panelRadioButonFormat.Controls.OfType<RadioButton>()
              .FirstOrDefault(r => r.Checked);

            loadCboPredefinedFormat(sender, e);

            myTimer.CultureInfo = this.CultureInfo;

        }

        private void loadCboPredefinedFormat(object sender, EventArgs e)
        {

            var checkedButton = panelRadioButonFormat.Controls.OfType<RadioButton>()
                                .FirstOrDefault(r => r.Checked);


            List<string> lstdate = new List<string>();
            var f = this.CultureInfo.DateTimeFormat;
            string pattern = "";

            if (checkedButton.Name == "radioBtnDate")
            {
                if (!lstdate.Contains(f.LongDatePattern))
                {
                    lstdate.Add(f.LongDatePattern);
                }
                if (!lstdate.Contains(f.MonthDayPattern))
                {
                    lstdate.Add(f.MonthDayPattern);
                }
                if (!lstdate.Contains(f.ShortDatePattern))
                {
                    lstdate.Add(f.ShortDatePattern);
                    pattern = f.ShortDatePattern;
                }
                if (!lstdate.Contains(f.YearMonthPattern))
                {
                    lstdate.Add(f.YearMonthPattern);
                }
            }
            else
            {
                if (checkedButton.Name == "radioBtnTime")
                {
                    if (!lstdate.Contains(f.LongTimePattern))
                    {
                        lstdate.Add(f.LongTimePattern);
                        pattern = f.LongTimePattern;
                    }
                    if (!lstdate.Contains(f.ShortTimePattern))
                    {
                        lstdate.Add(f.ShortTimePattern);
                    }
                }
                else
                {
                    if (!lstdate.Contains(f.LongDatePattern))
                    {                        
                        if (!lstdate.Contains(f.LongTimePattern))
                        {
                            lstdate.Add(string.Concat(f.LongDatePattern," ",f.LongTimePattern));

                        }
                        if (!lstdate.Contains(f.ShortTimePattern))
                        {
                            lstdate.Add(string.Concat(f.LongDatePattern, " ", f.ShortTimePattern));                            
                        }
                    }
                    if (!lstdate.Contains(f.MonthDayPattern))
                    {
                        if (!lstdate.Contains(f.LongTimePattern))
                        {
                            lstdate.Add(string.Concat(f.MonthDayPattern, " ", f.LongTimePattern));
                        }
                        if (!lstdate.Contains(f.ShortTimePattern))
                        {
                            lstdate.Add(string.Concat(f.MonthDayPattern, " ", f.ShortTimePattern));
                        }
                    }
                    if (!lstdate.Contains(f.ShortDatePattern))
                    {
                        if (!lstdate.Contains(f.LongTimePattern))
                        {
                            lstdate.Add(string.Concat(f.ShortDatePattern, " ", f.LongTimePattern));
                            pattern = string.Concat(f.ShortDatePattern, " ", f.LongTimePattern);
                        }
                        if (!lstdate.Contains(f.ShortTimePattern))
                        {
                            lstdate.Add(string.Concat(f.ShortDatePattern, " ", f.ShortTimePattern));
                        }
                    }
                    if (!lstdate.Contains(f.YearMonthPattern))
                    {
                        if (!lstdate.Contains(f.LongTimePattern))
                        {
                            lstdate.Add(string.Concat(f.YearMonthPattern, " ", f.LongTimePattern));
                        }
                        if (!lstdate.Contains(f.ShortTimePattern))
                        {
                            lstdate.Add(string.Concat(f.YearMonthPattern, " ", f.ShortTimePattern));
                        }
                    }

                }
            }


            lstdate.Sort();

            cboPredefinedFormats.DataSource = lstdate;

            cboPredefinedFormats.SelectedItem = pattern;
            
        }


        public void switchPredefinedOrCustomPanel(object sender, EventArgs e)
        {
            var checkedButton = panelOutputFormat.Controls.OfType<RadioButton>()
              .FirstOrDefault(r => r.Checked);

            if(checkedButton.Name == "radioBtnPrefedinedOutputFormat")
            {
                panelPredefinedOutput.Visible = true;
                panelCustomFormat.Visible = false;
                myTimer.TimeFormat = cboPredefinedFormats.Text;
            }
            else
            {
                panelPredefinedOutput.Visible = false;
                panelCustomFormat.Visible = true;                
                myTimer.CustomFormat = txtCustomOutputFormat.Text.Trim();
            }
            
        }

        private void radioBtnDate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboTimezone_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(((TimeZoneInfo)((ComboBox)sender).SelectedItem).Id);
            myTimer.TimeZone = this.TimeZoneInfo;
        }

        private void cboPredefinedFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            myTimer.TimeFormat = ((ComboBox)sender).Text;
        }

        private void radioBtnPrefedinedOutputFormat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnCustomOutputFormat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomOutputFormat_TextChanged(object sender, EventArgs e)
        {
            myTimer.CustomFormat = ((TextBox)sender).Text.Trim();
        }
    }
}
