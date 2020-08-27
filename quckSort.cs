using System;
using System.Text;

namespace Sorting_Algorithms
{
    class quckSort
    {
        private int[] array;
        private int arraySize;
        private int beg, end, pivotLoc;

        public quckSort(int arraySize,int[] array)
        {
            this.arraySize = arraySize;
            this.array = array;
            beg = 0;
            end = array.Length-1;
            quickSort(beg, end);
        }

        public void quickSort(int beg,int end)
        {

            if(beg<end)
            {
                partitionArray(ref beg,ref end,ref pivotLoc);
                quickSort(beg,pivotLoc-1);
                quickSort(pivotLoc + 1,end);
               
                
            }
            
        }

        private void partitionArray(ref int beg,ref int end,ref int pivotLoc)
        {
            int left = beg;
            int right = end;
            pivotLoc = left;
            int tmp;

            while (true)
            {
                while(array[pivotLoc]<=array[right] && pivotLoc != right)
                {
                    right--;
                }

                if (pivotLoc == right)
                {
                    break;
                }else if (array[pivotLoc] > array[right])
                {
                    tmp = array[right];
                    array[right] = array[pivotLoc];
                    array[pivotLoc] = tmp;
                    pivotLoc = right;
                }

                while (array[pivotLoc] >= array[left] && pivotLoc != left)
                {   
                    left++; 
                }

                if (pivotLoc == left)
                {   
                    break;
                }
                else if (array[pivotLoc] < array[left])
                {
                    
                    tmp = array[left];
                    array[left] = array[pivotLoc];
                    array[pivotLoc] = tmp;
                    pivotLoc = left;   
                }
            }
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
