namespace Lab2_IM
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BUTTON = new System.Windows.Forms.Button();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeltaTextBox = new System.Windows.Forms.TextBox();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stackA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stackB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AlphaBToTextBox = new System.Windows.Forms.TextBox();
            this.AlphaBByTextBox = new System.Windows.Forms.TextBox();
            this.AlphaAToTextBox = new System.Windows.Forms.TextBox();
            this.AlphaAByTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StepTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AlphaComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BUTTON
            // 
            this.BUTTON.Location = new System.Drawing.Point(9, 262);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(168, 23);
            this.BUTTON.TabIndex = 0;
            this.BUTTON.Text = "Начать";
            this.BUTTON.UseVisualStyleBackColor = true;
            this.BUTTON.Click += new System.EventHandler(this.button1_Click);
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Location = new System.Drawing.Point(80, 6);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntervalTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Интервал: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дельта: ";
            // 
            // DeltaTextBox
            // 
            this.DeltaTextBox.Location = new System.Drawing.Point(80, 34);
            this.DeltaTextBox.Name = "DeltaTextBox";
            this.DeltaTextBox.Size = new System.Drawing.Size(100, 20);
            this.DeltaTextBox.TabIndex = 4;
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.count,
            this.stackA,
            this.stackB});
            this.resultDataGrid.Location = new System.Drawing.Point(186, 6);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.Size = new System.Drawing.Size(446, 455);
            this.resultDataGrid.TabIndex = 7;
            // 
            // time
            // 
            this.time.HeaderText = "Время";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // count
            // 
            this.count.HeaderText = "Количество";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // stackA
            // 
            this.stackA.HeaderText = "Заготовки 1";
            this.stackA.Name = "stackA";
            this.stackA.ReadOnly = true;
            // 
            // stackB
            // 
            this.stackB.HeaderText = "Заготовки 2";
            this.stackB.Name = "stackB";
            this.stackB.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Альфа A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Альфа B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "До:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "От:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "До:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "От:";
            // 
            // AlphaBToTextBox
            // 
            this.AlphaBToTextBox.Location = new System.Drawing.Point(33, 210);
            this.AlphaBToTextBox.Name = "AlphaBToTextBox";
            this.AlphaBToTextBox.Size = new System.Drawing.Size(100, 20);
            this.AlphaBToTextBox.TabIndex = 16;
            // 
            // AlphaBByTextBox
            // 
            this.AlphaBByTextBox.Location = new System.Drawing.Point(33, 184);
            this.AlphaBByTextBox.Name = "AlphaBByTextBox";
            this.AlphaBByTextBox.Size = new System.Drawing.Size(100, 20);
            this.AlphaBByTextBox.TabIndex = 17;
            // 
            // AlphaAToTextBox
            // 
            this.AlphaAToTextBox.Location = new System.Drawing.Point(41, 132);
            this.AlphaAToTextBox.Name = "AlphaAToTextBox";
            this.AlphaAToTextBox.Size = new System.Drawing.Size(100, 20);
            this.AlphaAToTextBox.TabIndex = 18;
            // 
            // AlphaAByTextBox
            // 
            this.AlphaAByTextBox.Location = new System.Drawing.Point(41, 108);
            this.AlphaAByTextBox.Name = "AlphaAByTextBox";
            this.AlphaAByTextBox.Size = new System.Drawing.Size(100, 20);
            this.AlphaAByTextBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Шаг:";
            // 
            // StepTextBox
            // 
            this.StepTextBox.Location = new System.Drawing.Point(33, 236);
            this.StepTextBox.Name = "StepTextBox";
            this.StepTextBox.Size = new System.Drawing.Size(100, 20);
            this.StepTextBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Выберите альфа:";
            // 
            // AlphaComboBox
            // 
            this.AlphaComboBox.FormattingEnabled = true;
            this.AlphaComboBox.Location = new System.Drawing.Point(113, 57);
            this.AlphaComboBox.Name = "AlphaComboBox";
            this.AlphaComboBox.Size = new System.Drawing.Size(51, 21);
            this.AlphaComboBox.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 473);
            this.Controls.Add(this.AlphaComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StepTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AlphaAByTextBox);
            this.Controls.Add(this.AlphaAToTextBox);
            this.Controls.Add(this.AlphaBByTextBox);
            this.Controls.Add(this.AlphaBToTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultDataGrid);
            this.Controls.Add(this.DeltaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IntervalTextBox);
            this.Controls.Add(this.BUTTON);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUTTON;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DeltaTextBox;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn stackA;
        private System.Windows.Forms.DataGridViewTextBoxColumn stackB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AlphaBToTextBox;
        private System.Windows.Forms.TextBox AlphaBByTextBox;
        private System.Windows.Forms.TextBox AlphaAToTextBox;
        private System.Windows.Forms.TextBox AlphaAByTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox StepTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox AlphaComboBox;
    }
}

