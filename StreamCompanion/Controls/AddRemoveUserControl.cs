using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamCompanion.Controls
{

    public enum AddRemoveUserControl
    {
        Add = 0,
        Remove = 1
    }
    public class AddRemoveUserControlEventArgs : EventArgs
    {
        public AddRemoveUserControl Action { get; set; }
        public UserControl userControl { get; set; }

    }
}
