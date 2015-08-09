using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolSystem;

namespace SchoolTests
{
    [TestClass]
    public class TestCourse
    {
        private Course course;
        [TestInitialize]
        public void InitializeTest()
        {
            this.course = new Course();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNullStudent_ExpectToThrow()
        {
            this.course.AddStudent(null);
        }

        [TestMethod]
        public void AddStudent_ExpectToBeAdded()
        {
            Student student = new Student("Mitko");
            this.course.AddStudent(student);
            Assert.AreEqual(1, this.course.Students.Count, "The course should have one student added");
            Assert.AreSame(student, this.course.Students[0], "The student must be added");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Add31Students_ExpectToThrow()
        {
            Course course31 = new Course();
            for (int i = 0; i <= 30; i++)
            {
                course31.AddStudent(new Student("Student" + i));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveNullStudent_ExpectToThrow()
        {
            this.course.ExcludeStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveUnknownStudent_ExpectToThrow()
        {
            Student unknown = new Student("Unknown");
            this.course.ExcludeStudent(unknown);
        }

        [TestMethod]
        public void ExcludeStudent_ExpectToBeRemoved()
        {
            Student someStudent = new Student("Student");
            this.course.AddStudent(someStudent);
            Assert.IsTrue(this.course.Students.IndexOf(someStudent) >= 0, "The test student should be added to the course");
            this.course.ExcludeStudent(someStudent);
            Assert.IsTrue(this.course.Students.IndexOf(someStudent) < 0, "The test student must be removed from the course");
        }
    }
}
