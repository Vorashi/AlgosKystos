namespace Simplex
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nOfContraintsTextBox = new System.Windows.Forms.TextBox();
            this.nOfVariablesTextBox = new System.Windows.Forms.TextBox();
            this.functionGridView = new System.Windows.Forms.DataGridView();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            this.extrComboBox = new System.Windows.Forms.ComboBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.resultsLbl = new System.Windows.Forms.Label();
            this.constraintsGridView = new System.Windows.Forms.DataGridView();
            this.okBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.functionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constraintsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите количество ограничений:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите количество переменных:";
            // 
            // nOfContraintsTextBox
            // 
            this.nOfContraintsTextBox.Location = new System.Drawing.Point(313, 14);
            this.nOfContraintsTextBox.Name = "nOfContraintsTextBox";
            this.nOfContraintsTextBox.Size = new System.Drawing.Size(100, 26);
            this.nOfContraintsTextBox.TabIndex = 2;
            // 
            // nOfVariablesTextBox
            // 
            this.nOfVariablesTextBox.Location = new System.Drawing.Point(313, 68);
            this.nOfVariablesTextBox.Name = "nOfVariablesTextBox";
            this.nOfVariablesTextBox.Size = new System.Drawing.Size(100, 26);
            this.nOfVariablesTextBox.TabIndex = 3;
            // 
            // functionGridView
            // 
            this.functionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.functionGridView.Location = new System.Drawing.Point(16, 336);
            this.functionGridView.Name = "functionGridView";
            this.functionGridView.RowHeadersWidth = 62;
            this.functionGridView.RowTemplate.Height = 28;
            this.functionGridView.Size = new System.Drawing.Size(455, 88);
            this.functionGridView.TabIndex = 6;
            // 
            // resultsGridView
            // 
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Location = new System.Drawing.Point(16, 531);
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.RowHeadersWidth = 62;
            this.resultsGridView.RowTemplate.Height = 28;
            this.resultsGridView.Size = new System.Drawing.Size(821, 211);
            this.resultsGridView.TabIndex = 7;
            // 
            // extrComboBox
            // 
            this.extrComboBox.FormattingEnabled = true;
            this.extrComboBox.Items.AddRange(new object[] {
            "Max",
            "Min"});
            this.extrComboBox.Location = new System.Drawing.Point(499, 365);
            this.extrComboBox.Name = "extrComboBox";
            this.extrComboBox.Size = new System.Drawing.Size(93, 28);
            this.extrComboBox.TabIndex = 8;
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(16, 447);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(113, 38);
            this.goBtn.TabIndex = 9;
            this.goBtn.Text = "Решить";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(170, 447);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(191, 38);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Очистить все поля";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // resultsLbl
            // 
            this.resultsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resultsLbl.AutoSize = true;
            this.resultsLbl.Location = new System.Drawing.Point(12, 771);
            this.resultsLbl.Name = "resultsLbl";
            this.resultsLbl.Size = new System.Drawing.Size(0, 20);
            this.resultsLbl.TabIndex = 14;
            // 
            // constraintsGridView
            // 
            this.constraintsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.constraintsGridView.Location = new System.Drawing.Point(16, 147);
            this.constraintsGridView.Name = "constraintsGridView";
            this.constraintsGridView.RowHeadersWidth = 62;
            this.constraintsGridView.RowTemplate.Height = 28;
            this.constraintsGridView.Size = new System.Drawing.Size(849, 150);
            this.constraintsGridView.TabIndex = 4;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(460, 34);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(92, 37);
            this.okBtn.TabIndex = 15;
            this.okBtn.Text = "ОК";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Введите коэфициенты ограничений:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Введите коэфициенты функции:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Решение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 814);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.resultsLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.extrComboBox);
            this.Controls.Add(this.resultsGridView);
            this.Controls.Add(this.functionGridView);
            this.Controls.Add(this.constraintsGridView);
            this.Controls.Add(this.nOfVariablesTextBox);
            this.Controls.Add(this.nOfContraintsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Симплекс метод";
            ((System.ComponentModel.ISupportInitialize)(this.functionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constraintsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nOfContraintsTextBox;
        private System.Windows.Forms.TextBox nOfVariablesTextBox;
        private System.Windows.Forms.DataGridView functionGridView;
        private System.Windows.Forms.DataGridView resultsGridView;
        private System.Windows.Forms.ComboBox extrComboBox;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label resultsLbl;
        private System.Windows.Forms.DataGridView constraintsGridView;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

