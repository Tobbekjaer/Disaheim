﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        // Fields
        private string _design;
        private Level _quality;

        // Properties
        public string Design
        {
            get { return _design; }
            set { _design = value; }
        }

        public Level Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        // Constructors
        // Step 1: base(itemId) explicitly calls the Merchandise class constructor
        // ItemId is a property found in the Merchandise class
        public Amulet(string itemId, Level quality, string design) //  : base(itemId)
        {
            ItemId = itemId;
            _quality = quality;
            _design = design;
        }

        // Constructor overloading
        public Amulet(string itemId, Level quality) // : base(itemId)
        {
            ItemId = itemId;
            _quality = quality;
            // Default value
            _design = "";
        }

        public Amulet(string itemId)  // : base(itemId)
        {
            ItemId = itemId;
            // Default values
            _quality = Level.medium;
            _design = "";
        }

        // Override ToString() returs a formatted string of the values of the fields
        public override string ToString()
        {
            // Gets ItemId from the base class
            return $"ItemId: {ItemId}, Quality: {_quality}, Design: {_design}";

        }
    }
}
