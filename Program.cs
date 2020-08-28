using System;
using System.Text;
using System.Diagnostics;

namespace Sorting_Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            //time settings
            Stopwatch watch;
            watch = new Stopwatch();

            int arraySize, algNumb;
            int[] array = new int[10];
            bool allSortAlgActivated = false;
            double elapsedInsert = 0, elapsedBubble = 0, elapsedQuick = 0;

            Random random = new Random();


            //declaring size of array
            do {Console.WriteLine("Please enter the size of an array that you want to sort: (minimum size is 4 and max is 10)"); arraySize = int.Parse(Console.ReadLine());}
            while (arraySize<5||arraySize>10);

            //initialize elements of array n with random numbers
            for (int i=0;i<arraySize;i++)
            {
               array[i] = random.Next(100);
            }

            //declaring what algorithm the user wants to perform:
            do {Console.WriteLine("Select which algorithm you want to perform:\n1. Insertion sort\n2. Bubble sort\n3. Quick sort\n4. Heap sort\n5. Merge sort\n6. All"); algNumb = int.Parse(Console.ReadLine());} 
            while (algNumb < 1 || algNumb > 6);

            //creating specific class objets
            switch (algNumb)
            {
                case 1:
                    watch.Start();
                    InsertionSort obj1 = new InsertionSort(arraySize, array);
                    obj1.changeArray();
                    watch.Restart();
                    Console.WriteLine("Total bytes alloceted {0}", GC.GetTotalMemory(true));
                    Console.WriteLine("Speed: "+ watch.Elapsed.TotalMilliseconds);
                    GC.GetTotalMemory(false);
                    break;

                case 2:
                    watch.Start();
                    bubbleSort obj2 = new bubbleSort(arraySize, array);
                    obj2.changeArray();
                    watch.Restart();
                    Console.WriteLine("Total bytes alloceted {0}", GC.GetTotalMemory(true));
                    Console.WriteLine("Speed: " + watch.Elapsed.TotalMilliseconds);
                    GC.GetTotalMemory(false);
                    break;

                case 3:
                    watch.Start();
                    quckSort obj3 = new quckSort(arraySize, array);
                    obj3.changeArray();
                    watch.Restart();
                    Console.WriteLine("Total bytes alloceted {0}", GC.GetTotalMemory(true));
                    Console.WriteLine("Speed: " + watch.Elapsed.TotalMilliseconds);
                    GC.GetTotalMemory(false);
                    break;

                case 4:
                    Console.WriteLine("Error 404. page is under maintenance");
                    break;

                case 5:
                    Console.WriteLine("Error 404. page is under maintenance");
                    break;

                case 6:
                    allSortAlgActivated = true;
                    watch.Start();
                    InsertionSort ob1 = new InsertionSort(arraySize, array);
                    ob1.changeArray();
                    elapsedInsert = watch.Elapsed.TotalMilliseconds;
                    Console.WriteLine("Total bytes alloceted {0}", GC.GetTotalMemory(true));
                    Console.WriteLine("Speed: {0}",elapsedInsert);
                    GC.GetTotalMemory(false);

                    watch.Restart();
                    bubbleSort ob2 = new bubbleSort(arraySize, array);
                    ob2.changeArray();
                    elapsedBubble = watch.Elapsed.TotalMilliseconds;
                    Console.WriteLine("Total bytes alloceted {0}", GC.GetTotalMemory(true));
                    Console.WriteLine("Speed: {0}",elapsedBubble);
                    GC.GetTotalMemory(false);

                    watch.Restart();
                    quckSort ob3 = new quckSort(arraySize, array);
                    ob3.changeArray();
                    elapsedQuick = watch.Elapsed.TotalMilliseconds;
                    Console.WriteLine("Total bytes alloceted {0}", GC.GetTotalMemory(true));
                    Console.WriteLine("Speed: {0}", elapsedQuick);
                    GC.GetTotalMemory(false);
                    break;
            }

            if (allSortAlgActivated) 
            {
                //creating array with elapsed times and their names
                string[] strNames = { "Insertion Sort", "bubble Sort", "quick Sort" };
                double[] arraySpeed = { elapsedInsert, elapsedBubble, elapsedQuick };

                //finding the fastest sort algorithm
                int index = 0;

                for (int i = 1; i < 3; i++)
                {
                    if (arraySpeed[index] > arraySpeed[i]) index = i;
                }

                //printing out the fastest sort algorithm name and elapsed time in ms
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(strNames[index] + " is the fastest: " + arraySpeed[index] + " ms");
            }

            Console.ReadLine();
        }
    }
}
