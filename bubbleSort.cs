using System;
using System.Text;

namespace Sorting_Algorithms
{
    class bubbleSort:Sorting
    { 
        public bubbleSort(int arraySize, int[] array):base()
        {
            this.arraySize = arraySize;
            this.array = array;
        }

        public override void changeArray()
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
    }
}
