using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace StreamCompanion.Objects
{

    public enum AddRemoveUserControl
    {
        Add = 0,
        Remove = 1
    }
    public class AddRemoveUserControlEventArgs : EventArgs
    {
        public AddRemoveUserControl Action { get; set; }
        public Type TypeUserControl { get; set; }

        public UserControl UserControl { get; set; }

        public Control ControlContainer { get; set; }

    }
}
