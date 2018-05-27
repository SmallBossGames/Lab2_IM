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
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        public void AddDataViewData((double time, int count, int stackA, int stackB) input, double alphaA, double alphaB)
        {
            ResultTable.Rows.Add(input.time, input.count, input.stackA, input.stackB);
            TableChart.Series[0].Points.AddXY(input.time, input.count);
            TableAlphaATextBox.Text = alphaA.ToString();
            TableAlphaBTextBox.Text = alphaB.ToString();
        }
    }
}