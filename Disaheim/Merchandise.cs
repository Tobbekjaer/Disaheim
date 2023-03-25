using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public abstract class Merchandise : IValuable
    {
        // Auto-implemented property 
        // ItemId doesn't need a counstructor since it is automatically created by the auto-implemented property.
        public string ItemId { get; set; }

        

       // All baseclass that inherit from the abstract class must implement the abstract methods defined 
        // Abstract ToString() method
        public abstract string ToString();
        // Abstract GetValue() method
        public abstract double GetValue();
       
    }
}
