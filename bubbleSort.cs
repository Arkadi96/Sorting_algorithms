using System;
using System.Text;

namespace Sorting_Algorithms
{
    class bubbleSort
    {
        private int[] array;
        private int arraySize;

        public bubbleSort(int arraySize, int[] array)
        {
            this.arraySize = arraySize;
            this.array = array;
        }

        public void changeArray()
        {
            int temp;
            int ciclesCount = array.Length;

            while (ciclesCount != 0)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
                ciclesCount--;
            }

            printArray();
        }

        public void printArray()
        {
            Console.WriteLine("bubbleSort array:\n");

            for (int i = array.Length - arraySize; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }
        }

    }
}
