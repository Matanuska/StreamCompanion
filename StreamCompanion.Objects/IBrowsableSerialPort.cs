using System;
using System.IO.Ports;


namespace StreamCompanion.Objects
{
    public interface IBrowsableSerialPort
    {
        int BaudRate { get; set; }
        int DataBits { get; set; }
        Parity Parity { get; set; }
        Handshake Handshake { get; set; }
        Boolean DiscardNull { get; set; }
        Boolean DtrEnable { get; set; }
        byte ParityReplace { get; set; }
        int ReadBufferSize { get; set; }
        int ReadTimeout { get; set; }
        int ReceivedBytesThreshold { get; set; }
        bool RtsEnable { get; set; }
        StopBits StopBits { get; set; }
        int WriteBufferSize { get; set; }
        int WriteTimeout { get; set; }
    }
}
