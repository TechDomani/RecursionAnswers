using System;
using Recursion.Classes;

namespace Recursion
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(string.Join(",", RecursionExercises.FirstNNumbers(4)));

            MergeSort<string> mergeSort = new ();
            List<string> toSort = new List<string> { "Hello", "Hard", "Apple" };
            List<string> sorted = mergeSort.IterativeSort(toSort);
			Console.WriteLine(string.Join(",", sorted));
		}
    }
}