using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursion.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.Tests
{
	[TestClass]
	public class MergeSortTests
	{

		[DataRow(new int[] { }, new int[] { })]
		[DataRow(new int[] { 4, 2, 7, 8 }, new int[] { 2, 4, 7, 8 })]
		[DataRow(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4})]
		[DataRow(new int[] { 22, 55, 12, 9, 8 }, new int[] { 9, 9, 12, 22, 55 })]
		[TestMethod]
		public void TestMergeSortIterativeInt(int[] input, int[] expected)
		{
			List<int> unsorted = input.ToList();
			MergeSort<int> mergeSort = new ();
			CollectionAssert.AreEqual(expected, mergeSort.IterativeSort(unsorted));
		}
	}


}
