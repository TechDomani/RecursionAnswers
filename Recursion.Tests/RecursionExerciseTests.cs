using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Recursion.Classes;

namespace Recursion.Tests
{
    [TestClass]
    public class RecursionExerciseTests
    {
        [TestMethod]
        public void TestFirstNPositive()
        {
            CollectionAssert.AreEqual(new List<int>(), RecursionExercise.FirstNNumbers(0));
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5 }, RecursionExercise.FirstNNumbers(5));
        }

        [TestMethod]
        public void TestFirstNNegative()
        {
            CollectionAssert.AreEqual(new List<int> { -1, -2, -3, -4, -5 }, RecursionExercise.FirstNNumbers(-5));
        }

        [TestMethod]
        public void TestSplit()
        {
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5 }, RecursionExercise.Split(12345));
            CollectionAssert.AreEqual(new List<int> { 3, 7, 0, 9, 4 }, RecursionExercise.Split(37094));
        }

        [TestMethod]
        public void TestPrime()
        {
            Assert.IsFalse(RecursionExercise.IsPrime(1));
            Assert.IsFalse(RecursionExercise.IsPrime(100));
            Assert.IsTrue(RecursionExercise.IsPrime(2));
            Assert.IsTrue(RecursionExercise.IsPrime(17));
        }

        [TestMethod]
        public void TestFibonacciIterative()
        {
            CollectionAssert.AreEqual(new List<int> { 0, 1, 1, 2, 3, 5 }, RecursionExercise.FibonacciA(6));
        }

        [TestMethod]
        public void TestFibonacciRecursive()
        {
            CollectionAssert.AreEqual(new List<int> { 0, 1, 1, 2, 3, 5, 8 }, RecursionExercise.FibonacciB(7));

        }
    }
}
