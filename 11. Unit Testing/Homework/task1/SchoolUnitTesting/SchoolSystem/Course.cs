using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Course
    {
        private const int MaxNumberOfStudents = 30;
        private IList<Student> students;

        public Course()
        {
            this.students = new List<Student>(MaxNumberOfStudents);
        }

        public IList<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student to add can not be null");
            }

            if (this.students.Count == MaxNumberOfStudents)
            {
                throw new ArgumentException("The course is full");
            }

            this.students.Add(student);
        }

        public void ExcludeStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student to remove can not be null");
            }

            int index = this.students.IndexOf(student);

            if (index < 0)
            {
                throw new ArgumentException("The student is not signed the course");
            }

            this.students.RemoveAt(index);
        }
    }
}
