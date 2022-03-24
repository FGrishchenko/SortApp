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
            ShowUtils.InitAndShowArray(out arr, label2, textBox1, random);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShellSort ShellSort = new ShellSort();
            ShowUtils.ShowSortedArrayWithTime(() => TimeUtils.SortAndGetTime(() => ShellSort.SortArray(arr), StartTime), arr, label3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SortingBySimpleSelection SortingBySimpleSelection = new SortingBySimpleSelection();
            ShowUtils.ShowSortedArrayWithTime(() => TimeUtils.SortAndGetTime(() => SortingBySimpleSelection.SortArray(arr), StartTime), arr, label4);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MergeSort MergeSort = new MergeSort();
            ShowUtils.ShowSortedArrayWithTime(() => TimeUtils.SortAndGetTime(() => MergeSort.SortArray(arr), StartTime), arr, label5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuickSort QuickSort = new QuickSort();
            ShowUtils.ShowSortedArrayWithTime(() => TimeUtils.SortAndGetTime(() => QuickSort.SortArray(arr), StartTime), arr, label6);
        }
    }
}