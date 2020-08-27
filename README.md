# assignment-3
Sorting Algorithms
Implement the following sorting algorithms in separate classes that will have Sort method for sorting a given N size array:
• Insertion sort
• Bubble sort
• Merge sort
• Quick sort (optional)
• Heap sort (optional)

The Sort method might return new ordered array or the same array with ordered elements depending on algorithm’s classification. The user will be asked to enter size of an array that he/she wants to sort. For a given number the program should generate an array with random numbers. Then the program will prompt the user to choose the algorithm he/she wants to apply for sorting generated array. User can enter the following combinations:

• number of sorting algorithm for example, if user enters “2”, that means sorting algorithm #2 will be applied
• several sorting options can be selected by entering range of numbers for example, “1-4” means #1, #2, #3, #4 sorting algorithms will be applied “1-2” means #1 and #2 sorting algorithms will be applied
• several sorting options can be selected by entering their numbers separated by comma
for example, “1,3” means #1 and #3 sorting algorithms will be applied
• there should be option for selecting all algorithms, which will run all algorithms on an array
Make sure to pass the original array (copy of the array, not already sorted array) to each class’s sort function.
For each sorting algorithm the running time and used memory should be calculated and printed out on the console. For a given array the fastest algorithm results should be printed out in green color.
You might need to use the following classes: System.Random for random numbers generation; System.Diagnostics.Stopwatch for measuring elapsed time; System.GC for getting memory usage, mainly GC.GetTotalMemory(bool) can be used; or any other methods you find suitable to use.

This is an example how the output may look like:
===============================================
Please enter the size of an array that you want to sort:
<user enters a number(N) which is the size of an array>
Select which algorithm you want to perform:
1. Insertion sort
2. Bubble sort
3. Quick sort
4. Heap sort
5. Merge sort
6. All
<User selects the number of an algorithm he/she wants to perform>
<name of the selected algorithm>
Running time: <running time of chosen sorting algorithm>
Memory usage: <how much memory is used while sorting an array>
