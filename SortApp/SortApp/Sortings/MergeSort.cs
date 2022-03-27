namespace testApp.Sortings
{
    public class MergeSort
    {
        public void Merge(int[] arr, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (arr[left] < arr[right])
                {
                    tempArray[index] = arr[left];
                    left++;
                }
                else
                {
                    tempArray[index] = arr[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = arr[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = arr[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                arr[lowIndex + i] = tempArray[i];
            }
        }


        public int[] Merge_Sort(int[] arr, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                Merge_Sort(arr, lowIndex, middleIndex);
                Merge_Sort(arr, middleIndex + 1, highIndex);
                Merge(arr, lowIndex, middleIndex, highIndex);
            }

            return arr;
        }

        public void SortArray(int[] array)
        {
            Merge_Sort(array, 0, array.Length - 1);
        }
    }
}
