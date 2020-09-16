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
           if(list.Count <= 1)
           {
                return;
           }

            SortList x = new SortList();
            SortList y = new SortList();
            int mid = list.Count / 2;

            // Dividing the list
            for (int n = 0; n < mid; n++)
            {
                y[n] = list[n];
            }
        }
        public static void mergesort(ISortList list, int leftIndex, int rightIndex)
        {
            throw new NotImplementedException();
        }
    }
}
