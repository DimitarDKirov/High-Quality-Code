using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolSystem;

namespace SchoolTests
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateStudentWithNullName_ExpectToThrow()
        {
            new Student(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateStudentWithlEmptyName_ExpectToThrow()
        {
            new Student(string.Empty);
        }

        [TestMethod]
        public void CreateStudent_StudentNumberIsInRange10000To99999()
        {
            Student student = new Student("Student");
            int studentNumber = student.Number;
            var isNumberValid = 10000 <= studentNumber && studentNumber <= 99999;
            Assert.IsTrue(isNumberValid);
        }

        [TestMethod]
        [Ignore]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]       
        public void Creating90000Students_ExpectToThrow()
        {
            for (int i = 0; i <= 89999; i++)
            {
                new Student("Name " + i);
            }

            new Student("Number 100000");
        }
    }
}
