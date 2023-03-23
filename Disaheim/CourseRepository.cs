using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository 
    {
		private List<Course> _courses = new List<Course>();

		public List<Course> Courses
		{
			get { return _courses; }
			set { _courses = value; }
		}

		public void AddCourse(Course course)
		{
			_courses.Add(course);
		}

		public Course GetCourse(string name)
		{
            Course course1 = null;
            foreach (Course course in _courses) {
                if (course.Name == name) {
                    course1 = course;
                }
            }

            return course1;
        }

        public double GetTotalValue()
        {
            double price = 0;
            foreach (Course course in _courses) {
                var utility = new Utility();
                price += utility.GetValueOfCourse(course);
                
            }

            return price;
        }


    }
}
