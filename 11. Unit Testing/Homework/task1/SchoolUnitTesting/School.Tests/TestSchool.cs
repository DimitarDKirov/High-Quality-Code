using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolSystem;

namespace SchoolTest
{
    [TestClass]
    public class TestSchool
    {
        private School school;
        [TestInitialize]
        public void TestInitialise()
        {
            this.school = new School();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNullCourseThrows()
        {
            this.school.AddCourse(null);
        }

        [TestMethod]
        public void AddOneCourse_ExpectToBeStored()
        {
            Course course = new Course();
            this.school.AddCourse(course);
            Assert.AreEqual(1, this.school.Courses.Count, "Expect to have one course");
            Assert.AreSame(course, this.school.Courses[0], "Expect the stored course to be the same");
        }
    }
}
