using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.ComponentModel;

namespace StreamCompanion.Objects
{
    public class EnhancedSerialPort : SerialPort
    {
        public EnhancedSerialPort() : base()
        {

        }

        public EnhancedSerialPort(string portname)
        {
            PortName = portname;
        }

     
        [ReadOnly(true)]
        public new string PortName {
            get
            {
                return base.PortName;
            }
            set
            {
                base.PortName = value;
            }
        }


        [System.ComponentModel.Browsable(true)]
        public new string NewLine { 
            get
            {
                return base.NewLine;
            }
            set
            {
                base.NewLine = value;
            }
        }

    }
}
