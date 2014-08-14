using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldNomadsGroup;

namespace WorldNomadsGroupTest
{
    [TestClass]
    public class WorldNomadsGroupTest
    {
        [TestMethod]
        public void TestSequence()
        {
            Calculator calculator = new Calculator();

            int input1 = 5;
            string expectedResults1 = "0, 1, 2, 3, 4, 5";

            int input2 = 20;
            string expectedResults2 = "0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20";

            Assert.AreEqual(expectedResults1, calculator.GetIncrementalSequence(input1).ToString());
            Assert.AreEqual(expectedResults2, calculator.GetIncrementalSequence(input2).ToString());
        }

        [TestMethod]
        public void TestOdd()
        {
            Calculator calculator = new Calculator();

            int input1 = 5;
            string expectedResults1 = "1, 3, 5";

            int input2 = 20;
            string expectedResults2 = "1, 3, 5, 7, 9, 11, 13, 15, 17, 19";

            Assert.AreEqual(expectedResults1, calculator.GetOddNumbersSequence(input1).ToString());
            Assert.AreEqual(expectedResults2, calculator.GetOddNumbersSequence(input2).ToString());
        }

        [TestMethod]
        public void TestEven()
        {
            Calculator calculator = new Calculator();

            int input1 = 5;
            string expectedResults1 = "0, 2, 4";

            int input2 = 20;
            string expectedResults2 = "0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20";

            Assert.AreEqual(expectedResults1, calculator.GetEvenNumbersSequence(input1).ToString());
            Assert.AreEqual(expectedResults2, calculator.GetEvenNumbersSequence(input2).ToString());
        }

        [TestMethod]
        public void TestMultiples()
        {
            Calculator calculator = new Calculator();

            int input1 = 5;
            string expectedResults1 = "0, 1, 2, fizz, 4";

            int input2 = 20;
            string expectedResults2 = "0, 1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizz buzz, 16, 17, fizz, 19";

            Assert.AreEqual(expectedResults1, calculator.CheckMultiplesThreeAndFive(input1).ToString());
            Assert.AreEqual(expectedResults2, calculator.CheckMultiplesThreeAndFive(input2).ToString());
        }

        [TestMethod]
        public void TestFibonacci()
        {
            Calculator calculator = new Calculator();

            int input1 = 5;
            string expectedResults1 = "0, 1, 1, 2, 3, 5";

            int input2 = 20;
            string expectedResults2 = "0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765";

            Assert.AreEqual(expectedResults1, calculator.GetFibonacciSequence(input1).ToString());
            Assert.AreEqual(expectedResults2, calculator.GetFibonacciSequence(input2).ToString());
        }
    }
}
