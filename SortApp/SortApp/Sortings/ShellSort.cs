namespace testApp.Sortings
{
    public class ShellSort
    {
        public void SortArray(int[] arr)
        {
            int step = arr.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < arr.Length; i++)
                {
                    int value = arr[i];
                    for (j = i - step; (j >= 0) && (arr[j] > value); j -= step)
                    {
                        arr[j + step] = arr[j];
                    }
                    arr[j + step] = value;
                }
                step /= 2;
            }
        }
    }
}
