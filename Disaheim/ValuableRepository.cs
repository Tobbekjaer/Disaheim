using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;
using System.Buffers.Text;
using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Disaheim
{
	public class ValuableRepository : IPersistable
	{
		private List<IValuable> _valuables = new List<IValuable>();

		public List<IValuable> Valuables
		{
			get { return _valuables; }
			set { _valuables = value; }
		}

		public void AddValuable(IValuable valuable)
		{
			_valuables.Add(valuable);
		}

		public IValuable GetValuable(string id)
		{
			IValuable item = null;

			foreach (IValuable valuable in _valuables) {
				item = valuable;
			}

			return item;
		}

		public double GetTotalValue()
		{
			double total = 0;

			foreach (IValuable valuable in _valuables) {
				total += valuable.GetValue();
			}

			return total;
		}

		public int Count()
		{
			int count = 0;

			foreach (IValuable valuable in _valuables) {
				count++;
			}

			return count;
		}


		public void Save(string fileName = "ValuableRepository.txt")
		{
			List<string> lines = new List<string>();

			foreach (IValuable valuable in _valuables) {

				if (valuable is Book book) {
					string line = $"BOOK;{book.ItemId};{book.Title};{book.Price}";
					lines.Add(line);
				}
				else if (valuable is Amulet amulet) {
					string line = $"AMULET;{amulet.ItemId};{amulet.Quality};{amulet.Design}";
					lines.Add(line);
				}
				else if (valuable is Course course) {
					string line = $"COURSE;{course.Name};{course.DurationInMinutes}";
					lines.Add(line);
				}
			}
			File.WriteAllLines(fileName, lines);
		}


		public void Load(string fileName = "ValuableRepository.txt")
		{
			if(!File.Exists(fileName)) {
				throw new Exception("No file was found.");
			}

			string[] lines = File.ReadAllLines(fileName);

			foreach (string line in lines) {

				string[] lineArray = line.Split(";");

				switch(lineArray[0]) {

					case "BOOK":
						Book book = new Book(
							lineArray[1], 
							lineArray[2], 
							Convert.ToDouble(lineArray[3])
							);
						this.AddValuable(book);
						break;
					case "AMULET":
						Amulet amulet = new Amulet(
							lineArray[1],
							(Level)Enum.Parse(typeof(Level), lineArray[2]), 
							lineArray[3]
							);
						this.AddValuable(amulet);
						break;
					case "COURSE":
						Course course = new Course(
							lineArray[1],
							Convert.ToInt32(lineArray[2])
							);
						this.AddValuable(course);
						break;
					default:
						break;
				}

			}

		}
	}
}
