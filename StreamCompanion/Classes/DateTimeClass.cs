using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCompanion.Classes
{
    public class DateTimeClass
    {
        private TimeZoneInfo _timezone;

        public TimeZoneInfo TimeZone
        {
            get { return _timezone; }
            set { _timezone = value; }
        }

    }
}
