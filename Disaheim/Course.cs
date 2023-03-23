using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course
    {
        // Auto-implemented properties
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

        // Constructor chain
        public Course (string name)
        {
            Name = name;

            DurationInMinutes = 0;
        }

        public Course (string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }

        // Override string implementation
        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }



    }
}
