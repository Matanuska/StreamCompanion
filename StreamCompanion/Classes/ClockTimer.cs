using System;
using System.Windows.Forms;
using System.Globalization;

namespace StreamCompanion.Classes
{
    class ClockTimer : Timer
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
                     * h 1 -> 12
                     * hh 01 -> 12
                     * H 1 -> 13
                     * HH 01 -> 13
                     * m 0 -> 59
                     * mm 00 -> 59
                     * s 0 -> 59
                     * ss 00 -> 59
                     * 
                     * t A/P
                     * tt AM/PM
                     * 
                     */
                    string lhour = cstTime.Hour.ToString().PadLeft(2, '0');
                    args.DateTime = customformat.Replace("%HH", lhour);

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
