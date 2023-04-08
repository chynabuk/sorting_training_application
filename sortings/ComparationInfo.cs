using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortings
{
    partial class ComparationInfo : Form
    {
        private Form1 form1;
        private Sorting heap;
        private Sorting pancake;
        private Sorting tim;
        private ArrayProvider arrayProvider;
        private Stopwatch stopwatch;
        private int[] array;
        private int[] array2;
        private int[] array3;

        public ComparationInfo(Form1 form1, ArrayProvider arrayProvider, int[] array, Stopwatch stopwatch)
        {
            this.form1 = form1;
            InitializeComponent();
            this.arrayProvider = arrayProvider;

            this.stopwatch = stopwatch;
            this.array = array;
            array2 = array;
            array3 = array;
        }

        private void ComparationInfo_Load(object sender, EventArgs e)
        {
            Sort();
        }

        private void Sort()
        {
            string result = "";
            if (array.Length > 1)
            {
                pancake = new PancakeSort(arrayProvider);
                stopwatch.Restart();
                pancake.Sort(array);
                stopwatch.Stop();
                result += pancake.toString(stopwatch.Elapsed.TotalMilliseconds) + "\n\n";

                heap = new HeapSort(arrayProvider);
                stopwatch.Restart();
                heap.Sort(array2);
                stopwatch.Stop();
                result += heap.toString(stopwatch.Elapsed.TotalMilliseconds) + "\n\n";


                tim = new TimSort(arrayProvider);
                stopwatch.Restart();
                tim.Sort(array3);
                stopwatch.Stop();
                result += tim.toString(stopwatch.Elapsed.TotalMilliseconds);
            }

            richTextBox1.Text = result;
        }

        private void ComparationInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Enabled = true;
            form1.ResetToBackup();
        }
    }
}
