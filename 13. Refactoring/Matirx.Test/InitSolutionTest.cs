using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrics;

namespace MatirxTest
{
    [TestClass]
    public class InitSolutionTest
    {
        private ConsoleForTests testingConsole;

        [TestInitialize]
        public void TestInit()
        {
            this.testingConsole = new ConsoleForTests();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MatrixSize_ExpectExceptionIfMatrixSizeIsNegative()
        {
            MatrixEngine matrix = new MatrixEngine(testingConsole, -2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MatrixSize_ExpectExceptionIfMatrixSizeIs0()
        {
            MatrixEngine matrix = new MatrixEngine(testingConsole, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MatrixSize_ExpectExceptionIfMatrixSizeIs101()
        {
            MatrixEngine matrix = new MatrixEngine(testingConsole, 101);
        }

        [TestMethod]
        public void Matrix_ExpextToBeCorrectOnSize3()
        {
            int size = 3;
            MatrixEngine matrix = new MatrixEngine(testingConsole, size);
            matrix.Run();
            matrix.PrintMatrix();
            string result = testingConsole.GetWriteText();
            string expected = "  1  7  8\n  6  2  9\n  5  4  3";
            Assert.AreEqual(expected, result, "Expected matrix 3x3");
        }

        [TestMethod]
        public void Matrix_ExpextToBeCorrectOnSize6()
        {
            int size = 6;
            MatrixEngine matrix = new MatrixEngine(testingConsole, size);
            matrix.Run();
            matrix.PrintMatrix();
            string result = testingConsole.GetWriteText();
            string expected = "  1 16 17 18 19 20\n 15  2 27 28 29 21\n 14 31  3 26 30 22\n 13 36 32  4 25 23\n 12 35 34 33  5 24\n 11 10  9  8  7  6";
            Assert.AreEqual(expected, result, "Expected matrix 6x6");
        }
    }
}
