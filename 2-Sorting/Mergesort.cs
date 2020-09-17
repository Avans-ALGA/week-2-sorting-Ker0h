using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
    public class Mergesort
    {
        public static void mergesort(ISortList list)
        {
           if(list.Count <= 1) return;

            SortList left = new SortList();
            SortList right = new SortList();

            int mid = list.Count / 2;

            // Dividing the list
            for (int n = 0; n < mid; n++)
            {
                left[n] = list[n];
            }
            for(int n = mid; n < list.Count; n++)
            {
                right[n] = list[n];
            }

            left = mergesort(left);
            right = mergesort(right);


        }

        public static void mergesort(ISortList list, int leftIndex, int rightIndex)
        {
            throw new NotImplementedException();
        }
    }
}
