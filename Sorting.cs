using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    class Sorting
    {
        protected int arraySize;
        protected int[] array;

        public virtual void changeArray() { }

        public void printArray()
        {
            for (int i = array.Length - arraySize; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }
        }
    }
}
