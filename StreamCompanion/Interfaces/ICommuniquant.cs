using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCompanion.Interfaces
{
    interface ICommuniquant
    {
        void AddPort(string port);
        void RemovePort(string port);

        void SendMessage(string port, string message);
    }
}
