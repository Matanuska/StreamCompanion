using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.ComponentModel;
using StreamCompanion.Interfaces;
using System.Threading;

namespace StreamCompanion.Classes
{

    /// <summary>
    /// The EnhancedSerialPort is the class that is derived from MS SerialPort class.
    /// It listes all available serial ports of the computer.
    /// And it automatically assigns the first available port. to itself.
    /// By: Lemuel Adane
    /// Created: June 15, 2011
    /// </summary>    
    public class EnhancedSerialPort : SerialPort
    {
        #region Variables

        // data read parameters
        protected string _dataRead = null;

        // declare and instantiate a list for available ports
        List<string> _availablePorts = new List<string>();

        // connection flag
        protected bool _connected;

        // flag that data is in the received buffer
        bool _isReceived = false;

        #endregion


        #region Properties

        /// <summary>
        /// Property that returns string read from serial ports.
        /// </summary>
        public string DataRead { get { return _dataRead; } }


        /// <summary>
        /// Property that returns all the available ports.
        /// </summary>
        public List<string> AvailablePorts
        {
            get
            {
                return _availablePorts;
            }
        }

        /// <summary>        
        /// Property which sets and gets the command to retrieve the device Id from the device.
        /// </summary>
        public string DeviceIdCommand { get; set; }


        /// <summary>
        /// Will serve as the device's ID reference
        /// </summary>
        public string DeviceId { get; set; }

        #endregion


        #region Constructors

        public EnhancedSerialPort() : base()
        {
            InitializeComponent();
        }

        public EnhancedSerialPort(IContainer container) : base(container)
        {
            InitializeComponent();
        }
        #endregion


        #region Methods

        public void InitializeComponent()
        {
            //sets the read and write timeout to 5 seconds
            base.WriteTimeout = base.ReadTimeout = 500;

            // if a port is available assigns the first available port to your device.
            if (GetAvailablePorts().Count > 0)
                base.PortName = _availablePorts[0];

            this.DataReceived +=
                new System.IO.Ports.SerialDataReceivedEventHandler(
                this.OnDataReceived);
            this.PinChanged +=
                new System.IO.Ports.SerialPinChangedEventHandler(
                    this.OnPinChanged);
        }


        /// <summary>
        /// The method that filters all the available ports which are not taken by some devices
        /// </summary>
        private List<string> GetAvailablePorts()
        {
            //SerialPort.GetNames() method gets all specified serial ports from your computer.
            foreach (string port in SerialPort.GetPortNames())
            {
                base.PortName = port;

                try
                {
                    // check if port is open and close it.
                    if (base.IsOpen)
                        base.Close();

                    base.Open();

                    _availablePorts.Add(base.PortName);

                    base.Close();

                    continue;
                }

                catch (System.IO.IOException ioError)
                {
                    if (ioError.Message.EndsWith("does not exist."))
                        continue;
                }

                catch (System.UnauthorizedAccessException uax)
                {
                    if (uax.Message.EndsWith("is denied."))
                        continue;
                }
            }

            if (_availablePorts.Count == 0)
                throw new NoSerialPortAvailableError();

            return _availablePorts;
        }

        /// <summary>
        /// The method that initiate the handshake between your PC and your device.
        /// </summary>
        public bool CheckConnection()
        {
            if (!base.IsOpen)
            {
                foreach (string port in AvailablePorts)
                {
                    if (base.IsOpen) base.Close();

                    base.PortName = port;
                    try
                    {
                        if (!base.IsOpen) base.Open();
                    }

                    catch (System.UnauthorizedAccessException uax)
                    {
                        if (uax.Message.EndsWith("is denied."))
                            continue;
                    }

                    // Retrieves the device ID 
                    base.Write(DeviceIdCommand);

                    //wait for sometime
                    for (int i = 0; i < 10 && !_isReceived; i++)
                    {
                        Thread.Sleep(50);
                    }

                    _isReceived = false;

                    // Check if the device id is right, if it is declare it is connected to the
                    // right device
                    if (_dataRead != null)
                        if (_dataRead.Equals(DeviceId))
                        {
                            _connected = true;

                            return true;
                        }

                    _connected = false;
                }
            }

//            if (!_connected) throw new DeviceCommunicationError();

            return _connected;
        }

        #endregion


        #region Event Handler Methods

        protected virtual void OnDataReceived(
        object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            _dataRead = ReadLine();
        }


        protected virtual void OnPinChanged(
        object sender, System.IO.Ports.SerialPinChangedEventArgs e)
        {
            if (e.EventType == SerialPinChange.CDChanged)
            {

            }

            else if (e.EventType == SerialPinChange.CtsChanged)
            {

            }

            else if (e.EventType == SerialPinChange.DsrChanged)
            {

            }
        }
        #endregion


        #region Exceptions

        /// <summary>
        /// Exception thrown when there is no available ports detected.
        /// </summary>
        public class NoSerialPortAvailableError : Exception
        {
            public override string Message
            {
                get
                {
                    return "No serial port available.";
                }
            }
        }

        /// <summary>
        /// Exception thrown when the handshake fails.
        /// </summary>
        public class ConnectionError : Exception
        {
            public override string Message
            {
                get
                {
                    return "Disconnected or cannot connect to the device.";
                }
            }
        }
        #endregion

    }

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

    public class AsyncSerialPortManager
    {

        /// <summary>
        /// Your port name
        /// </summary>
        private string portname = "";        
        public string PortName
        {
            get { return portname; }
            set { portname = value; }
        }


        /// <summary>
        /// Your port baund rate
        /// </summary>        
        private int portbaudrate = 9600;

        public int PortBaudRate
        {
            get { return portbaudrate; }
            set { portbaudrate = value; }
        }

        public Parity Parity { get; set; }

        public int DataBits { get; set; }

        public StopBits StopBits { get; set; }

        public Handshake Handshake { get; set; }

        public int ReadTimeout { get; set; }

        public int WriteTimeout { get; set; }

        /// <summary>
        /// Create a new serial port
        /// </summary>
        private SerialPort port;

        /// <summary>
        /// Return value of your port that you want to catch
        /// </summary>
        public static string ReturnValue;

        /// <summary>
        /// When serial port started, it's pushing some values that you wrote. If it is first opening then send start command to port.
        /// </summary>
        public static bool IsFirstSending = true;

        /// <summary>
        /// We listen to port as async, this event will send in async method
        /// </summary>
        /// <param name="message"></param>
        /// <param name="isCompleted"></param>
        /// <param name="isSuccess"></param>
        public delegate void MessageReceived(string message, bool isCompleted, bool isSuccess);
        public static event MessageReceived OnMessageReceived;

        /// <summary>
        /// Open port and start listening
        /// </summary>
        public void Open()
        {
            port = new SerialPort(PortName, PortBaudRate);
            port.Parity = Parity;
            port.DataBits = DataBits;
            port.StopBits = StopBits;
            port.Handshake = Handshake;
            port.ReadTimeout = ReadTimeout;
            port.WriteTimeout = WriteTimeout;

            ReturnValue = string.Empty;
            Close();
            port.Open();
            ListenPort();
            port.DataReceived += Port_DataReceived;
        }

        /// <summary>
        /// Close port
        /// </summary>
        public void Close()
        {
            if (port != null)
            {
                if (port.IsOpen)
                {
                    port.Close();
                }
            }
        }

        /// <summary>
        /// Serial port data received method. Send start command when it is first opening
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (IsFirstSending)
            {
                port.Write("start");
                IsFirstSending = false;
            }
        }

        /// <summary>
        /// Listen port as async.
        /// </summary>
        /// <returns></returns>
        async Task ListenPortAsyncTask()
        {
            while (true)
            {
                // Read port value
                string message = port.ReadLine();
                // Throw event
                if (OnMessageReceived != null)
                {
                    if (message.Contains("ReturnValue:"))
                    {
                        // This the string that i want to catch before process finished
                        // Take value and continue for finish
                        ReturnValue = message;
                    }
                    else if (message.Contains("Finished"))
                    {
                        // Finish process as success
                        OnMessageReceived(message, true, true);
                        break;
                    }
                    else if (message.Contains("Error"))
                    {
                        // Finish process as fail
                        OnMessageReceived(message, true, false);
                        break;
                    }
                    else
                    {
                        // On other causes continue reading
                        OnMessageReceived(message, false, false);
                    }
                }
            }
        }

        /// <summary>
        /// Call async method
        /// </summary>
        async void ListenPort()
        {
            await Task.Run(() => ListenPortAsyncTask());
        }

    }
}
