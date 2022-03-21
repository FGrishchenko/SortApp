using System.Diagnostics;
using testApp.Sortings;
using testApp.Utilitites;

namespace testApp
{
    public partial class Form1 : Form
    {
        private Stopwatch StartTime = new Stopwatch();
        private readonly Random random = new Random();
        private int[] arr;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = string.Empty;
            arr = new int[int.Parse(textBox1.Text)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(30);
            }

            foreach (var item in arr)
            {
                label2.Text += item.ToString() + "   ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = string.Empty;
            ShellSort ShellSort = new ShellSort();
            var time = TimeUtils.SortAndGetTime(() => ShellSort.SortArray(arr), StartTime);

            foreach (var item in arr)
            {
                label3.Text += item.ToString() + "   ";
            }

            label3.Text += $"\n{time}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = string.Empty;
            SortingBySimpleSelection SortingBySimpleSelection = new SortingBySimpleSelection();
            var time = TimeUtils.SortAndGetTime(() => SortingBySimpleSelection.SortArray(arr), StartTime);

            foreach (var item in arr)
            {
                label4.Text += item.ToString() + "   ";
            }

            label4.Text += $"\n{time}";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label5.Text = string.Empty;
            MergeSort MergeSort = new MergeSort();
            var time = TimeUtils.SortAndGetTime(() => MergeSort.SortArray(arr), StartTime);

            foreach (var item in arr)
            {
                label5.Text += item.ToString() + "   ";
            }

            label5.Text += $"\n{time}";
        }

        public void Test()
        {
            MergeSort MergeSort = new MergeSort();
            kekw(() => TimeUtils.SortAndGetTime(() => MergeSort.SortArray(arr), StartTime), arr, label5);
        }

        public void kekw<T>(Func<T> action, int[] arr, Label someLabel)
        {
            someLabel.Text = string.Empty;
            var time = action();

            foreach (var item in arr)
            {
                someLabel.Text += item.ToString() + "   ";
            }

            someLabel.Text += $"\n{time}";
        }
    }
}