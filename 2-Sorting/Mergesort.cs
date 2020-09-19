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

            mergesort(list, 0, list.Count - 1);
        }

        public static void mergesort(ISortList list, int leftIndex, int rightIndex)
        {
            Console.WriteLine(list.ToString());
            divide(list);
        }

        public static ISortList divide(ISortList list)
        {
            if (list.Count <= 1) return list;

            ISortList left = new SortList();
            ISortList right = new SortList();

            int middle = list.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left[i] = list[i];
            }

            for (int i = middle; i < list.Count; i++)
            {
                right[i] = list[i];
            }

            left = divide(left);
            right = divide(right);

            Console.WriteLine(left.ToString());
            return null;
        }

        public static void merge(ISortList left, ISortList right)
        {
            
        }
    }
}
