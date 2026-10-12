using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoCtr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btFCFS_Click(object sender, EventArgs e)
        {
            Form2 fcfs = new Form2();
            fcfs.Show();
        }

        private void btSJF_Click(object sender, EventArgs e)
        {
            Form3 sjf = new Form3();
            sjf.Show();

        }
    }
}
