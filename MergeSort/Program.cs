using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] actual = new int[200] ;

            for (int i = 0; i < 200; ++i)
            {
                actual[i] = random.Next(0, 1000);
            }

            MergeSorter.MergeSort(ref actual);
            foreach (int i in actual) 
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
