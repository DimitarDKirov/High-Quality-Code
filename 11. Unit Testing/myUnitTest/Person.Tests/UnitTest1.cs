using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestedUnits;

namespace Persons.Tests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void Test_CreatePerson()
        {
            string name="Mitko";
            int age=33;

            var prsn = new Person(name, age);

            Assert.AreEqual(name, prsn.Name);
            Assert.AreEqual(age, prsn.Age);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_throwException()
        {
            string name="M";
            int age=33;

            var prsn = new Person(name, age);
        }
    }
}
