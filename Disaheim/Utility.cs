using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;

namespace Disaheim
{
    public class Utility
    {
        private double _lowQualityValue = 12.5;

        public double LowQualityValue
        {
            get { return _lowQualityValue; }
            set { _lowQualityValue= value; }
        }

        private double _mediumQualityValue = 20.0;

        public double MediumQualityValue
        {
            get { return _mediumQualityValue; }
            set { _mediumQualityValue = value; }
        }

        private double _highQualityValue = 27.5;

        public double HighQualityValue
        {
            get { return _highQualityValue; }
            set { _highQualityValue = value; }
        }

        private double _courseHourValue = 875.0;

        public double CourseHourValue
        {
            get { return _courseHourValue ; }
            set { _courseHourValue = value; }
        }



        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            double value = 0;
            
            if(merchandise is Book) {
                Book book = (Book)merchandise;
                value = book.Price;

            }else if(merchandise is Amulet) {
                Amulet amulet = (Amulet)merchandise;
  
                switch (amulet.Quality) {
                    case Level.low:
                        value = _lowQualityValue;
                        break;
                    case Level.medium:
                        value = _mediumQualityValue;
                        break;
                    case Level.high:
                        value = _highQualityValue;
                        break;
                }

            }
            return value;

        }


        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        // Returns the value of the amulet depending on it's quality
        public double GetValueOfAmulet(Amulet amulet)
        {
            double value = 0;
            switch (amulet.Quality) {
                case Level.low:
                    value = _lowQualityValue;
                    break;
                case Level.medium:
                    value = _mediumQualityValue;
                    break;
                case Level.high:
                    value = _highQualityValue;
                    break;
            }
            return value;
        }

        public double GetValueOfCourse(Course course)
        {
  
            int durationInHours = course.DurationInMinutes / 60;
            double durationInMinutes = course.DurationInMinutes % 60;

            // Variable that holds the total value of the course
            double totalValue = 0;

            // If statements that adds the courseValuePerHour to Totalvalue
            if (durationInHours >= 0) {
                totalValue += (durationInHours * _courseHourValue);
            }
            // If statements that adds 1 courseValuePerHour to Totalvalue for a startet course hour
            if (durationInMinutes % 60 != 0) {
                totalValue += _courseHourValue;
            }

            return totalValue;

        }
    }
}
