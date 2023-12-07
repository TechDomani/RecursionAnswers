namespace Recursion.Classes
{
    public static class RecursionExercises
    {
        // 1. First N Numbers
        public static List<int> FirstNNumbers(int n)
        {
			if (n == 0)
				return new List<int>();

            int nextValue = n > 0 ? n - 1 : n + 1;
			List<int> numbers = FirstNNumbers(nextValue);
			numbers.Add(n);
			return numbers;
		}

        // 2. Split
        public static List<int> Split(int n)
        {
            if (n <= 0)
                return new List<int>();

            List<int> list = Split(n / 10);
            list.Add(n % 10);
            return list;
        }

		// 3. Is Prime
		public static bool IsPrime(int n, int factor = 2)
        {
			if (n < 2)
				return false;
			if (factor > Math.Sqrt(n))
				return true;
			if (n % factor == 0)
				return false;
			return IsPrime(n, factor + 1);
		}

        // 4a. Fibonacci Iterative
        public static List<int> FibonacciIterative(int n)
        {
			List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (i < 2)
                {
                    list.Add(i);
                }
                else
                {
                    int newValue = list[i - 1] + list[i-2];
                    list.Add(newValue);

                }
            }
            return list;
		}


        // 4b. Fibonacci Recursive
        public static List<int> FibonacciRecursive(int n)
        {
            if (n < 1)
                return new List<int>();
			if (n == 1)
				return new List<int> { 0 };
			if (n == 2)
				return new List<int> { 0, 1 };
			List<int> list = FibonacciRecursive(n - 1);
            int nextValue = list[list.Count - 1] + list[list.Count - 2];

			list.Add(nextValue);
			return list;
		}

       



        
    }
}
