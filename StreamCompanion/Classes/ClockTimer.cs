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
            args.Time = cstTime.ToString(TimeFormat, CultureInfo.InvariantCulture);


            EventHandler<ThresholdReachedEventArgs> handler = TimeChanged;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        public TimeZoneInfo TimeZone { get; set; }

        public string TimeFormat
        {
            private get { return timeformat; }
            set { timeformat = value; }
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
        public string Time { get; set; }

    }
}
