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
                int calls = 0;
                int pivotIndex = (leftIndex + rightIndex) / 2;
                pivotIndex = partition(list, pivotIndex, leftIndex, rightIndex);

                calls++;

                // quicksort right side
                Console.WriteLine("Quicksort RIGHT: " + calls);
                quicksort(list, pivotIndex + 1, rightIndex);

                // quicksort left side
                Console.WriteLine("Quicksort LEFT: " + calls);
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
            int l = leftIndex;
            int r = rightIndex;
            int p = pivotIndex;

            // Swap pivot to the back
            list.swap(p, list.Count - 1);
            p = list.Count - 1;
            Console.WriteLine("NEW PARTITION\nPivot at the end " + list.ToString());

            // Skip pivot
            r--;
            Console.WriteLine("R: " + list[r]);
            Console.WriteLine("P: " + list[p]);

            // Partitioning
            Console.WriteLine("Partioning: " + l + " to " + r);
            while (l < r)
            {
                Console.WriteLine("Left value " + list[l]);

                // Search on the left side for value > pivot
                while (list.compare(l, p) < 0 && l < r) 
                { 
                    l++;
                    Console.WriteLine("Left value " + list[l]);
                }

                Console.WriteLine("Right value " + list[r]);

                // Search on the right side for value < pivot
                while (list.compare(r, p) > 0 && r > l)
                {
                    r--;
                    Console.WriteLine("Right value " + list[r]);
                }

                // Swap found values
                if(list.compare(l, r) > 0)
                {
                    Console.WriteLine("Swapped: " + list[l] + " and " + list[r]);
                    list.swap(l, r);
                }
            }

            list.swap(p, l);


            Console.WriteLine("Swapped pivot back in place: " + list.ToString() + "\n" + "New pivot: " + list[l] + "\n");
                        
            return l;
        }

    }
}
