namespace Lab2_IM
{
    partial class TableForm
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
            this.ResultTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TableAlphaATextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TableAlphaBTextBox = new System.Windows.Forms.TextBox();
            this.TableChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultTable
            // 
            this.ResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.ResultTable.Location = new System.Drawing.Point(477, 32);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.Size = new System.Drawing.Size(446, 299);
            this.ResultTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Количество";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Время";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Заготовки 1";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Заготовки 2";
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Значение альфа А: ";
            // 
            // TableAlphaATextBox
            // 
            this.TableAlphaATextBox.Location = new System.Drawing.Point(124, 6);
            this.TableAlphaATextBox.Name = "TableAlphaATextBox";
            this.TableAlphaATextBox.ReadOnly = true;
            this.TableAlphaATextBox.Size = new System.Drawing.Size(100, 20);
            this.TableAlphaATextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Значение альфа В: ";
            // 
            // TableAlphaBTextBox
            // 
            this.TableAlphaBTextBox.Location = new System.Drawing.Point(342, 6);
            this.TableAlphaBTextBox.Name = "TableAlphaBTextBox";
            this.TableAlphaBTextBox.ReadOnly = true;
            this.TableAlphaBTextBox.Size = new System.Drawing.Size(100, 20);
            this.TableAlphaBTextBox.TabIndex = 4;
            // 
            // TableChart
            // 
            chartArea1.Name = "ChartArea1";
            this.TableChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TableChart.Legends.Add(legend1);
            this.TableChart.Location = new System.Drawing.Point(15, 32);
            this.TableChart.Name = "TableChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Количество произведённой продукции";
            this.TableChart.Series.Add(series1);
            this.TableChart.Size = new System.Drawing.Size(456, 300);
            this.TableChart.TabIndex = 5;
            this.TableChart.Text = "chart1";
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 346);
            this.Controls.Add(this.TableChart);
            this.Controls.Add(this.TableAlphaBTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TableAlphaATextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultTable);
            this.Name = "TableForm";
            this.Text = "TableForm";
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TableAlphaATextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TableAlphaBTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart TableChart;
    }
}