namespace WFDynamicCoding
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            matrixDataGridView = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ResultBtn = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            setParamsBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            financesNumeric = new NumericUpDown();
            factoriesNumeric = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            investListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)matrixDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)financesNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)factoriesNumeric).BeginInit();
            SuspendLayout();
            // 
            // matrixDataGridView
            // 
            matrixDataGridView.AllowUserToAddRows = false;
            matrixDataGridView.AllowUserToDeleteRows = false;
            matrixDataGridView.AllowUserToResizeColumns = false;
            matrixDataGridView.AllowUserToResizeRows = false;
            matrixDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrixDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column0, Column1, Column2 });
            matrixDataGridView.Location = new Point(220, 34);
            matrixDataGridView.MultiSelect = false;
            matrixDataGridView.Name = "matrixDataGridView";
            matrixDataGridView.RowHeadersVisible = false;
            matrixDataGridView.Size = new Size(350, 150);
            matrixDataGridView.TabIndex = 0;
            // 
            // Column0
            // 
            Column0.HeaderText = "П1";
            Column0.Name = "Column0";
            // 
            // Column1
            // 
            Column1.HeaderText = "П2";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "П3";
            Column2.Name = "Column2";
            // 
            // ResultBtn
            // 
            ResultBtn.Location = new Point(18, 337);
            ResultBtn.Name = "ResultBtn";
            ResultBtn.Size = new Size(173, 37);
            ResultBtn.TabIndex = 1;
            ResultBtn.Text = "Рассчитать";
            ResultBtn.UseVisualStyleBackColor = true;
            ResultBtn.Click += ResultBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(18, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(173, 79);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Финансы";
            // 
            // button1
            // 
            button1.Location = new Point(6, 32);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(92, 32);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(18, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(173, 79);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Предприятия";
            // 
            // button4
            // 
            button4.Location = new Point(92, 32);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 32);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(setParamsBtn);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(financesNumeric);
            groupBox3.Controls.Add(factoriesNumeric);
            groupBox3.Location = new Point(18, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(173, 147);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Параметры";
            // 
            // setParamsBtn
            // 
            setParamsBtn.Location = new Point(6, 116);
            setParamsBtn.Name = "setParamsBtn";
            setParamsBtn.Size = new Size(161, 23);
            setParamsBtn.TabIndex = 0;
            setParamsBtn.Text = "Установить";
            setParamsBtn.UseVisualStyleBackColor = true;
            setParamsBtn.Click += setParamsBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 7;
            label2.Text = "Предприятия";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 6;
            label1.Text = "Финансы";
            // 
            // financesNumeric
            // 
            financesNumeric.Location = new Point(6, 40);
            financesNumeric.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            financesNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            financesNumeric.Name = "financesNumeric";
            financesNumeric.Size = new Size(80, 23);
            financesNumeric.TabIndex = 4;
            financesNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // factoriesNumeric
            // 
            factoriesNumeric.Location = new Point(6, 86);
            factoriesNumeric.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            factoriesNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            factoriesNumeric.Name = "factoriesNumeric";
            factoriesNumeric.Size = new Size(80, 23);
            factoriesNumeric.TabIndex = 5;
            factoriesNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 12);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 5;
            label3.Text = "Матрица прибыли";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 197);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Вложения";
            // 
            // investListBox
            // 
            investListBox.FormattingEnabled = true;
            investListBox.ItemHeight = 15;
            investListBox.Location = new Point(222, 220);
            investListBox.Name = "investListBox";
            investListBox.Size = new Size(347, 154);
            investListBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 383);
            Controls.Add(investListBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ResultBtn);
            Controls.Add(matrixDataGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)matrixDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)financesNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)factoriesNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView matrixDataGridView;
        private Button ResultBtn;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
        private Button button4;
        private Button button3;
        private GroupBox groupBox3;
        private Button setParamsBtn;
        private Label label2;
        private Label label1;
        private NumericUpDown financesNumeric;
        private NumericUpDown factoriesNumeric;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn Column0;
        private ListBox investListBox;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
