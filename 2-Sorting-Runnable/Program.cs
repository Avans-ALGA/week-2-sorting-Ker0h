using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
    class Program
    {
        static void Main(string[] args)
        {
            SortList list = new SortList(50);
            Quicksort.quicksort(list);
            // Mergesort.mergesort(list);
            Console.WriteLine("Result: " + list);
            Console.ReadLine();
        }
    }
}
