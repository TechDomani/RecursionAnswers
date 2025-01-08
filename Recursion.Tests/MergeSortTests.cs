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
		[TestMethod]
		public void TestMergeSortIterativeInt()
		{
			List<int> unsorted = [ 22, 55, 12, 22];
			List<int> expected = [ 12, 22, 22, 55];
			MergeSort<int> mergeSort = new ();
			CollectionAssert.AreEqual(expected, mergeSort.IterativeSort(unsorted));
		}

		
		[TestMethod]
		public void TestMergeSortIterativeString()
		{
			List<string> unsorted = [ "Jake", "Cape", "Apple" ];
			List<string> expected = [ "Apple", "Cape", "Jake" ];
			MergeSort<string> mergeSort = new ();
			CollectionAssert.AreEqual(expected, mergeSort.IterativeSort(unsorted));
		}

		[TestMethod]
		public void TestMergeSortRecursiveInt()
		{
			List<int> unsorted = [ 22, 55, 12, 22 ];
			List<int> expected = [ 12, 22, 22, 55 ];
			MergeSort<int> mergeSort = new();
			CollectionAssert.AreEqual(expected, mergeSort.RecursiveSort(unsorted));
		}


		[TestMethod]
		public void TestMergeSortRecursiveString()
		{
			List<string> unsorted = [ "Jake", "Cape", "Apple" ];
			List<string> expected = [ "Apple", "Cape", "Jake" ];
			MergeSort<string> mergeSort = new();
			CollectionAssert.AreEqual(expected, mergeSort.RecursiveSort(unsorted));
		}
	}


}
