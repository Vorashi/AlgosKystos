using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr7_QUG
{
    public partial class FormQ : Form
    {
        public FormQ()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            n1.Text = listBox1.Items.Count.ToString();
            n2.Text = listBox2.Items.Count.ToString();

            object[] Arr1 = new object[listBox1.Items.Count];
            listBox1.Items.CopyTo(Arr1, 0);
            int[] Arr1_ = new int[listBox1.Items.Count];
            for (int k = 0; k < listBox1.Items.Count; k++)
            {
                Arr1_[k] = int.Parse(Arr1[k].ToString());
            }

            object[] Arr2 = new object[listBox2.Items.Count];
            listBox2.Items.CopyTo(Arr2, 0);
            int[] Arr2_ = new int[listBox2.Items.Count];
            for (int k = 0; k < listBox2.Items.Count; k++)
            {
                Arr2_[k] = int.Parse(Arr2[k].ToString());
            }

            int s1 = 0;
            int s2 = 0;

            for (int i = Arr1_.Length - 1; i > 0; i--)
            {
                if (Arr2_[Arr2_.Length - 1] != Arr1_[i])
                {
                    s1++;
                }
                else { break; };
            }
            S1.Text = s1.ToString();


            for (int i = 0; i < Arr2_.Length; i++)
            {
                if (Arr1_[0] != Arr2_[i])
                {
                    s2++;
                }
                else if (Arr1_[0] == Arr2_[i]) { break; };
            }
            S2.Text = s2.ToString();

            Qimpr.Text = (s1 + s2).ToString();

            button2.Visible = false;
            button3.Visible = false;
            textBox1.Visible = false;
            button9.Visible = false;
            button1.Visible = true;
            label3.Text = "Находим Qкрит.:";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] Arr5 = new int[16, 16] {
            {6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {6, 6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {7, 7, 6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {7, 7, 6, 6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {8, 7, 7, 7, 6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, 
            {7, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0, 0, 0, 0, 0},
            {7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0, 0, 0, 0},
            {7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0, 0, 0},
            {8, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0, 0},
            {8, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 0, 0},
            {8, 8, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 0, 0, 0},
            {8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 7, 7, 7, 7, 0, 0},
            {8, 8, 8, 8, 8, 8, 8, 8, 8, 7, 7, 7, 7, 7, 7, 0},
            {8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 7, 7, 7, 7, 7, 7}};


            int[,] Arr1 = new int[16, 16] {
            {9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {9, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {9, 9, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {9, 9, 9, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {9, 9, 9, 9, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {9, 9, 9, 9, 9, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {10, 9, 9, 9, 9, 9, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {10, 10, 9, 9, 9, 9, 9, 9, 0, 0, 0, 0, 0, 0, 0, 0},
            {10, 10, 10, 9, 9, 9, 9, 9, 9, 0, 0, 0, 0, 0, 0, 0},
            {10, 10, 10, 10, 9, 9, 9, 9, 9, 9, 0, 0, 0, 0, 0, 0},
            {11, 10, 10, 10, 9, 9, 9, 9, 9, 9, 9, 0, 0, 0, 0, 0},
            {11, 11, 10, 10, 10, 9, 9, 9, 9, 9, 9, 9, 0, 0, 0, 0},
            {11, 11, 10, 10, 10, 10, 9, 9, 9, 9, 9, 9, 9, 0, 0, 0},
            {12, 11, 11, 10, 10, 10, 10, 9, 9, 9, 9, 9, 9, 9, 0, 0},
            {12, 11, 11, 10, 10, 10, 10, 10, 9, 9, 9, 9, 9, 9, 9, 0},
            {12, 12, 11, 11, 10, 10, 10, 10, 10, 9, 9, 9, 9, 9, 9, 9}};

            for (int i = 0; i < 16; i++)   // строки
            {
                for (int j = 0; j < 16; j++)   //столбцы
                {
                    if (i == listBox2.Items.Count - 11 && j == listBox1.Items.Count - 11)
                    {
                        Qkrit5.Text = Arr5[i, j].ToString();
                    }
                }
            }

            for (int i = 0; i < 16; i++)   // строки
            {
                for (int j = 0; j < 16; j++)   //столбцы
                {
                    if (i == listBox2.Items.Count - 11 && j == listBox1.Items.Count - 11)
                    {
                        Qkrit1.Text = Arr1[i, j].ToString();
                    }
                }
            }

            button1.Visible = false;
            button4.Visible = true;
            label3.Text = "Осталось получить ответ.";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string fileName = "D:\\ММ\\lr7 QUG\\lr7 QUG\\textQ1.txt";
            listBox1.Items.Clear();
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                while (br.PeekChar() != -1)
                {
                    listBox1.Items.Add(br.ReadString());
                }
                br.Close();
                fs.Close();
            }

            string fileName2 = "D:\\ММ\\lr7 QUG\\lr7 QUG\\textQ2.txt";
            listBox2.Items.Clear();
            using (FileStream fs = new FileStream(fileName2, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                while (br.PeekChar() != -1)
                {
                    listBox2.Items.Add(br.ReadString());
                }
                br.Close();
                fs.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(Qimpr.Text) < int.Parse(Qkrit5.Text))
            {
                otv.Text += " Принимается";
            }
            else if (int.Parse(Qimpr.Text) > int.Parse(Qkrit1.Text))
            {
                otv.Text += " Не принимается";
            }
            else if ((int.Parse(Qimpr.Text) >= int.Parse(Qkrit5.Text)) && (int.Parse(Qimpr.Text) <= int.Parse(Qkrit1.Text)))
            {
                otv.Text += " Зона неопределённости";
            }
        }
    }
}
