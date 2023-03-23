using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
	public class Controller
	{
		// Fields and properties of the list datatype
		private List<Book> _books = new List<Book>();

		public List<Book> Books
		{
			get { return _books; }
			set { _books = value; }
		}

		private List<Amulet> _amulets;

		public List<Amulet> Amulets
		{
			get { return _amulets; }
			set { _amulets = value; }
		}

        public List<Course> Courses { get; set; }

        // Constructors that initializes the properties for Books and Amulets
        public Controller()
		{
			_books = new List<Book>();
			_amulets = new List<Amulet>();
			Courses = new List<Course>();
        }

		// Metode der tilføjer objekter til deres respektive lister
		// Lavet med method overloading --> en metode som gør det samme, men tager forskellige parametre
		// Det betyder, at man kan kalde begge metoder på samme måde med Add(book eller amulet)
		public void AddToList(Book book)
		{
			_books.Add(book);
		}

		public void AddToList(Amulet amulet)
		{
			_amulets.Add(amulet);
		}

		public void AddToList(Course course)
		{
			Courses.Add(course);
		}






    }
}
