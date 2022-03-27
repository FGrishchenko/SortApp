namespace testApp.Utilitites
{
    public static class ArrayUtils
    {
        public static int[] InitArray(int[] arr, Random random)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(50);
            }
            return arr;
        }
    }
}
