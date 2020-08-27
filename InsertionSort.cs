using System;
using System.Text;

namespace Sorting_Algorithms
{
    class InsertionSort
    {
        private int[] array;
        private int arraySize;

        public InsertionSort(int arraySize, int[] array)
        {
            this.array = array;
            this.arraySize = arraySize;
        }

        public void changeArray()
        {
            int temp;

            for(int i=0;i<array.Length-1;i++)
            {
                for(int j=i+1;j>0;j--)
                {
                    if(array[j-1]>array[j])
                    {
                        temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            printArray();
        }

        public void printArray()
        {
            Console.WriteLine("Insetrioned array:\n");

            for(int i = array.Length-arraySize; i < array.Length; i++)
            {
                Console.WriteLine(array[i]+"\t");
            }
        }
    }
}
