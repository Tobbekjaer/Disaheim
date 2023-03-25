using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise 
    {
		// Fields and properties
		private string _title;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		private double _price;

		public double Price
		{
			get { return _price; }
			set { _price = value; }
		}

        // Constructors
        // Step 1: base(itemId) explicitly calls the Merchandise class constructor
        // ItemId is a property found in the Merchandise class
        public Book(string itemId, string title, double price) // : base(itemId)
		{
            ItemId = itemId;
            _title = title;	
			_price = price;
		}

		// Constructor overloading
		public Book(string itemId, string title) // : base(itemId)
		{
			ItemId = itemId;
			_title = title;
			// Default value
			_price = 0;

		}

		public Book(string itemId) // : base(itemId)
		{
			ItemId = itemId;
			// Default values
			_title = "";
			_price = 0;
		}

		public Book() 
		{
            // Default values
			
            _title = "";
            _price = 0;
        }

        // Override ToString() returs a formatted string of the values of the fields
        public override string ToString() 
		{
            // Gets ItemId from the base class
            return $"ItemId: {ItemId}, Title: {_title}, Price: {_price}";
		}

        public override double GetValue()
        {
            return _price;
        }

    }
}
