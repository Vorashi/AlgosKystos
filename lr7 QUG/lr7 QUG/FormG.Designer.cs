namespace lr7_QUG
{
    partial class FormG
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
            this.button10 = new System.Windows.Forms.Button();
            this.otv = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.Gkrit1 = new System.Windows.Forms.Label();
            this.Gkrit5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.netip = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(718, 551);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(232, 34);
            this.button10.TabIndex = 47;
            this.button10.Text = "Взять значения из файла";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // otv
            // 
            this.otv.AutoSize = true;
            this.otv.Location = new System.Drawing.Point(566, 260);
            this.otv.Name = "otv";
            this.otv.Size = new System.Drawing.Size(65, 20);
            this.otv.TabIndex = 46;
            this.otv.Text = "Ответ: ";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 543);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(309, 42);
            this.button6.TabIndex = 45;
            this.button6.Text = "Расчитать ответ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Gkrit1
            // 
            this.Gkrit1.AutoSize = true;
            this.Gkrit1.Location = new System.Drawing.Point(770, 194);
            this.Gkrit1.Name = "Gkrit1";
            this.Gkrit1.Size = new System.Drawing.Size(0, 20);
            this.Gkrit1.TabIndex = 44;
            // 
            // Gkrit5
            // 
            this.Gkrit5.AutoSize = true;
            this.Gkrit5.Location = new System.Drawing.Point(757, 174);
            this.Gkrit5.Name = "Gkrit5";
            this.Gkrit5.Size = new System.Drawing.Size(0, 20);
            this.Gkrit5.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(554, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 40);
            this.label11.TabIndex = 42;
            this.label11.Text = "Gкрит. = для (p <= 0,05):\r\n                  для (p <= 0,01):";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 533);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(308, 42);
            this.button5.TabIndex = 41;
            this.button5.Text = "Расчитать Gкрит.";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // netip
            // 
            this.netip.AutoSize = true;
            this.netip.Location = new System.Drawing.Point(734, 114);
            this.netip.Name = "netip";
            this.netip.Size = new System.Drawing.Size(0, 20);
            this.netip.TabIndex = 40;
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Location = new System.Drawing.Point(734, 94);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(0, 20);
            this.tip.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 40);
            this.label5.TabIndex = 38;
            this.label5.Text = "Типичные сдвиги:\r\nНетипичные сдвиги:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 523);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(308, 42);
            this.button4.TabIndex = 37;
            this.button4.Text = "Определить сдвиги";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(542, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Для начала необходимо посчитать разность значений \"после\" и \"до\".";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 433);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 54);
            this.button3.TabIndex = 35;
            this.button3.Text = "Добавить значения \"до\"";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 433);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 54);
            this.button2.TabIndex = 34;
            this.button2.Text = "Добавить значения \"после\"";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Разность";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "После";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "До";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(348, 94);
            this.listBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(134, 264);
            this.listBox3.TabIndex = 30;
            this.listBox3.Visible = false;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(179, 94);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(134, 264);
            this.listBox2.TabIndex = 29;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(15, 94);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(134, 264);
            this.listBox1.TabIndex = 28;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 384);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 26);
            this.textBox1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 513);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 42);
            this.button1.TabIndex = 26;
            this.button1.Text = "Расчитать разность";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 601);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.otv);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Gkrit1);
            this.Controls.Add(this.Gkrit5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.netip);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G-критерий знаков";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label otv;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label Gkrit1;
        private System.Windows.Forms.Label Gkrit5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label netip;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}