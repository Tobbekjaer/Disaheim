using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Disaheim
{
    public interface IPersistable
    {
        // Implementation of interface methods 
        void Save(string fileName);
       
        void Load(string fileName);

    }
}
