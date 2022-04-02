namespace testApp.Utilitites
{
    public static class ArrayUtils
    {
        public static int[] InitArray(out int[] arr, TextBox textBoxForLength, Random random)
        {
            arr = new int[int.Parse(textBoxForLength.Text)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(30);
            }
            return arr;
        }
    }
}