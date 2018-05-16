namespace Lab2_IM
{
    partial class ChartsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.countChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stackAChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stackBChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.countChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackAChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackBChart)).BeginInit();
            this.SuspendLayout();
            // 
            // countChart
            // 
            chartArea1.Name = "ChartArea1";
            this.countChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.countChart.Legends.Add(legend1);
            this.countChart.Location = new System.Drawing.Point(12, 12);
            this.countChart.Name = "countChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.countChart.Series.Add(series1);
            this.countChart.Size = new System.Drawing.Size(384, 300);
            this.countChart.TabIndex = 0;
            this.countChart.Text = "chart1";
            // 
            // stackAChart
            // 
            chartArea2.Name = "ChartArea1";
            this.stackAChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.stackAChart.Legends.Add(legend2);
            this.stackAChart.Location = new System.Drawing.Point(402, 12);
            this.stackAChart.Name = "stackAChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.stackAChart.Series.Add(series2);
            this.stackAChart.Size = new System.Drawing.Size(384, 300);
            this.stackAChart.TabIndex = 1;
            this.stackAChart.Text = "chart2";
            // 
            // stackBChart
            // 
            chartArea3.Name = "ChartArea1";
            this.stackBChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.stackBChart.Legends.Add(legend3);
            this.stackBChart.Location = new System.Drawing.Point(216, 318);
            this.stackBChart.Name = "stackBChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.stackBChart.Series.Add(series3);
            this.stackBChart.Size = new System.Drawing.Size(384, 300);
            this.stackBChart.TabIndex = 2;
            this.stackBChart.Text = "chart3";
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.stackBChart);
            this.Controls.Add(this.stackAChart);
            this.Controls.Add(this.countChart);
            this.Name = "ChartsForm";
            this.Text = "ChartsForm";
            ((System.ComponentModel.ISupportInitialize)(this.countChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackAChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackBChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart countChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart stackAChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart stackBChart;
    }
}