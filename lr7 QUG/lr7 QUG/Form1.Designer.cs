namespace lr7_QUG
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
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonQ
            // 
            this.buttonQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQ.Location = new System.Drawing.Point(74, 72);
            this.buttonQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(523, 52);
            this.buttonQ.TabIndex = 8;
            this.buttonQ.Text = "Q-критерий Розенбаума";
            this.buttonQ.UseVisualStyleBackColor = true;
            this.buttonQ.Click += new System.EventHandler(this.buttonQ_Click);
            // 
            // buttonG
            // 
            this.buttonG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonG.Location = new System.Drawing.Point(74, 186);
            this.buttonG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(523, 45);
            this.buttonG.TabIndex = 7;
            this.buttonG.Text = "G-критерий знаков";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Click += new System.EventHandler(this.buttonG_Click);
            // 
            // buttonU
            // 
            this.buttonU.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonU.Location = new System.Drawing.Point(74, 132);
            this.buttonU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(523, 46);
            this.buttonU.TabIndex = 6;
            this.buttonU.Text = "U-критерий Манна-Уитни";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.buttonU_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 312);
            this.Controls.Add(this.buttonQ);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.buttonU);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оценка различий двух выборок";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonU;
    }
}

