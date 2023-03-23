using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;

namespace UtilityLib
{
    public class Utility
    {
        
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        // Returns the value of the amulet depending on it's quality
        public double GetValueOfAmulet(Amulet amulet)
        {
            double value = 0;
            switch(amulet.Quality) {
                case Level.low:
                    value = 12.5;
                    break;
                case Level.medium:
                     value = 20.0;
                    break;
                case Level.high:
                    value = 27.5;
                    break; 
            }
            return value;
        }

        public double GetValueOfCourse(Course course)
        { 
            double courseValuePerHour = 875;
            int durationInHours = course.DurationInMinutes / 60;
            double durationInMinutes = course.DurationInMinutes % 60;

            // Variable that holds the total value of the course
            double totalValue = 0;

            // If statements that adds the courseValuePerHour to Totalvalue
            if (durationInHours >= 0) {
                 totalValue += (durationInHours * courseValuePerHour);
            }
            // If statements that adds 1 courseValuePerHour to Totalvalue for a startet course hour
            if (durationInMinutes%60 != 0) {
                totalValue += courseValuePerHour;
            }

            return totalValue;
      
        }

    }
}
