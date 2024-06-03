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
    public partial class FormS : Form
    {
        public FormS()
        {
            InitializeComponent();
        }
        public static int s1 = 0;
        public static int s2 = 0;
        public static int s3 = 0;
        public static int s4 = 0;


        public static int k1_ = 0;
        public static int k2_ = 0;
        public static int k3_ = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            string fileName = "D:\\ММ\\lr8 LS\\lr8 LS\\textS1.txt";
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

            string fileName2 = "D:\\ММ\\lr8 LS\\lr8 LS\\textS2.txt";
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

            string fileName4 = "D:\\ММ\\lr8 LS\\lr8 LS\\textS4.txt";
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

            string fileName6 = "D:\\ММ\\lr8 LS\\lr8 LS\\textS6.txt";
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

            string fileName8 = "D:\\ММ\\lr8 LS\\lr8 LS\\textS8.txt";
            listBox8.Items.Clear();
            using (FileStream fs = new FileStream(fileName8, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                while (br.PeekChar() != -1)
                {
                    listBox8.Items.Add(br.ReadString());
                }
                br.Close();
                fs.Close();
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

        private void button5_Click(object sender, EventArgs e)
        {
            listBox8.Items.Add(textBox1.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            listBox3.SelectedIndex = listBox1.SelectedIndex;
            listBox4.SelectedIndex = listBox1.SelectedIndex;
            listBox5.SelectedIndex = listBox1.SelectedIndex;
            listBox6.SelectedIndex = listBox1.SelectedIndex;
            listBox7.SelectedIndex = listBox1.SelectedIndex;
            listBox8.SelectedIndex = listBox1.SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex;
            listBox3.SelectedIndex = listBox2.SelectedIndex;
            listBox4.SelectedIndex = listBox2.SelectedIndex;
            listBox5.SelectedIndex = listBox2.SelectedIndex;
            listBox6.SelectedIndex = listBox2.SelectedIndex;
            listBox7.SelectedIndex = listBox2.SelectedIndex;
            listBox8.SelectedIndex = listBox2.SelectedIndex;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox3.SelectedIndex;
            listBox1.SelectedIndex = listBox3.SelectedIndex;
            listBox4.SelectedIndex = listBox3.SelectedIndex;
            listBox5.SelectedIndex = listBox3.SelectedIndex;
            listBox6.SelectedIndex = listBox3.SelectedIndex;
            listBox7.SelectedIndex = listBox3.SelectedIndex;
            listBox8.SelectedIndex = listBox3.SelectedIndex;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox4.SelectedIndex;
            listBox3.SelectedIndex = listBox4.SelectedIndex;
            listBox1.SelectedIndex = listBox4.SelectedIndex;
            listBox5.SelectedIndex = listBox4.SelectedIndex;
            listBox6.SelectedIndex = listBox4.SelectedIndex;
            listBox7.SelectedIndex = listBox4.SelectedIndex;
            listBox8.SelectedIndex = listBox4.SelectedIndex;
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox5.SelectedIndex;
            listBox3.SelectedIndex = listBox5.SelectedIndex;
            listBox4.SelectedIndex = listBox5.SelectedIndex;
            listBox1.SelectedIndex = listBox5.SelectedIndex;
            listBox6.SelectedIndex = listBox5.SelectedIndex;
            listBox7.SelectedIndex = listBox5.SelectedIndex;
            listBox8.SelectedIndex = listBox5.SelectedIndex;
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox6.SelectedIndex;
            listBox3.SelectedIndex = listBox6.SelectedIndex;
            listBox4.SelectedIndex = listBox6.SelectedIndex;
            listBox5.SelectedIndex = listBox6.SelectedIndex;
            listBox1.SelectedIndex = listBox6.SelectedIndex;
            listBox7.SelectedIndex = listBox6.SelectedIndex;
            listBox8.SelectedIndex = listBox6.SelectedIndex;
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox7.SelectedIndex;
            listBox3.SelectedIndex = listBox7.SelectedIndex;
            listBox4.SelectedIndex = listBox7.SelectedIndex;
            listBox1.SelectedIndex = listBox7.SelectedIndex;
            listBox6.SelectedIndex = listBox7.SelectedIndex;
            listBox5.SelectedIndex = listBox7.SelectedIndex;
            listBox8.SelectedIndex = listBox7.SelectedIndex;
        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox8.SelectedIndex;
            listBox3.SelectedIndex = listBox8.SelectedIndex;
            listBox4.SelectedIndex = listBox8.SelectedIndex;
            listBox1.SelectedIndex = listBox8.SelectedIndex;
            listBox6.SelectedIndex = listBox8.SelectedIndex;
            listBox7.SelectedIndex = listBox8.SelectedIndex;
            listBox5.SelectedIndex = listBox8.SelectedIndex;
        }

        private void button11_Click(object sender, EventArgs e)
        {
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

            object[] Arr8 = new object[listBox8.Items.Count];
            listBox8.Items.CopyTo(Arr8, 0);
            int[] Arr8_ = new int[listBox8.Items.Count];
            for (int k = 0; k < listBox8.Items.Count; k++)
            {
                Arr8_[k] = int.Parse(Arr8[k].ToString());
            }

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                s1 += Arr2_[i];
            }
            S1.Text = s1.ToString();

            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                s2 += Arr4_[i];
            }
            S2.Text = s2.ToString();

            for (int i = 0; i < listBox6.Items.Count; i++)
            {
                s3 += Arr6_[i];
            }
            S3.Text = s3.ToString();

            for (int i = 0; i < listBox8.Items.Count; i++)
            {
                s4 += Arr8_[i];
            }
            S4.Text = s4.ToString();

            label9.Text = "Далее расставим суммы в порядке возрастания:";
            button11.Visible = false;
            button6.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            textBox1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
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
            object[] Arr8 = new object[listBox8.Items.Count];
            listBox8.Items.CopyTo(Arr8, 0);
            int[] Arr8_ = new int[listBox8.Items.Count];
            for (int k = 0; k < listBox8.Items.Count; k++)
            {
                Arr8_[k] = int.Parse(Arr8[k].ToString());
            }
                        
            listBox2.Items.Clear();
            listBox4.Items.Clear();
            listBox6.Items.Clear();
            listBox8.Items.Clear();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (s1 < s2 && s2 < s3 && s3 < s4)
                {
                    listBox2.Items.Add(Arr2_[i]);
                    listBox4.Items.Add(Arr4_[i]);
                    listBox6.Items.Add(Arr6_[i]);
                    listBox8.Items.Add(Arr8_[i]);
                }
                else if (s1 < s2 && s2 < s4 && s4 < s3)  
                {
                    listBox2.Items.Add(Arr2_[i]);
                    listBox4.Items.Add(Arr4_[i]);
                    listBox6.Items.Add(Arr8_[i]);
                    listBox8.Items.Add(Arr6_[i]);
                    string s = S3.Text;
                    S3.Text = S4.Text;
                    S4.Text = s;
                }
                else if (s1 < s3 && s3 < s2 && s2 < s4)
                {
                    listBox2.Items.Add(Arr2_[i]);
                    listBox4.Items.Add(Arr6_[i]);
                    listBox6.Items.Add(Arr4_[i]);
                    listBox8.Items.Add(Arr8_[i]);
                    string s = S3.Text;
                    S3.Text = S2.Text;
                    S2.Text = s;
                }
                else if (s2 < s1 && s1 < s3 && s3 < s4)
                {
                    listBox2.Items.Add(Arr4_[i]);
                    listBox4.Items.Add(Arr2_[i]);
                    listBox6.Items.Add(Arr6_[i]);
                    listBox8.Items.Add(Arr8_[i]);
                    string s = S2.Text;
                    S2.Text = S1.Text;
                    S1.Text = s;
                }
                else if (s3 < s2 && s2 < s1 && s1 < s4)
                {
                    listBox2.Items.Add(Arr6_[i]);
                    listBox4.Items.Add(Arr4_[i]);
                    listBox6.Items.Add(Arr2_[i]);
                    listBox8.Items.Add(Arr8_[i]);
                    string s = S3.Text;
                    S3.Text = S1.Text;
                    S1.Text = s;
                }
                else if (s4 < s2 && s2 < s3 && s3 < s1)
                {
                    listBox2.Items.Add(Arr8_[i]);
                    listBox4.Items.Add(Arr4_[i]);
                    listBox6.Items.Add(Arr6_[i]);
                    listBox8.Items.Add(Arr2_[i]);
                    string s = S1.Text;
                    S1.Text = S4.Text;
                    S4.Text = s;
                }
                else if (s1 < s4 && s4 < s3 && s3 < s2)
                {
                    listBox2.Items.Add(Arr2_[i]);
                    listBox4.Items.Add(Arr8_[i]);
                    listBox6.Items.Add(Arr6_[i]);
                    listBox8.Items.Add(Arr4_[i]);
                    string s = S2.Text;
                    S2.Text = S4.Text;
                    S4.Text = s;
                }
            }

            object[] Arr2_1 = new object[listBox2.Items.Count];
            listBox2.Items.CopyTo(Arr2_1, 0);
            int[] Arr2_2 = new int[listBox2.Items.Count];
            for (int k = 0; k < listBox2.Items.Count; k++)
            {
                Arr2_2[k] = int.Parse(Arr2_1[k].ToString());
            }
            object[] Arr4_1 = new object[listBox4.Items.Count];
            listBox4.Items.CopyTo(Arr4_1, 0);
            int[] Arr4_2 = new int[listBox4.Items.Count];
            for (int k = 0; k < listBox4.Items.Count; k++)
            {
                Arr4_2[k] = int.Parse(Arr4_1[k].ToString());
            }
            object[] Arr6_1 = new object[listBox6.Items.Count];
            listBox6.Items.CopyTo(Arr6_1, 0);
            int[] Arr6_2 = new int[listBox6.Items.Count];
            for (int k = 0; k < listBox6.Items.Count; k++)
            {
                Arr6_2[k] = int.Parse(Arr6_1[k].ToString());
            }
            object[] Arr8_1 = new object[listBox8.Items.Count];
            listBox8.Items.CopyTo(Arr8_1, 0);
            int[] Arr8_2 = new int[listBox8.Items.Count];
            for (int k = 0; k < listBox8.Items.Count; k++)
            {
                Arr8_2[k] = int.Parse(Arr8_1[k].ToString());
            }

            listBox2.Items.Clear();
            listBox4.Items.Clear();
            listBox6.Items.Clear();
            listBox8.Items.Clear();

            int l, t = 0;
            for (int i = 0; i < Arr2_2.Length; i++)
            {
                l = MaxNumber(Arr2_2, i);
                t = Arr2_2[i];
                Arr2_2[i] = Arr2_2[l];
                Arr2_2[l] = t;
                listBox2.Items.Add(Arr2_2[i]);
            }
            int l2, t2 = 0;
            for (int i = 0; i < Arr4_2.Length; i++)
            {
                l2 = MaxNumber(Arr4_2, i);
                t2 = Arr4_2[i];
                Arr4_2[i] = Arr4_2[l2];
                Arr4_2[l2] = t2;
                listBox4.Items.Add(Arr4_2[i]);
            }
            int l3, t3 = 0;
            for (int i = 0; i < Arr6_2.Length; i++)
            {
                l3 = MaxNumber(Arr6_2, i);
                t3 = Arr6_2[i];
                Arr6_2[i] = Arr6_2[l3];
                Arr6_2[l3] = t3;
                listBox6.Items.Add(Arr6_2[i]);
            }
            int l4, t4 = 0;
            for (int i = 0; i < Arr8_2.Length; i++)
            {
                l4 = MaxNumber(Arr8_2, i);
                t4 = Arr8_2[i];
                Arr8_2[i] = Arr8_2[l4];
                Arr8_2[l4] = t4;
                listBox8.Items.Add(Arr8_2[i]);
            }

            label9.Text = "Добавим кол-во более высоких значений справа:";
            button6.Visible = false;
            button7.Visible = true;
        }
        private int MaxNumber(int[] x, int m)  
        {
            int max = x[m];
            int MaxN = m;
            for (int i = m; i < x.Length; i++)
            {
                if (x[i] < max)
                {
                    max = x[i];
                    MaxN = i;
                }
            }
            return MaxN;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox3.Visible = true;
            listBox5.Visible = true;
            listBox7.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

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
            object[] Arr8 = new object[listBox8.Items.Count];
            listBox8.Items.CopyTo(Arr8, 0);
            int[] Arr8_ = new int[listBox8.Items.Count];
            for (int k = 0; k < listBox8.Items.Count; k++)
            {
                Arr8_[k] = int.Parse(Arr8[k].ToString());
            }

            int[] Arr9 = new int[Arr4_.Length + Arr6_.Length + Arr8_.Length];
            Arr4_.CopyTo(Arr9, 0);
            Arr6_.CopyTo(Arr9, Arr4_.Length);
            Arr8_.CopyTo(Arr9, Arr6_.Length + Arr4_.Length);

            int k1 = 0;
            for (int j = 0; j < Arr2_.Length; j++)
            {
                for (int i = 0; i < Arr9.Length; i++)
                {
                    if (Arr2_[j] < Arr9[i])
                    {
                        k1++;
                    }
                }
                listBox3.Items.Add(k1);
                k1_ += k1;
                k1 = 0;
            }
            K1.Text = k1_.ToString();

            int[] Arr10 = new int[Arr6_.Length + Arr8_.Length];
            Arr6_.CopyTo(Arr10, 0);
            Arr8_.CopyTo(Arr10, Arr6_.Length);

            int k2 = 0;
            for (int j = 0; j < Arr4_.Length; j++)
            {
                for (int i = 0; i < Arr10.Length; i++)
                {
                    if (Arr4_[j] < Arr10[i])
                    {
                        k2++;
                    }
                }
                listBox5.Items.Add(k2);
                k2_ += k2;
                k2 = 0;
            }
            K2.Text = k2_.ToString();

            int k3 = 0;
            for (int j = 0; j < Arr6_.Length; j++)
            {
                for (int i = 0; i < Arr8_.Length; i++)
                {
                    if (Arr6_[j] < Arr8_[i])
                    {
                        k3++;
                    }
                }
                listBox7.Items.Add(k3);
                k3_ += k3;
                k3 = 0;
            }
            K3.Text = k3_.ToString();

            label9.Text = "Далее найдём значения A и В, а также: Sэмп.; S0,05; S0,01:";
            button7.Visible = false;
            button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = k1_ + k2_ + k3_;
            A.Text += k1_ + "+" + k2_ + "+" + k3_ + "= " + a;

            int b = (4 * 3) / 2 * listBox1.Items.Count * listBox1.Items.Count;
            B.Text += "(4*3)/2 * " + (listBox1.Items.Count * listBox1.Items.Count) + "= " + b;

            Simp.Text = (2 * a - b).ToString();

            int[] Arr5 = new int[9] { 14, 26, 38, 51, 66, 82, 100, 118, 138 };

            int[] Arr1 = new int[9] { 20, 34, 50, 71, 92, 115, 140, 167, 195 };

            S005.Text = Arr5[listBox1.Items.Count - 2].ToString();
            S001.Text = Arr1[listBox1.Items.Count - 2].ToString();

            label9.Text = "Осталось получить ответ.";
            button8.Visible = false;
            button9.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (double.Parse(Simp.Text) >= int.Parse(S001.Text))
            {
                otv.Text += " Принимается";
            }
            if (double.Parse(Simp.Text) < int.Parse(S005.Text))
            {
                otv.Text += " Не принимается";
            }
            if ((double.Parse(Simp.Text) < int.Parse(S001.Text)) && (double.Parse(Simp.Text) > int.Parse(S005.Text)))
            {
                otv.Text += " Зона неопределённости";
            }
        }
    }
}
