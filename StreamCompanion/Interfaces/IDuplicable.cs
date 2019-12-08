using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StreamCompanion.Classes;


namespace StreamCompanion.Interfaces
{
    interface IDuplicable
    {
        // void Duplicate(object sender,EventArgs e);
        public Boolean IsFirst { get; set; }

        public Boolean IsLast { get; set; }

        public object DataSource { get; set; }

        event EventHandler<AddRemoveUserControlEventArgs> DuplicateControl;
    }
}
