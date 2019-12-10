using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StreamCompanion.Objects;


namespace StreamCompanion.Objects
{
    public interface IDuplicable
    {
        
         Boolean IsFirst { get; set; }

         Boolean IsLast { get; set; }

         object DataSource { get; set; }

        event EventHandler<AddRemoveUserControlEventArgs> DuplicateControl;
    }
}
