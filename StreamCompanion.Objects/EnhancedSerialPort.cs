using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.ComponentModel;

namespace StreamCompanion.Objects
{
    public class EnhancedSerialPort : SerialPort, IDisposable
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


        //[System.ComponentModel.Browsable(true)]
        //public new string NewLine { 
        //    get
        //    {
        //        return base.NewLine;
        //    }
        //    set
        //    {
        //        base.NewLine = value;
        //    }
        //}

        [Browsable(true)]
//        [Description("klmklmklmklm")]
        [TypeConverter(typeof(NewLineConverter))]
        public new string NewLine
        {
            get
            {
                switch (base.NewLine)
                {
                    case "\n":
                        return "LF";
                        break;
                    case "\r":
                        return "CR";
                        break;
                    case "\r\n":
                        return "CRLF";
                        break;
                }
                return base.NewLine;
            }
            set
            {
                switch (value)
                {
                    case "LF":
                        base.NewLine = "\n";
                        break;
                    case "CR":
                        base.NewLine = "\r";
                        break;
                    case "CRLF":
                        base.NewLine = "\r\n";
                        break;
                    default:
                        base.NewLine = value;
                        break;
                }

            }
        }




        public new void Dispose()
        {
            base.Dispose();
        }

    }

    public class NewLineConverter : StringConverter
    {
        public override Boolean GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
        public override Boolean GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            List<String> list = new List<String>();
            list.Add("LF");
            list.Add("CR");
            list.Add("CRLF");
            return new StandardValuesCollection(list);
        }
    }

}
