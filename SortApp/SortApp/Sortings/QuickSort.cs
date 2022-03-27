namespace testApp.Sortings
{
    public class QuickSort
    {
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        static int[] Quick_Sort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            Quick_Sort(array, minIndex, pivotIndex - 1);
            Quick_Sort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        public void SortArray(int[] array)
        {
            Quick_Sort(array, 0, array.Length - 1);
        }
    }
}