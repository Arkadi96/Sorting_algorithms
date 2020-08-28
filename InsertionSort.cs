using System;
using System.Text;

namespace Sorting_Algorithms
{
    class InsertionSort:Sorting
    {
        public InsertionSort(int arraySize, int[] array):base()
        {
            this.array = array;
            this.arraySize = arraySize;
        }

        public override void changeArray()
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
    }
}
