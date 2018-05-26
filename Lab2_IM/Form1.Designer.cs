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
            this.label11 = new System.Windows.Forms.Label();
            this.TableATextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TableBTextBox = new System.Windows.Forms.TextBox();
            this.TableButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BUTTON
            // 
            this.BUTTON.Location = new System.Drawing.Point(9, 272);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(181, 23);
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
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Интервал: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 37);
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
            this.resultDataGrid.Location = new System.Drawing.Point(198, 6);
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
            this.label3.Location = new System.Drawing.Point(8, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Альфа A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Альфа B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "До:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "От:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "До:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "От:";
            // 
            // AlphaBToTextBox
            // 
            this.AlphaBToTextBox.Location = new System.Drawing.Point(80, 215);
            this.AlphaBToTextBox.Name = "AlphaBToTextBox";
            this.AlphaBToTextBox.Size = new System.Drawing.Size(100, 20);
            this.AlphaBToTextBox.TabIndex = 16;
            // 
            // AlphaBByTextBox
            // 
            this.AlphaBByTextBox.Location = new System.Drawing.Point(80, 193);
            this.AlphaBByTextBox.Name = "AlphaBByTextBox";
            this.AlphaBByTextBox.Size = new System.Drawing.Size(100, 20);
            this.AlphaBByTextBox.TabIndex = 17;
            // 
            // AlphaAToTextBox
            // 
            this.AlphaAToTextBox.Location = new System.Drawing.Point(80, 145);
            this.AlphaAToTextBox.Name = "AlphaAToTextBox";
            this.AlphaAToTextBox.Size = new System.Drawing.Size(100, 20);
            this.AlphaAToTextBox.TabIndex = 18;
            // 
            // AlphaAByTextBox
            // 
            this.AlphaAByTextBox.Location = new System.Drawing.Point(80, 121);
            this.AlphaAByTextBox.Name = "AlphaAByTextBox";
            this.AlphaAByTextBox.Size = new System.Drawing.Size(100, 20);
            this.AlphaAByTextBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Шаг:";
            // 
            // StepTextBox
            // 
            this.StepTextBox.Location = new System.Drawing.Point(80, 246);
            this.StepTextBox.Name = "StepTextBox";
            this.StepTextBox.Size = new System.Drawing.Size(100, 20);
            this.StepTextBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 60);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Альфа А";
            // 
            // TableATextBox
            // 
            this.TableATextBox.Location = new System.Drawing.Point(80, 345);
            this.TableATextBox.Name = "TableATextBox";
            this.TableATextBox.Size = new System.Drawing.Size(100, 20);
            this.TableATextBox.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Альфа B";
            // 
            // TableBTextBox
            // 
            this.TableBTextBox.Location = new System.Drawing.Point(80, 371);
            this.TableBTextBox.Name = "TableBTextBox";
            this.TableBTextBox.Size = new System.Drawing.Size(100, 20);
            this.TableBTextBox.TabIndex = 27;
            // 
            // TableButton
            // 
            this.TableButton.Location = new System.Drawing.Point(12, 409);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(180, 23);
            this.TableButton.TabIndex = 28;
            this.TableButton.Text = "Рассчёт на C#";
            this.TableButton.UseVisualStyleBackColor = true;
            this.TableButton.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Построение графиков";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Рассчёт на F#";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TableButton);
            this.Controls.Add(this.TableBTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TableATextBox);
            this.Controls.Add(this.label11);
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TableATextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TableBTextBox;
        private System.Windows.Forms.Button TableButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}

