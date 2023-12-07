using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursion.Classes;

namespace Recursion.Tests
{
    [TestClass]
    public class RecursionExerciseTests
    {
		[TestMethod]
		[DataRow(0, new int[] { })]
		[DataRow(1, new int[] { 1 })]
		[DataRow(5, new int[] { 1, 2, 3, 4, 5 })]
		[DataRow(10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10})]
		[DataRow(-1, new int[] { -1 })]
		[DataRow(-5, new int[] { -1, -2, -3, -4, -5 })]
		[DataRow(-10, new int[] { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 })]
		public void TestFirstNNumbers(int input, int[] expected)
        {
            CollectionAssert.AreEqual(expected, RecursionExercises.FirstNNumbers(input));
        }

        [TestMethod]
		[DataRow(0, new int[] { })]
		[DataRow(1, new int[] { 1 })]
		[DataRow(-1, new int[] { })]
		[DataRow(10, new int[] { 1, 0 })]
		[DataRow(-10, new int[] { })]
		[DataRow(123874, new int[] { 1,2,3,8,7,4 })]
		[DataRow(9998271, new int[] { 9,9,9,8,2,7,1})]
		public void TestSplit(int input, int[] expected)
        {
            CollectionAssert.AreEqual(expected, RecursionExercises.Split(input));
        }

        [DataRow (1, false)]
		[DataRow(-1, false)]
		[DataRow(0, false)]
		[DataRow(2, true)]
		[DataRow(99, false)]
		[DataRow(1823, true)]
		[DataRow(1824, false)]
		[TestMethod]
        public void TestPrime(int input, bool expected)
        {
            Assert.AreEqual(expected, RecursionExercises.IsPrime(input));
        }

       
		[DataRow(-1, new int[] { })]
		[DataRow(0, new int[] { })]
		[DataRow(1, new int[] { 0 })]
		[DataRow(2, new int[] { 0, 1})]
		[DataRow(3, new int[] { 0, 1, 1 })]
		[DataRow(4, new int[] { 0, 1, 1, 2 })]
		[DataRow(20, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181})]
		[TestMethod]
		public void TestFibonacciIterative(int input, int[] expected)
        {
            CollectionAssert.AreEqual(expected, RecursionExercises.FibonacciIterative(input));
        }


		[TestMethod]
		[DataRow(-1, new int[] { })]
		[DataRow(0, new int[] { })]
		[DataRow(1, new int[] { 0 })]
		[DataRow(2, new int[] { 0, 1 })]
		[DataRow(3, new int[] { 0, 1, 1 })]
		[DataRow(4, new int[] { 0, 1, 1, 2 })]
		[DataRow(20, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181 })]
		public void TestFibonacciRecursive(int input, int[] expected)
        {
            CollectionAssert.AreEqual(expected, RecursionExercises.FibonacciRecursive(input));
        }
    }
}
