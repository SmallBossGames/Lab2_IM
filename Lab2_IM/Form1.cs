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
            try
            {
                resultDataGrid.Rows.Clear();
                var chartForm = new ChartsForm();

                var alphaArrayA = new double[3];
                alphaArrayA[0] = alphaArrayA[1] = alphaArrayA[2] = Double.Parse(alphaA.Text);

                var alphaArrayB = new double[5];
                alphaArrayB[0] = alphaArrayB[1] = alphaArrayB[2] = alphaArrayB[3] = alphaArrayB[4] = Double.Parse(alphaB.Text);

                var simualateEnum = DynamicModelingFunctional.Simulate(Double.Parse(IntervalTextBox.Text), Double.Parse(DeltaTextBox.Text), alphaArrayA, alphaArrayB);

                foreach (var a in simualateEnum)
                {
                    chartForm.AddChartData(a);
                    resultDataGrid.Rows.Add(a.time, a.count, a.stackA, a.stackB);
                }

                chartForm.Show();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так");
            }
        }
    }
}