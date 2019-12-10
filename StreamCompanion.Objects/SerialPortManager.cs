using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;

using StreamCompanion.Objects;

namespace StreamCompanion.Objects
{



    [TypeDescriptionProvider(typeof(MyTypeDescriptionProvider<IBrowsableSerialPort>))]
    public class SerialPortManager : SerialPort , IBrowsableSerialPort
    {
        public SerialPortManager() : base()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {            
            //base.WriteTimeout = base.ReadTimeout = 500;
        }


    }


    public class MyTypeDescriptionProvider<T> : TypeDescriptionProvider
    {
        public MyTypeDescriptionProvider() : base(TypeDescriptor.GetProvider(typeof(T))) { }

        public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType,
            object instance)
        {
            return base.GetTypeDescriptor(typeof(T), instance);
        }
    }

    public class SendComMessageEventArgs : EventArgs
    {
        public String SerialPort { get; set; }
        public String Message { get; set; }

    }

}
