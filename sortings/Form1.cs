using System;
using System.Diagnostics;

namespace sortings
{
    public partial class Form1 : Form
    {
        private Sorting sortingAlgorithm;
        private Stopwatch timer;
        private int[] array;
        private int[] backup;
        private string result;
        private ArrayProvider arrayProvider;

        public Form1()
        {
            InitializeComponent();
            arrayProvider = new ArrayProvider();
            timer = new Stopwatch();
        }

        struct DataParameter
        {
            public int Process;
            public int Delay;
        }

        private DataParameter _inputparameter;

        private void bGenerate_Click_1(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(tbArraySize.Text);

                array = arrayProvider.GenerateArray(size);
                backup = array;
                rtArray.Text = arrayProvider.ArrayToString(array);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите чисо");
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void bSort_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                backgroundSorting.CancelAsync();
                throw new Exception("Для сортировки массив должен быть не пустым");
            }
            if (array.Length < 1)
            {
                backgroundSorting.CancelAsync();
                throw new Exception("Для сортировки массив должен быть больше 1");
            }

            if (!backgroundSorting.IsBusy)
            {
                lbPercent.Visible = true;
                progressBar.Visible = true;
                _inputparameter.Delay = array.Length;
                _inputparameter.Process = array.Length;
                backgroundSorting.RunWorkerAsync(_inputparameter);
                rtbResult.Text = "";
            }
            else
            {
                backgroundSorting.CancelAsync();
            }

        }

        private void sorting()
        {
            backgroundSorting.ReportProgress(0);
            result = "";
            if (array.Length > 1)
            {
                if (sortingAlgorithm == null)
                {
                    throw new Exception("Выберите тип сортировки");
                }
                timer.Restart();
                sortingAlgorithm.Sort(array);
                timer.Stop();
                backgroundSorting.ReportProgress(100);
                result = sortingAlgorithm.toString(timer.Elapsed.TotalMilliseconds) + "\n";
            }
        }

        private void rtbResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundSorting_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lbPercent.Text = $"Идет процесс... {e.ProgressPercentage}";
            progressBar.Update();
        }

        private void backgroundSorting_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Отсортировано");
            rtbResult.Text = arrayProvider.ArrayToString(array) + $"\nРазмер: {array.Length}" + "\n\n" + result;
            ResetToBackup();
            array = backup;
        }
        private void backgroundSorting_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                sorting();
            }
            catch (Exception ex)
            {
                backgroundSorting.CancelAsync();
                MessageBox.Show(ex.Message);
            }
        }

        private void rbBubble_CheckedChanged(object sender, EventArgs e)
        {
            sortingAlgorithm = new PancakeSort(arrayProvider);
        }

        private void rbInsert_CheckedChanged(object sender, EventArgs e)
        {
            sortingAlgorithm = new TimSort(arrayProvider);
        }

        private void rbSelect_CheckedChanged(object sender, EventArgs e)
        {
            sortingAlgorithm = new HeapSort(arrayProvider);
        }
        private void lbPercent_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void tbArray_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pancake_MouseHover(object sender, EventArgs e)
        {
            ttPancake.Show("Изучить", pancake);
        }

        private void tim_MouseHover(object sender, EventArgs e)
        {
            ttPancake.Show("Изучить", tim);

        }

        private void heap_MouseHover(object sender, EventArgs e)
        {
            ttPancake.Show("Изучить", heap);
        }

        private void pancake_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new PancakeSortInfo(this).Show();
        }

        private void heap_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new HeapSortInfo(this).Show();
        }

        private void steps_Click(object sender, EventArgs e)
        {
            new SortingStepsInfo(this, sortingAlgorithm).Show();
        }

        private void btCompare_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new ComparationInfo(this, arrayProvider, array, timer).Show();
        }

        public void ResetToBackup()
        {
            array = backup;
        }

        private void tim_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new TeamSortInfo(this).Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}