using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortings
{
    partial class SortingStepsInfo : Form
    {
        private Form1 form1;
        private Sorting sortingAlgorithm;

        public SortingStepsInfo(Form1 form1, Sorting sorting)
        {
            InitializeComponent();
            this.form1 = form1;
            this.sortingAlgorithm = sorting;
        }

        private void SortingSteps_Load(object sender, EventArgs e)
        {
            richTBArray.Text = sortingAlgorithm.GetSteps();
        }

        private void SortingSteps_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Enabled = true;
        }
    }
}
