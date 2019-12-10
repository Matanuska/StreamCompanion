using System;
using System.Windows.Forms;
using System.Globalization;

namespace StreamCompanion.Objects
{
    public class ClockTimer : Timer
    {
        DateTime timeUtc = DateTime.UtcNow;
        private Timer timer1;
        private System.ComponentModel.IContainer components;
        private string timeformat = "HH:mm:ss";
        private string customformat = "";

        public event EventHandler<ThresholdReachedEventArgs> TimeChanged;

        public ClockTimer()
        {
            this.TimeZone = TimeZoneInfo.Local;
            Tick += new EventHandler(getTime);
            this.Interval = 1;
            this.Enabled = true;

            this.Interval = 1000;
        }

        private void getTime(object sender, EventArgs e)
        {
            timeUtc = DateTime.UtcNow;
            DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, this.TimeZone);


            ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();

            if (timeformat != string.Empty)
            {
                args.DateTime = cstTime.ToString(TimeFormat, this.CultureInfo);
            }
            else
            {
                //cstTime.ToString(TimeFormat, CultureInfo.InvariantCulture);
                args.DateTime = "";
                if(customformat != string.Empty)
                {
                    /*
                     * d 1->31
                     * dd 01-> 31
                     * ddd -> Mon
                     * dddd ->Monday
                     * M 1 -> 12 (mois)
                     * MM 01 -> 12 (mois)
                     * MMM -> Jun
                     * MMMM -> June
                     * Y 0 -> 99
                     * yy 00->99
                     * yyy 001 -> 999 
                     * yyyy 0001 -> 0900
                     * yyyyy 00001 -> 02009
                     * 
                     * h 1 -> 12                shour12
                     * hh 01 -> 12              lhour12    
                     * H 1 -> 13                shour24
                     * HH 01 -> 13              lhour24
                     * m 0 -> 59                smin
                     * mm 00 -> 59              lmin
                     * s 0 -> 59                ssec
                     * ss 00 -> 59              lsec
                     * 
                     * t A/P        
                     * tt AM/PM
                     * 
                     */

                    int currenthour = cstTime.Hour;
                    int currentminute = cstTime.Minute;
                    int currentseconde = cstTime.Second;
                    
                    int currentyear = cstTime.Year;

                    string amdesignator = this.CultureInfo.DateTimeFormat.AMDesignator;
                    string pmdesignator = this.CultureInfo.DateTimeFormat.PMDesignator;

                    string ldesignator = "";
                    string sdesignator = "";

                    if(cstTime.Hour < 13)
                    {
                        ldesignator = amdesignator;
                        if (amdesignator != string.Empty)                        
                            sdesignator = ldesignator.Substring(0, 1);
                        
                    }
                    else
                    {
                        ldesignator = pmdesignator;
                        if (amdesignator != string.Empty)
                            sdesignator = ldesignator.Substring(0, 1);
                    }

                    var shour12 = currenthour;
                    if (shour12 > 12)
                    {
                        shour12 = shour12 - 12;
                    }
                    string lhour12 = shour12.ToString().PadLeft(2, '0');

                    var shour24 = currenthour;                    
                    string lhour24 = shour24.ToString().PadLeft(2, '0');

                    string smin = currentminute.ToString();
                    string Lmin = currentminute.ToString().PadLeft(2,'0');

                    string ssec = currentseconde.ToString();
                    string lsec = currentseconde .ToString().PadLeft(2, '0');


                    string day1 = cstTime.Day.ToString("d");
                    string day2 = day1.PadLeft(2, '0');
                    string day3 = this.cultureinfo.DateTimeFormat.AbbreviatedDayNames[(int)cstTime.DayOfWeek].ToString();
                    string day4 = this.cultureinfo.DateTimeFormat.DayNames[(int)cstTime.DayOfWeek].ToString();
                                        
                    string month1 = cstTime.Month.ToString();
                    string month2 = cstTime.Month.ToString().PadLeft(2, '0');
                    string month3 = this.CultureInfo.DateTimeFormat.AbbreviatedMonthNames[cstTime.Month - 1].ToString();
                    string month4 = this.CultureInfo.DateTimeFormat.MonthNames[cstTime.Month - 1].ToString();
                    
                    string year4 = cstTime.ToString("yyyy");                    
                    string year2 = cstTime.ToString("yy");
                    

                    args.DateTime = customformat.Replace("%HH", lhour24).Replace("%H", shour24.ToString()).Replace("%hh", lhour12)
                        .Replace("%h", shour12.ToString()).Replace("%mm", Lmin.ToString()).Replace("%m", smin.ToString())
                        .Replace("%ss", lsec.ToString()).Replace("%s", ssec.ToString())
                        .Replace("%dddd", day4).Replace("%ddd", day3).Replace("%dd", day2).Replace("%d", day1)
                        .Replace("%MMMM", month4).Replace("%MMM", month3).Replace("%MM", month2).Replace("%M", month1)
                        .Replace("%yyyy", year4).Replace("%yy", year2).Replace("%tt", ldesignator).Replace("%t", sdesignator);
                        
                }
            }



            EventHandler<ThresholdReachedEventArgs> handler = TimeChanged;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        private CultureInfo cultureinfo = CultureInfo.InvariantCulture;

        public CultureInfo CultureInfo
        {
            get { return cultureinfo; }
            set { cultureinfo = value; }
        }


        public TimeZoneInfo TimeZone { get; set; }

        public string TimeFormat
        {
            private get { return timeformat; }
            set { timeformat = value; customformat = string.Empty; }
        }

        public string CustomFormat { 
            get
            {
                return customformat;
            }
            set
            {
                customformat = value;
                timeformat = string.Empty;
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        
    }
    public class ThresholdReachedEventArgs : EventArgs
    {
        public string DateTime { get; set; }

    }
}
