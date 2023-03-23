using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Disaheim;

namespace Disaheim
{
    public class BookRepository
    {
        private List<Book> _books = new List<Book>();

        public List<Book> Books
        {
            get { return _books; }
            set { _books = value; }
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public Book GetBook(string itemId)
        {
            Book book1 = null;
            foreach (Book book in _books) {
                if(book.ItemId == itemId) {
                    book1 = book;
                }
            }

            return book1;

        }

        public double GetTotalValue() 
        {
            double price = 0;
            foreach (Book book in _books) {
                var utility = new Utility();
                price += utility.GetValueOfBook(book);
                
            }

            return price; 
        }


    }
}
