using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace StreamCompanion.Objects
{
    public class DateTimeClass : ISerializable
    {
        private TimeZoneInfo _timezone;

        public TimeZoneInfo TimeZone
        {
            get { return _timezone; }
            set { _timezone = value; }
        }

        public int DisplayType { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
