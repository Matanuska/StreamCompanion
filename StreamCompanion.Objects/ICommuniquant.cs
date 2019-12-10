using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCompanion.Objects
{
    public interface ICommuniquant
    {
        void AddPort(string port);
        void RemovePort(string port);

        void MessageReceived(string port, string message);
    }
}
