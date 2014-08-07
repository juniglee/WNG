using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorldNomadsGroupTest
{
    [TestClass]
    public class WorldNomadsGroupTest
    {
        [TestMethod]
        public void TestSequence()
        {
            int input1 = 5;
            string expectedResults1 = "0, 1, 2, 3, 4, 5";

            int input2 = 20;
            string expectedResults2 = "0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20";

            Assert.AreEqual(expectedResults1, WorldNomadsGroup.WorldNomadsGroup.Sequence(input1).ToString());
            Assert.AreEqual(expectedResults2, WorldNomadsGroup.WorldNomadsGroup.Sequence(input2).ToString());
        }

        [TestMethod]
        public void TestOdd()
        {
            int input1 = 5;
            string expectedResults1 = "1, 3, 5";

            int input2 = 20;
            string expectedResults2 = "1, 3, 5, 7, 9, 11, 13, 15, 17, 19";

            Assert.AreEqual(expectedResults1, WorldNomadsGroup.WorldNomadsGroup.OddNumbers(input1).ToString());
            Assert.AreEqual(expectedResults2, WorldNomadsGroup.WorldNomadsGroup.OddNumbers(input2).ToString());
        }

        [TestMethod]
        public void TestEven()
        {
            int input1 = 5;
            string expectedResults1 = "0, 2, 4";

            int input2 = 20;
            string expectedResults2 = "0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20";

            Assert.AreEqual(expectedResults1, WorldNomadsGroup.WorldNomadsGroup.EvenNumbers(input1).ToString());
            Assert.AreEqual(expectedResults2, WorldNomadsGroup.WorldNomadsGroup.EvenNumbers(input2).ToString());
        }

        [TestMethod]
        public void TestMultiples()
        {
            int input1 = 5;
            string expectedResults1 = "0, 1, 2, fizz, 4";

            int input2 = 20;
            string expectedResults2 = "0, 1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizz buzz, 16, 17, fizz, 19";

            Assert.AreEqual(expectedResults1, WorldNomadsGroup.WorldNomadsGroup.MultiplesCheck(input1).ToString());
            Assert.AreEqual(expectedResults2, WorldNomadsGroup.WorldNomadsGroup.MultiplesCheck(input2).ToString());
        }

        [TestMethod]
        public void TestFibonacci()
        {
            int input1 = 5;
            string expectedResults1 = "0, 1, 1, 2, 3, 5";

            int input2 = 20;
            string expectedResults2 = "0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765";

            Assert.AreEqual(expectedResults1, WorldNomadsGroup.WorldNomadsGroup.Fibonacci(input1).ToString());
            Assert.AreEqual(expectedResults2, WorldNomadsGroup.WorldNomadsGroup.Fibonacci(input2).ToString());
        }
    }
}
