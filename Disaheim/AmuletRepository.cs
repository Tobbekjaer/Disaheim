using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> _amulets = new List<Amulet>();

        public List<Amulet> Amulets
        {
            get { return _amulets; }
            set { _amulets = value; }
        }

        public void AddAmulet(Amulet amulet)
        {
            _amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            Amulet amulet1 = null;
            foreach (Amulet amulet in _amulets) {
                if (amulet.ItemId == itemId) {
                    amulet1 = amulet; 
                }
                else {
                    amulet1 = null;
                }
            }

            return amulet1;

        }

        public double GetTotalValue()
        {
            double price = 0;
            foreach (Amulet amulet in _amulets) {
                var utility = new Utility();
                price += utility.GetValueOfAmulet(amulet);
            }

            return price;
        }


    }
}
