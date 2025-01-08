using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.Classes
{
	public class MergeSort<T> where T : IEquatable<T>, IComparable<T>
	{
		public List<T> IterativeSort(List<T> unsorted)
		{			
			if (unsorted == null || unsorted.Count == 0) { 
				return [];
			}
			Queue<List<T>> queue = new();
			foreach (T item in unsorted)
			{
				queue.Enqueue([ item ]);
			}
			while (queue.Count > 1)
			{
				List<T> leftList = queue.Dequeue();
				List<T> rightList = queue.Dequeue();
				List<T> merged = Sort(leftList, rightList);
				queue.Enqueue(merged);
			}
			return queue.Dequeue();
		}


		public List<T> RecursiveSort(List<T> unsorted)
		{
			if (unsorted.Count <= 1)
			{
				return unsorted;
			}
			int mid = unsorted.Count / 2;
			List<T> leftList = RecursiveSort(unsorted.Take(mid).ToList());
			List<T> rightList = RecursiveSort(unsorted.Skip(mid).ToList());
			return Sort(leftList, rightList);
		}
		private static List<T> Sort(List<T> leftList, List<T> rightList)
		{
			List<T> merged = [];
			int leftPos = 0;
			int rightPos = 0;
			while (leftPos < leftList.Count && rightPos < rightList.Count) // Compare items
			{
				if (leftList[leftPos].CompareTo(rightList[rightPos]) < 0)
				{
					merged.Add(leftList[leftPos]);
					leftPos += 1;
				}
				else
				{
					merged.Add(rightList[rightPos]);
					rightPos += 1;
				}
			}
			while (leftPos < leftList.Count) // Move remaining items on left into the sorted list
			{
				merged.Add(leftList[leftPos]);
				leftPos += 1;
			}
			while (rightPos < rightList.Count) // Move remaining items on right into the sorted list
			{
				merged.Add(rightList[rightPos]);
				rightPos += 1;
			}
			return merged;
		}
	}
}
