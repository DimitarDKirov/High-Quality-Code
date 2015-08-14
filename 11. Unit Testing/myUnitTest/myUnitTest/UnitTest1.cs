using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace myUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestCleanup]
        public void TestClaenup()
        { 
            Debug.WriteLine("Test claenup"); 
        }
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        { Debug.WriteLine("ClassInitialize"); }
        [ClassCleanup]
        public static void ClassCleanup()
        { Debug.WriteLine("class cleanup"); }
        int a = 0;
        [TestInitialize]
        public void Before()
        {
            Debug.WriteLine("test init");
            a++;
        }
        [TestMethod]
        public void TestMethod1()
        {
            Debug.WriteLine("test method");
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
