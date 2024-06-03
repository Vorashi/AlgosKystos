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

namespace lr8_LS
{
    public partial class FormL : Form
    {
        public FormL()
        {
            InitializeComponent();
        }

        public static double T1 = 0;
        public static double T2 = 0;
        public static double T3 = 0;

        private void button10_Click(object sender, EventArgs e)
        {
            string fileName = "D:\\ММ\\lr8 LS\\lr8 LS\\textL1.txt";
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

            string fileName2 = "D:\\ММ\\lr8 LS\\lr8 LS\\textL2.txt";
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
            string fileName4 = "D:\\ММ\\lr8 LS\\lr8 LS\\textL4.txt";
            listBox4.Items.Clear();
            using (FileStream fs = new FileStream(fileName4, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                while (br.PeekChar() != -1)
                {
                    listBox4.Items.Add(br.ReadString());
                }
                br.Close();
                fs.Close();
            }

            string fileName6 = "D:\\ММ\\lr8 LS\\lr8 LS\\textL6.txt";
            listBox6.Items.Clear();
            using (FileStream fs = new FileStream(fileName6, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                while (br.PeekChar() != -1)
                {
                    listBox6.Items.Add(br.ReadString());
                }
                br.Close();
                fs.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.Visible = true;
            listBox5.Visible = true;
            listBox7.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            object[] Arr2 = new object[listBox2.Items.Count];
            listBox2.Items.CopyTo(Arr2, 0);
            int[] Arr2_ = new int[listBox2.Items.Count];
            for (int k = 0; k < listBox2.Items.Count; k++)
            {
                Arr2_[k] = int.Parse(Arr2[k].ToString());
            }
            object[] Arr4 = new object[listBox4.Items.Count];
            listBox4.Items.CopyTo(Arr4, 0);
            int[] Arr4_ = new int[listBox4.Items.Count];
            for (int k = 0; k < listBox4.Items.Count; k++)
            {
                Arr4_[k] = int.Parse(Arr4[k].ToString());
            }
            object[] Arr6 = new object[listBox6.Items.Count];
            listBox6.Items.CopyTo(Arr6, 0);
            int[] Arr6_ = new int[listBox6.Items.Count];
            for (int k = 0; k < listBox6.Items.Count; k++)
            {
                Arr6_[k] = int.Parse(Arr6[k].ToString());
            }


            for (int i = 0; i < Arr2_.Length; i++)
            {
                if (Arr2_[i] > Arr4_[i] && Arr2_[i] > Arr6_[i] && Arr4_[i] > Arr6_[i])
                {
                    listBox3.Items.Add(3);
                    listBox5.Items.Add(2);
                    listBox7.Items.Add(1);
                }
                else if (Arr2_[i] > Arr4_[i] && Arr2_[i] > Arr6_[i] && Arr4_[i] < Arr6_[i])
                {
                    listBox3.Items.Add(3);
                    listBox5.Items.Add(1);
                    listBox7.Items.Add(2);
                }
                else if (Arr2_[i] > Arr4_[i] && Arr2_[i] < Arr6_[i] && Arr4_[i] < Arr6_[i])
                {
                    listBox3.Items.Add(2);
                    listBox5.Items.Add(1);
                    listBox7.Items.Add(3);
                }
                else if (Arr2_[i] < Arr4_[i] && Arr2_[i] < Arr6_[i] && Arr4_[i] < Arr6_[i])
                {
                    listBox3.Items.Add(1);
                    listBox5.Items.Add(2);
                    listBox7.Items.Add(3);
                }
                else if (Arr2_[i] < Arr4_[i] && Arr2_[i] > Arr6_[i] && Arr4_[i] > Arr6_[i])
                {
                    listBox3.Items.Add(2);
                    listBox5.Items.Add(3);
                    listBox7.Items.Add(1);
                }
                else if (Arr2_[i] < Arr4_[i] && Arr2_[i] < Arr6_[i] && Arr4_[i] > Arr6_[i])
                {
                    listBox3.Items.Add(1);
                    listBox5.Items.Add(3);
                    listBox7.Items.Add(2);
                }
                else if (Arr2_[i] == Arr4_[i] && Arr2_[i] == Arr6_[i] && Arr4_[i] == Arr6_[i])
                {
                    listBox3.Items.Add(2);
                    listBox5.Items.Add(2);
                    listBox7.Items.Add(2);
                }
                else if (Arr2_[i] == Arr4_[i] && Arr2_[i] < Arr6_[i])
                {
                    listBox3.Items.Add(1.5);
                    listBox5.Items.Add(1.5);
                    listBox7.Items.Add(3);
                }
                else if (Arr2_[i] == Arr4_[i] && Arr2_[i] > Arr6_[i])
                {
                    listBox3.Items.Add(2.5);
                    listBox5.Items.Add(2.5);
                    listBox7.Items.Add(1);
                }
                else if (Arr2_[i] == Arr6_[i] && Arr2_[i] < Arr4_[i])
                {
                    listBox3.Items.Add(1.5);
                    listBox5.Items.Add(3);
                    listBox7.Items.Add(1.5);
                }
                else if (Arr2_[i] == Arr6_[i] && Arr2_[i] > Arr4_[i])
                {
                    listBox3.Items.Add(1.5);
                    listBox5.Items.Add(1);
                    listBox7.Items.Add(1.5);
                }
                else if (Arr4_[i] == Arr6_[i] && Arr4_[i] > Arr2_[i])
                {
                    listBox3.Items.Add(1);
                    listBox5.Items.Add(2.5);
                    listBox7.Items.Add(2.5);
                }
                else if (Arr4_[i] == Arr6_[i] && Arr4_[i] < Arr2_[i])
                {
                    listBox3.Items.Add(3);
                    listBox5.Items.Add(1.5);
                    listBox7.Items.Add(1.5);
                }
                label8.Text = "Определим ранговые суммы и сравним их с расчётной суммой:";
                button6.Visible = false;
                button5.Visible = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            listBox3.SelectedIndex = listBox1.SelectedIndex;
            listBox4.SelectedIndex = listBox1.SelectedIndex;
            listBox5.SelectedIndex = listBox1.SelectedIndex;
            listBox6.SelectedIndex = listBox1.SelectedIndex;
            listBox7.SelectedIndex = listBox1.SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex;
            listBox3.SelectedIndex = listBox2.SelectedIndex;
            listBox4.SelectedIndex = listBox2.SelectedIndex;
            listBox5.SelectedIndex = listBox2.SelectedIndex;
            listBox6.SelectedIndex = listBox2.SelectedIndex;
            listBox7.SelectedIndex = listBox2.SelectedIndex;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox3.SelectedIndex;
            listBox1.SelectedIndex = listBox3.SelectedIndex;
            listBox4.SelectedIndex = listBox3.SelectedIndex;
            listBox5.SelectedIndex = listBox3.SelectedIndex;
            listBox6.SelectedIndex = listBox3.SelectedIndex;
            listBox7.SelectedIndex = listBox3.SelectedIndex;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox4.SelectedIndex;
            listBox3.SelectedIndex = listBox4.SelectedIndex;
            listBox1.SelectedIndex = listBox4.SelectedIndex;
            listBox5.SelectedIndex = listBox4.SelectedIndex;
            listBox6.SelectedIndex = listBox4.SelectedIndex;
            listBox7.SelectedIndex = listBox4.SelectedIndex;
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox5.SelectedIndex;
            listBox3.SelectedIndex = listBox5.SelectedIndex;
            listBox4.SelectedIndex = listBox5.SelectedIndex;
            listBox1.SelectedIndex = listBox5.SelectedIndex;
            listBox6.SelectedIndex = listBox5.SelectedIndex;
            listBox7.SelectedIndex = listBox5.SelectedIndex;
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox6.SelectedIndex;
            listBox3.SelectedIndex = listBox6.SelectedIndex;
            listBox4.SelectedIndex = listBox6.SelectedIndex;
            listBox5.SelectedIndex = listBox6.SelectedIndex;
            listBox1.SelectedIndex = listBox6.SelectedIndex;
            listBox7.SelectedIndex = listBox6.SelectedIndex;
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox7.SelectedIndex;
            listBox3.SelectedIndex = listBox7.SelectedIndex;
            listBox4.SelectedIndex = listBox7.SelectedIndex;
            listBox5.SelectedIndex = listBox7.SelectedIndex;
            listBox6.SelectedIndex = listBox7.SelectedIndex;
            listBox1.SelectedIndex = listBox7.SelectedIndex;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            label9.Visible = true;
            label11.Visible = true;

            object[] Arr3 = new object[listBox3.Items.Count];
            listBox3.Items.CopyTo(Arr3, 0);
            double[] Arr3_ = new double[listBox3.Items.Count];
            for (int k = 0; k < listBox3.Items.Count; k++)
            {
                Arr3_[k] = double.Parse(Arr3[k].ToString());
            }
            object[] Arr5 = new object[listBox5.Items.Count];
            listBox5.Items.CopyTo(Arr5, 0);
            double[] Arr5_ = new double[listBox5.Items.Count];
            for (int k = 0; k < listBox5.Items.Count; k++)
            {
                Arr5_[k] = double.Parse(Arr5[k].ToString());
            }
            object[] Arr7 = new object[listBox7.Items.Count];
            listBox7.Items.CopyTo(Arr7, 0);
            double[] Arr7_ = new double[listBox7.Items.Count];
            for (int k = 0; k < listBox7.Items.Count; k++)
            {
                Arr7_[k] = double.Parse(Arr7[k].ToString());
            }

            for (int i = 0; i < Arr3_.Length; i++)
            {
                T1 += Arr3_[i];
            }
            label12.Text = T1.ToString();

            for (int i = 0; i < Arr5_.Length; i++)
            {
                T2 += Arr5_[i];
            }
            label13.Text = T2.ToString();

            for (int i = 0; i < Arr7_.Length; i++)
            {
                T3 += Arr7_[i];
            }
            label14.Text = T3.ToString();

            Rsummrang.Text = (T1 + T2 + T3).ToString();

            Rrasch.Text = (listBox1.Items.Count * (3 * 4 / 2)).ToString();

            if (Rrasch.Text == Rsummrang.Text)                
            {
                Rez.Text = Rrasch.Text + " = " + Rsummrang.Text;
            }

            label8.Text = "Расположим все условия в порядке возрастания их ранговых сумм в таблице:";
            button5.Visible = false;
            button7.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            object[] Arr3 = new object[listBox3.Items.Count];
            listBox3.Items.CopyTo(Arr3, 0);
            double[] Arr3_ = new double[listBox3.Items.Count];
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                Arr3_[i] = double.Parse(Arr3[i].ToString());
            }
            object[] Arr5 = new object[listBox5.Items.Count];
            listBox5.Items.CopyTo(Arr5, 0);
            double[] Arr5_ = new double[listBox5.Items.Count];
            for (int i = 0; i < listBox5.Items.Count; i++)
            {
                Arr5_[i] = double.Parse(Arr5[i].ToString());
            }
            object[] Arr7 = new object[listBox7.Items.Count];
            listBox7.Items.CopyTo(Arr7, 0);
            double[] Arr7_ = new double[listBox7.Items.Count];
            for (int i = 0; i < listBox7.Items.Count; i++)
            {
                Arr7_[i] = double.Parse(Arr7[i].ToString());
            }
            listBox3.Items.Clear();
            listBox5.Items.Clear();
            listBox7.Items.Clear();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (T2 > T1 && T2 > T3 && T3 > T1 || T3 > T2 && T3 > T1 && T1 < T2)
                {
                    listBox5.Items.Add(Arr7_[i]);
                    listBox7.Items.Add(Arr5_[i]);
                    listBox3.Items.Add(Arr3_[i]);
                }
                else if (T2 > T1 && T2 > T3 && T3 < T1 || T1 > T2 && T1 > T3 && T3 < T2) 
                {
                    listBox5.Items.Add(Arr3_[i]);
                    listBox7.Items.Add(Arr7_[i]);
                    listBox3.Items.Add(Arr5_[i]);
                }
                else if (T1 > T2 && T1 > T3 && T3 > T2 || T3 > T2 && T3 > T1 && T1 > T2)
                {
                    listBox5.Items.Add(Arr5_[i]);
                    listBox7.Items.Add(Arr3_[i]);
                    listBox3.Items.Add(Arr7_[i]);
                }
            }

            if (T2 > T1 && T2 > T3 && T3 > T1 || T3 > T2 && T3 > T1 && T1 < T2)
            {
                label10.Text = "T3 = ";
                label11.Text = "T2 = ";
                string p = label13.Text;
                label13.Text = label14.Text;
                label14.Text = p;
            }
                        
            label8.Text = "Определим Lэмп., L0,001, L0,01 и L0,05:";
            button7.Visible = false;
            button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label17.Text += "1*" + label12.Text + "+ 2*" + label13.Text + "+ 3*" + label14.Text + " = ";
            Limp.Text = (1 * double.Parse(label12.Text) + 2 * double.Parse(label13.Text) + 3 * double.Parse(label14.Text)).ToString();

            int[,] Arr = new int[11, 3] {{ 0, 0, 28 },
            {0,42,41},
            {56,55,54},
            {70,68,66},
            {83,81,79},
            {96,93,91},
            {109,106,104},
            {121,119,116},
            {134,131,128},
            {147,144,141 },
            {160,156,153} };

            L0001.Text = Arr[listBox1.Items.Count - 2, 0].ToString();
            L001.Text = Arr[listBox1.Items.Count - 2, 1].ToString();
            L005.Text = Arr[listBox1.Items.Count - 2, 2].ToString();

            label8.Text = "Осталось получить ответ.";
            button8.Visible = false;
            button9.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (double.Parse(Limp.Text) >= int.Parse(L001.Text))
            {
                otv.Text += " Принимается";
            }
            if (double.Parse(Limp.Text) < int.Parse(L005.Text))
            {
                otv.Text += " Не принимается";
            }
            if ((double.Parse(Limp.Text) < int.Parse(L001.Text)) && (double.Parse(Limp.Text) > int.Parse(L005.Text)))
            {
                otv.Text += " Зона неопределённости";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add(textBox1.Text);
        }

     
    }
}
