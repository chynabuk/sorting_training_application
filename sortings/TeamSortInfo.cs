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
    public partial class TeamSortInfo : Form
    {
        private Form1 form1;

        public TeamSortInfo(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void teamBack_Click(object sender, EventArgs e)
        {
            form1.Enabled = true;
            this.Close();
        }

        private void TeamSortInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Enabled = true;
        }

        private void TeamSortInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
