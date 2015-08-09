using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class School
    {
        private IList<Course> courses;

        public School()
        {
            this.courses = new List<Course>();
        }

        public IList<Course> Courses
        {
            get { return this.courses; }
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course can not be null");
            }

            this.courses.Add(course);
        }
        
    }
}
