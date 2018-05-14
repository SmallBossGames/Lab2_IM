using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_IM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var count = DynamicModelingFunctional.Simulate(Convert.ToDouble(IntervalTextBox.Text), Convert.ToDouble(DeltaTextBox.Text));
            ResultTextBox.Text = count.ToString();
        }
    }
}