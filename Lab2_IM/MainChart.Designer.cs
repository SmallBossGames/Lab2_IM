namespace Lab2_IM
{
    partial class MainChart
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
            this.chartkek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartkek)).BeginInit();
            this.SuspendLayout();
            // 
            // chartkek
            // 
            chartArea1.Name = "ChartArea1";
            this.chartkek.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartkek.Legends.Add(legend1);
            this.chartkek.Location = new System.Drawing.Point(12, 12);
            this.chartkek.Name = "chartkek";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Количество произведённой продукции";
            this.chartkek.Series.Add(series1);
            this.chartkek.Size = new System.Drawing.Size(506, 351);
            this.chartkek.TabIndex = 0;
            this.chartkek.Text = "chart1";
            // 
            // MainChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 376);
            this.Controls.Add(this.chartkek);
            this.Name = "MainChart";
            this.Text = "MainChart";
            ((System.ComponentModel.ISupportInitialize)(this.chartkek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartkek;
    }
}