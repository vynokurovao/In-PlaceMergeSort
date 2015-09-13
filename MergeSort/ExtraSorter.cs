using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class ExtraSorter
    {
        private static void Swap(ref int[] array, int index1, int index2)
        {
            int tmp = array[index1];
            array[index1] = array[index2];
            array[index2] = tmp;
        }

        public static void BubbleSort(ref int[] arr, int arrayBegin, int arrayEnd)
        {
            for (int i = arrayBegin; i < arrayEnd; ++i)
            {
                for (int j = arrayBegin; j < arrayEnd; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr, j, j + 1);
                    }
                }
            }
        }

        public static void InsertSort(ref int[] array, int arrayBegin, int arrayEnd)
        {
            for (int i = arrayBegin + 1; i <= arrayEnd; ++i)
            {
                int tmp = array[i];
                int j = i - 1;
                while (j >= arrayBegin && array[j] > tmp)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = tmp;
            }
        }
    }
}
