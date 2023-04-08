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
    public partial class HeapSortInfo : Form
    {
        private Form1 form1;

        public HeapSortInfo(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HeapSortInfo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void heapBack_Click(object sender, EventArgs e)
        {
            form1.Enabled = true;
            this.Close();
        }

        private void HeapSortInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Enabled = true;
        }
    }
}
