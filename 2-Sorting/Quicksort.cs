using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
    public class Quicksort
    {
        public static void quicksort(ISortList list)
        {
            if (list.Count < 1) return;
            quicksort(list, 0, list.Count - 1);
        }

        private static void quicksort(ISortList list, int leftIndex, int rightIndex)
        {
            if(leftIndex < rightIndex)
            {
                int pivotIndex = (leftIndex + rightIndex) / 2;
                pivotIndex = partition(list, pivotIndex, leftIndex, rightIndex);

                // quicksort right side
                quicksort(list, pivotIndex + 1, rightIndex);

                // quicksort left side
                quicksort(list, leftIndex, pivotIndex - 1);

            }
        }

        /**
         * Partition the list according to the value at the pivot index
         * This method should only partition the part of the array that is between startIndex and endIndex
         * All values lower than the pivot value should be to the left of the pivot value
         * and all values higher than the pivot value should be to the right of the pivot value
         * 
         * This method should return the position of the pivot value after partitioning is complete
         * 
         * For example: partition([4, 9, 5, 0, 2], 2, 0, 4)
         * should partition the values between indices 0...4 (inclusive) using the value 5 as the pivot
         * A possible partitioning would be: [2, 0, 4, 5, 9], this method should return 3 as that is where
         * the pivot value 5 has ended up.
         * This method may assume there are no equal values
         */
        public static int partition(ISortList list, int pivotIndex, int leftIndex, int rightIndex)
        {
            Console.WriteLine(list.ToString());

            // Swap pivot to the end of the array
            list.swap(pivotIndex, list.Count - 1);
            pivotIndex = list.Count - 1;
            rightIndex--;

            Console.WriteLine(list.ToString());

            while(rightIndex > leftIndex)
            {

                // Search on the left for number > pivot
                while (leftIndex < list.Count - 1)
                {
                    Console.WriteLine("Left Value: " + list[leftIndex]);

                    if(list.compare(leftIndex, pivotIndex) > 0)
                    {
                        break;
                    } else
                    {
                        leftIndex++;
                    }

                }

                // Search on the right for number < pivot
                while (rightIndex >= leftIndex)
                {

                    Console.WriteLine("Right Value: " + list[rightIndex]);

                    if (list.compare(rightIndex, pivotIndex) < 0)
                    {
                        list.swap(leftIndex, rightIndex);
                        Console.WriteLine("Swap: " + list.ToString());
                        break;
                    }
                    else
                    {
                        rightIndex--;
                    }
                }
            }

          
            // Swap pivot back in place of current leftIndex
            list.swap(leftIndex, pivotIndex);

            Console.WriteLine("Pivot Index " + leftIndex);
            Console.WriteLine("Result: " + list.ToString());

            return leftIndex;

        }

    }
}
