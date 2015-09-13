namespace MergeSort
{
    public class MergeSorter
    {
        private const int MinChunkSize = 15;

        public static void MergeSort(ref int[] array)
        { 
            PreSort(ref array);

            int chunkSize = MinChunkSize;
            int arrayLength = array.Length;

            while (chunkSize < arrayLength)
            {
                int count = 0;
                if (arrayLength % chunkSize == 0)
                {
                    count = arrayLength / chunkSize;
                }
                else
                {
                    count = arrayLength / chunkSize + 1;
                }

                for (int i = 0; i < count; i += 2)
                {
                    if (i == count - 1)
                    {
                        break;
                    }
                    if (i == count - 2)
                    {
                        MergeInPlace(ref array, chunkSize * i, chunkSize * (i + 1), arrayLength - 1);
                    }
                    else
                    {
                        MergeInPlace(ref array, chunkSize * i, chunkSize * (i + 1), chunkSize * (i + 2) - 1);
                    }
                }
                chunkSize *= 2;
            }
        }

        private static void PreSort (ref int[] array)
        {
            int count = 0;
            int arrayLength = array.Length;
            if (arrayLength % MinChunkSize == 0)
            {
                count = arrayLength / MinChunkSize;
            }
            else
            {
                count = arrayLength / MinChunkSize + 1;
            }

            for (int i = 0; i < count; ++i)
            {
                if (i == count - 1)
                {
                    ExtraSorter.InsertSort(ref array, MinChunkSize * i, arrayLength - 1);
                }
                else
                {
                    ExtraSorter.InsertSort(ref array, MinChunkSize * i, MinChunkSize * (i + 1) - 1);
                }
            }
        }

        private static int FindValuesPlace(int[] array, int arrayBegin, int arrayEnd, int value)
        {
            int place = arrayBegin;
            for (int i = arrayBegin + 1; i <= arrayEnd; ++i)
            {
                if (value < array[i])
                {
                    break;
                }
                else
                {
                    place++;
                    continue;
                }
            }

            return place;
        }

        private static void Slide(ref int[] array, int arrayBegin, int arrayEnd, int pos)
        {
            for (int i = arrayBegin; i < pos; ++i)
            {
                array[i] = array[i + 1];
            }
        }

        private static void MergeInPlace(ref int[] array, int firstArrayBegin, int secondArrayBegin, int secondArrayEnd)
        {
            int firstArrayEnd = secondArrayBegin;

            for (int i = firstArrayBegin; i < firstArrayEnd; ++i)
            {
                if (array[secondArrayBegin] < array[i])
                {
                    int tmp = array[i];
                    array[i] = array[secondArrayBegin];

                    int pos = FindValuesPlace(array, secondArrayBegin, secondArrayEnd, tmp);
                    Slide(ref array, secondArrayBegin, secondArrayEnd, pos);
                    array[pos] = tmp;
                }
            }
        }
    }
}
