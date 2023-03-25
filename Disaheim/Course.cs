using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        // Auto-implemented properties
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

        public static double CourseHourValue = 875.0;

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
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }

        public double GetValue()
        {
            int durationInHours = DurationInMinutes / 60;
            double durationInMinutes = DurationInMinutes % 60;

            // Variable that holds the total value of the course
            double totalValue = 0;

            // If statements that adds the courseValuePerHour to Totalvalue
            if (durationInHours >= 0) {
                totalValue += (durationInHours * CourseHourValue);
            }
            // If statements that adds 1 courseValuePerHour to Totalvalue for a startet course hour
            if (durationInMinutes % 60 != 0) {
                totalValue += CourseHourValue;
            }

            return totalValue;
        }



    }
}
