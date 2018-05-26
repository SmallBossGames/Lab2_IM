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
            AlphaComboBox.Items.Add("A"); AlphaComboBox.Items.Add("B");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            double alphaAI = 0;
            double alphaBI = 0;
            decimal step = Convert.ToDecimal(StepTextBox.Text);

            if (AlphaComboBox.SelectedIndex == 0)
            {
                k = (int)(Math.Floor(((Convert.ToDecimal(AlphaAToTextBox.Text) - Convert.ToDecimal(AlphaAByTextBox.Text)) / step)));
            }
            else k = (int)(Math.Floor(((Convert.ToDecimal(AlphaBToTextBox.Text) - Convert.ToDecimal(AlphaBByTextBox.Text)) / step)));

            alphaAI = Convert.ToDouble(AlphaAByTextBox.Text);
            alphaBI = Convert.ToDouble(AlphaBByTextBox.Text);

            for (int i = 1; i < k + 1; i++)
            {
                try
                {
                    resultDataGrid.Rows.Clear();
                    var chartForm = new ChartsForm();

                    var alphaArrayA = new double[2];
                    alphaArrayA[0] = alphaArrayA[1] = alphaAI; //Double.Parse(alphaA.Text);

                    var alphaArrayB = new double[4];
                    alphaArrayB[0] = alphaArrayB[1] = alphaArrayB[2] = alphaArrayB[3] = alphaBI; //Double.Parse(alphaB.Text);

                    var simualateEnum = DynamicModelingFunctional.Simulate(Double.Parse(IntervalTextBox.Text), Double.Parse(DeltaTextBox.Text), alphaArrayA, alphaArrayB);

                    foreach (var a in simualateEnum)
                    {
                        chartForm.AddChartData(a);
                        resultDataGrid.Rows.Add(a.time, a.count, a.stackA, a.stackB);
                    }

                    chartForm.Show();

                    if (AlphaComboBox.Items.Equals("A") == true) alphaAI += (double)step;
                    else alphaBI += (double)step;
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так");
                }
            }
        }
    }
}