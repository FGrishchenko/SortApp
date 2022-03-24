namespace testApp.Utilitites
{
    public static class ShowUtils
    {
        public static void ShowSortedArrayWithTime<T>(Func<T> action, int[] arr, Label someLabel)
        {
            someLabel.Text = string.Empty;
            var time = action();
            foreach (var item in arr)
            {
                someLabel.Text += item.ToString() + "   ";
            }
            someLabel.Text += $"\n{time}";
        }

        public static void InitAndShowArray(out int[] arr, Label labelForPrint, TextBox textBoxForLength, Random random)
        {
            labelForPrint.Text = string.Empty;
            arr = new int[int.Parse(textBoxForLength.Text)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(30);
            }

            foreach (var item in arr)
            {
                labelForPrint.Text += item.ToString() + "   ";
            }
        }
    }
}
