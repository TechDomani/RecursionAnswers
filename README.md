## Recursion</br>

### Intro
You must use recursion to solve all these problems unless instructed otherwise even if it would be easier to write them in a different way</br>
There are stub functions in Recursion.Classes.RecursionExercise.cs and Recursion.Classes.MergeSort.cs</br>

### Testing
Some tests have already been written</br>
You should make sure that these pass before submitting your work</br>
You should make sure that every function you write has sufficient tests</br>
In addition you can do manual testing by calling your functions from main in Program.cs</br>

### 1. First N Numbers
Create a function to return a list containing the first n integers</br>
So if n is 5 it will return { 1, 2, 3, 4, 5}</br>
Extend the function to count negatively if the input is negative.</br>
So if n is -5 it will return {-1, -2, -3, -4, -5}</br>

### 2. Split
Write a function to return a list of the individual digits of a given positive integer (in a List).</br>
So if the input is 46352 it will return {4, 6, 3, 5, 2}</br>
Note that (/) by 10 will remove the least significant digit (126 / 10 is 12)</br>
Mod (%) by 10 will give the least significant digit (126 % 10 is 6)</br>
If the integer is negative it should return an empty list</br>

### 3. Is Prime
Write a function that returns a Boolean saying whether a given integer is prime or not using recursion.</br>
So if the input is 14 it will return False, if the input is 17 it will return True etc.</br>

### 4. Fibonacci
Write a function to return a list of the first n Fibonacci numbers for a given integer.</br>
a) Write it iteratively</br>
b) Write it recursively</br>
In the Fibonacci sequence, each number is found by adding the two preceding numbers<br>
So if n is 8 it will return {0, 1, 1, 2, 3, 5, 8, 13}</br>

### 5. Merge Sort
This algorithm is often written recursively. Implement the code in MergeSort.cs.</br>
a) Write the classic recursive implementation</br>
b) Write an iterative version of merge sort. Use a queue to help you to do this easily.</br>
Don't worry about writing your own queue this time. The built in Queue<T> class will work fine.</br>
Start by enqueuing a list for every data item in the input list</br>
Dequeue the first two lists and merge them</br>
Then enqueue the merged list</br>
Continue until there is only one item left in the queue</br>
This will be the fully sorted data</br>
