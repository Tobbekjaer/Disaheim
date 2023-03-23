using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class MerchandiseRepository
    {
		private List<Merchandise> _merchandises = new List<Merchandise>();

		public List<Merchandise> Merchandise
		{
			get { return _merchandises; }
			set { _merchandises = value; }
		}

		public void AddMerchandise(Merchandise merchandise)
		{
			_merchandises.Add(merchandise);
		}


		public Merchandise GetMerchandise(string itemId)
		{
			Merchandise merchandise1 = null;

			foreach(Merchandise merch in _merchandises) {

				if (merch is Book && itemId == merch.ItemId) {
					merchandise1 = merch;
					break;

				}else if(merch is Amulet && itemId == merch.ItemId) {
					merchandise1 = merch;
					break;
				}
			}

			return merchandise1; 

		}


		public double GetTotalValue()
		{
            Utility utility = new Utility();
            double priceBook = 0;
			double priceAmulet = 0;

			double priceTotal = 0;

            foreach (Merchandise merch in _merchandises) {
				if (merch is Book) {
					priceBook += utility.GetValueOfMerchandise(merch);
					
				} else if (merch is Amulet) {
                    priceAmulet += utility.GetValueOfMerchandise(merch);
					
                }

            }

			foreach(Merchandise merch in _merchandises) {
                if (merch is Book) {
                    priceTotal = priceBook;
					return priceTotal;
                }
                else if (merch is Amulet) {
                    priceTotal = priceAmulet;
					return priceTotal;
                }
            }

			return priceTotal;


        }





	}


}
