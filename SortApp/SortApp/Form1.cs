using MaterialSkin.Controls;
using System.Diagnostics;
using testApp.Sortings;
using testApp.Utilitites;

namespace testApp
{
    public partial class Form1 : MaterialForm
    {
        private Stopwatch StartTime = new Stopwatch();
        private readonly Random random = new Random();
        private int[] arr;

        public Form1()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            ShowUtils.InitAndShowArray(out arr, materialLabel2, textBox1, random);
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            ShellSort ShellSort = new ShellSort();
            ShowUtils.ShowSortedArrayWithTime(() => TimeUtils.SortAndGetTime(() => ShellSort.SortArray(arr), StartTime), arr, materialLabel3);
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            SortingBySimpleSelection SortingBySimpleSelection = new SortingBySimpleSelection();
            ShowUtils.ShowSortedArrayWithTime(() => TimeUtils.SortAndGetTime(() => SortingBySimpleSelection.SortArray(arr), StartTime), arr, materialLabel4);
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            MergeSort MergeSort = new MergeSort();
            ShowUtils.ShowSortedArrayWithTime(() => TimeUtils.SortAndGetTime(() => MergeSort.SortArray(arr), StartTime), arr, materialLabel5);
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            QuickSort QuickSort = new QuickSort();
            ShowUtils.ShowSortedArrayWithTime(() => TimeUtils.SortAndGetTime(() => QuickSort.SortArray(arr), StartTime), arr, materialLabel6);
        }
    }
}