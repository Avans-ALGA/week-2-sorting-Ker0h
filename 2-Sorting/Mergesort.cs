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
            if(leftIndex < rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;

                // Divide both halves
                mergesort(list, leftIndex, middleIndex);
                mergesort(list, middleIndex + 1, rightIndex);

                merge(list, leftIndex, middleIndex, rightIndex);
            }
        }


        public static void merge(ISortList list, int leftIndex, int middleIndex, int rightIndex)
        {
            int leftSubIndex, rightSubIndex, mergedSubindex;
            int leftSubSize = middleIndex - leftIndex + 1;
            int rightSubSize = rightIndex - middleIndex;

            // Temporary lists
            ISortList left = new SortList(leftSubSize);
            ISortList right = new SortList(rightSubSize);

            // Copy data into temp. lists
            for (leftSubIndex = 0; leftSubIndex < leftSubSize; leftSubIndex++)
            {
                left[leftSubIndex] = list[leftIndex + leftSubIndex];
            }

            for (rightSubIndex = 0; rightSubIndex < rightSubSize; rightSubIndex++)
            {
                right[rightSubIndex] = list[middleIndex + 1 + rightSubIndex];
            }

            // Merge temp. lists  back into original
            leftSubIndex = 0;
            rightSubIndex = 0;
            mergedSubindex = leftIndex;

            while (leftSubIndex < leftSubSize && rightSubIndex < rightSubSize)
            {
                if(left[leftSubIndex] <= right[rightSubIndex])
                {
                    list[mergedSubindex] = left[leftSubIndex];
                    leftSubIndex++;
                }
                else
                {
                    list[mergedSubindex] = right[rightSubIndex];
                    rightSubIndex++;
                }
                mergedSubindex++;
            }

            // Copy any remainders from the left list
            while(leftSubIndex < leftSubSize)
            {
                list[mergedSubindex] = left[leftSubIndex];
                leftSubIndex++;
                mergedSubindex++;
            }

            // Copy any remainders from the right list
            while (rightSubIndex < rightSubSize)
            {
                list[mergedSubindex] = right[rightSubIndex];
                rightSubIndex++;
                mergedSubindex++;
            }
        }
    }
}
