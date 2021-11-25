using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btC_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txta.Text);
            b = int.Parse(txtb.Text);
            kq = a + b;
            txtkq.Text = kq.ToString();


        }
    }
}
