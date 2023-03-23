using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public abstract class Merchandise
    {
        // Auto-implemented property 
        public string ItemId { get; set; }

        // ItemId doesn't need a counstructor since it is automatically created by the auto-implemented property.

        //// Constructor 
        //public Merchandise(string itemId) {
        //    ItemId = itemId;
        //}

        public abstract string ToString();
       
    }
}
