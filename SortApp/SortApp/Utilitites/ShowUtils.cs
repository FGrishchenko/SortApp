namespace testApp.Utilitites
{
    public static class ShowUtils
    {
        public static void ShowSortedArrayWithTime<T>(Func<T> action, int[] arr, Label someLabel)
        {
            someLabel.Text = string.Empty;
            someLabel.AutoSize = true;
            var time = action();
            if (arr.Length <= 50)
            {
                foreach (var item in arr)
                {
                    someLabel.Text += $"{item}   ";
                }
                someLabel.Text += $"\n{time}";
            }
            else
            {
                someLabel.Text += $"\n{time}";
            }
        }

        public static void ShowArray(int[] arr, Label labelForPrint)
        {
            labelForPrint.Text = string.Empty;
            if (arr.Length <= 50)
            {
                foreach (var item in arr)
                {
                    labelForPrint.Text += $"{item}   ";
                }
            }
            else
            {
                labelForPrint.Text += $"\nTo view an array, please enter an array length less than 50 or 50\n";
            }
        }
    }
}