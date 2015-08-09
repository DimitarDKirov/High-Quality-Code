using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        int a = 0;
        [TestInitialize]
        public void Before()
        {
            a++;
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, 5);
        }
        [TestMethod]
        public void MyTestMethod()
        {
            Assert.AreEqual(5, 6, "my message Expect 5 to equal 5");
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MyTestMethod1()
        {
            var zero = 0;
            var res = 1 / zero;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MyTestMethod2()
        {
            var zero = 0;
            var res = 1 / zero;
        }

        [TestMethod]
        [Ignore]
        [Timeout(100)]
        public void MyTestMethod3()
        {
            while (true) ;
        }

        [TestMethod]
        public void MyTestMethod4()
        {
            Assert.AreEqual(a, 1);
        }

    }
}
