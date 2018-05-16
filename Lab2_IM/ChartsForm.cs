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
    public partial class ChartsForm : Form
    {
        public ChartsForm()
        {
            InitializeComponent();
        }

        public void AddChartData((double time, int count, int stackA, int stackB) input)
        {
            countChart.Series[0].Points.AddXY(input.time, input.count);
            stackAChart.Series[0].Points.AddXY(input.time, input.stackA);
            stackBChart.Series[0].Points.AddXY(input.time, input.stackB);
        }
    }
}
