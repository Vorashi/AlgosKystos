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
    public partial class FormU : Form
    {
        public FormU()
        {
            InitializeComponent();
        }
        public static int nx = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add(textBox1.Text);
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

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox6.SelectedIndex = listBox5.SelectedIndex;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button10.Visible = false;

            //сортирует значения от большего к меньшему 
            int raz = listBox2.Items.Count + listBox4.Items.Count;
            object[] Arr1 = new object[raz];
            listBox4.Items.CopyTo(Arr1, 0);
            listBox2.Items.CopyTo(Arr1, listBox4.Items.Count);
            int[] Arr = new int[raz];
            for (int i = 0; i < raz; i++)
            {
                Arr[i] = int.Parse(Arr1[i].ToString());
            }
            int k, t;
            for (int i = 0; i < raz; i++)
            {
                k = MaxNumber(Arr, i);
                t = Arr[i];
                Arr[i] = Arr[k];
                Arr[k] = t;
                listBox5.Items.Add(Arr[i]);
            }
           
            // добавляет ранги
            int count = 0;
            int rang1 = 0;
            object[] Arr2 = new object[listBox5.Items.Count];
            listBox5.Items.CopyTo(Arr2, 0);
            int[] Arr_ = new int[listBox5.Items.Count];
            for (int i = 0; i < listBox5.Items.Count; i++)
            {
                Arr_[i] = int.Parse(Arr2[i].ToString());
            }

            // считает первый
            listBox6.Items.Add(1);

            // считает все элементы кроме первого и последнего
            for (int i = 1; i < Arr_.Length - 1; i++)
            {
                if (Arr_[i] == Arr_[i + 1] || Arr_[i] == Arr_[i - 1])
                {
                    int T = Arr_[i];
                    for (int j = 0; j < Arr_.Length; j++)
                    {
                        if (Arr_[j] == T)
                        {
                            rang1 += j + 1;
                            count++;
                        }
                    }
                    listBox6.Items.Add((rang1 * 1.0) / count);
                    count = 0;
                    rang1 = 0;
                }
                else if (Arr_[i] != Arr_[i + 1])
                {
                    listBox6.Items.Add(i + 1);
                }
            }

            // считает только последний 
            if (Arr_[Arr_.Length - 1] == Arr_[Arr_.Length - 2])
            {
                listBox6.Items.Add(listBox6.Items[Arr_.Length - 2]);
            }
            else { listBox6.Items.Add(Arr_.Length); }


            button5.Visible = false;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Суммы
            int l1 = 0;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                l1 += int.Parse(listBox2.Items[i].ToString());
            }
            sr1.Text = l1.ToString();

            int l2 = 0;
            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                l2 += int.Parse(listBox4.Items[i].ToString());
            }
            sr2.Text = l2.ToString();

            object[] Arr1 = new object[listBox5.Items.Count];
            listBox5.Items.CopyTo(Arr1, 0);
            int[] Arr = new int[listBox5.Items.Count];
            for (int k = 0; k < listBox5.Items.Count; k++)
            {
                Arr[k] = int.Parse(Arr1[k].ToString());
            }

            object[] Arr2 = new object[listBox2.Items.Count];
            listBox2.Items.CopyTo(Arr2, 0);
            int[] Arr3 = new int[listBox2.Items.Count];
            for (int s = 0; s < listBox2.Items.Count; s++)
            {
                Arr3[s] = int.Parse(Arr2[s].ToString());
            }

            object[] Arr6 = new object[listBox4.Items.Count];
            listBox4.Items.CopyTo(Arr6, 0);
            int[] Arr7 = new int[listBox4.Items.Count];
            for (int s = 0; s < listBox4.Items.Count; s++)
            {
                Arr7[s] = int.Parse(Arr6[s].ToString());
            }

            object[] Arr4 = new object[listBox6.Items.Count];
            listBox6.Items.CopyTo(Arr4, 0);
            double[] Arr5 = new double[listBox6.Items.Count];
            for (int s1 = 0; s1 < listBox6.Items.Count; s1++)
            {
                Arr5[s1] = double.Parse(Arr4[s1].ToString());
            }

            double l = 0;
            if (int.Parse(sr1.Text) > int.Parse(sr2.Text))
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    for (int j = 0; j < listBox5.Items.Count; j++)
                    {
                        if (Arr3[i] == Arr[j])
                        {
                            l += Arr5[j];
                            break;
                        }
                    }
                }
                bol.Text = l.ToString();
                nx = listBox2.Items.Count;
            }
            else
            {
                for (int i = 0; i < listBox4.Items.Count; i++)
                {
                    for (int j = 0; j < listBox5.Items.Count; j++)
                    {
                        if (Arr7[i] == Arr[j])
                        {
                            l += Arr5[j];
                            break;
                        }
                    }
                }
                bol.Text = l.ToString();
                nx = listBox4.Items.Count;
            }
            button6.Visible = false;
            button7.Visible = true;
            groupBox3.Text = "Затем необходимо определить значение U по формуле:";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            krit.Text = (listBox2.Items.Count * listBox4.Items.Count + (nx * (nx + 1)) / 2 - double.Parse(bol.Text)).ToString();
            groupBox3.Text = "Затем необходимо определить критические значения.:";
            button8.Visible = true;
            button7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[,] Arr5 = new int[21, 19] { { 0, 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7 },
                { 0, 0, 0, 0, 0, 0, 0, 3, 4, 4, 5, 6, 7, 8, 9, 10, 11, 11, 12 },
                { 0, 0, 0, 0, 0, 0, 0, 5, 6, 7, 8, 9, 11, 12, 13, 14, 15, 17, 18 },
                { 0, 0, 0, 0, 0, 0, 0, 6, 8, 10, 11, 13, 14, 16, 17, 19, 21, 22, 24 },
                { 0, 0, 0, 0, 0, 0, 0, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 },
                { 0, 0, 0, 0, 0, 0, 0, 10, 13, 15, 17, 19, 22, 24, 26, 29, 31, 34, 36 },
                { 0, 0, 0, 0, 0, 0, 0, 12, 15, 17, 20, 23, 26, 28, 30, 34, 37, 39, 42 },
                { 0, 0, 0, 0, 0, 0, 0, 14, 17, 20, 23, 26, 29, 33, 36, 39, 42, 45, 48 },
                { 0, 0, 0, 0, 0, 0, 0, 16, 19, 23, 26, 30, 33, 37, 40, 44, 48, 51, 55 },
                { 0, 0, 0, 0, 0, 0, 0, 18, 22, 26, 29, 33, 37, 41, 45, 49, 53, 57, 61 },
                { 0, 0, 0, 0, 0, 0, 0, 20, 24, 28, 33, 37, 41, 45, 50, 54, 59, 63, 67 },
                { 0, 0, 0, 0, 0, 0, 0, 22, 26, 31, 36, 40, 45, 50, 55, 59, 64, 67, 74 },
                { 0, 0, 0, 0, 0, 0, 0, 24, 29, 34, 39, 44, 49, 54, 59, 64, 70, 75, 80 },
                { 0, 0, 0, 0, 0, 0, 0, 26, 31, 37, 42, 47, 53, 59, 64, 70, 75, 81, 86 },
                { 0, 0, 0, 0, 0, 0, 0, 28, 34, 39, 45, 51, 57, 63, 67, 75, 81, 87, 93 },
                { 0, 0, 0, 0, 0, 0, 0, 30, 36, 42, 48, 55, 61, 67, 74, 80, 86, 93, 99 },
                { 0, 0, 0, 0, 0, 0, 0, 32, 38, 45, 52, 58, 65, 72, 78, 85, 92, 99, 106 },
                { 0, 0, 0, 0, 0, 0, 0, 34, 41, 48, 55, 62, 69, 76, 83, 90, 98, 105, 112 }};


            int[,] Arr1 = new int[21, 19] { { 0, 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 2 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 2, 2, 3, 3, 4, 5, 5, 6, 6 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 4, 6, 7, 7, 8, 9, 10, 11 },
                { 0, 0, 0, 0, 0, 0, 0, 3, 4, 5, 6, 6, 9, 10, 11, 12, 13, 15, 16 },
                { 0, 0, 0, 0, 0, 0, 0, 4, 6, 7, 9, 9, 12, 13, 15, 16, 18, 19, 21 },
                { 0, 0, 0, 0, 0, 0, 0, 6, 7, 9, 11, 11, 15, 17, 18, 20, 22, 24, 26 },
                { 0, 0, 0, 0, 0, 0, 0, 7, 9, 11, 13, 13, 18, 20, 22, 24, 27, 29, 31 },
                { 0, 0, 0, 0, 0, 0, 0, 9, 11, 13, 16, 16, 21, 24, 26, 29, 31, 34, 37 },
                { 0, 0, 0, 0, 0, 0, 0, 10, 13, 16, 18, 18, 24, 27, 30, 33, 36, 39, 42 },
                { 0, 0, 0, 0, 0, 0, 0, 12, 15, 18, 21, 21, 27, 31, 34, 37, 41, 44, 47 },
                { 0, 0, 0, 0, 0, 0, 0, 13, 17, 20, 24, 24, 31, 34, 38, 42, 45, 49, 53 },
                { 0, 0, 0, 0, 0, 0, 0, 15, 18, 22, 26, 26, 34, 38, 42, 46, 50, 54, 58 },
                { 0, 0, 0, 0, 0, 0, 0, 16, 20, 24, 29, 29, 37, 42, 46, 51, 55, 60, 64 },
                { 0, 0, 0, 0, 0, 0, 0, 18, 22, 27, 31, 31, 41, 45, 50, 55, 60, 65, 70 },
                { 0, 0, 0, 0, 0, 0, 0, 19, 24, 29, 34, 34, 44, 49, 54, 60, 65, 70, 75 },
                { 0, 0, 0, 0, 0, 0, 0, 21, 26, 31, 37, 37, 47, 53, 58, 64, 70, 75, 81 },
                { 0, 0, 0, 0, 0, 0, 0, 22, 28, 33, 39, 39, 51, 56, 63, 69, 74, 81, 87 },
                { 0, 0, 0, 0, 0, 0, 0, 24, 30, 36, 42, 42, 54, 60, 67, 73, 79, 86, 92 }};

                       
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (i == listBox2.Items.Count && j == listBox4.Items.Count)
                    {
                        Ukrit5.Text = Arr5[i, j].ToString();
                    }
                }
            }

            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (i == listBox2.Items.Count && j == listBox4.Items.Count)
                    {
                        Ukrit1.Text = Arr1[i, j].ToString();
                    }
                }
            }
            groupBox3.Text = "Осталось получить ответ.";
            button9.Visible = true;
            button8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (double.Parse(krit.Text) > int.Parse(Ukrit5.Text))
            {
                otv.Text += " Принимается";
            }
            if (double.Parse(krit.Text) < int.Parse(Ukrit1.Text))
            {
                otv.Text += " Не принимается";
            }
            if ((double.Parse(krit.Text) < int.Parse(Ukrit5.Text)) && (double.Parse(krit.Text) > int.Parse(Ukrit1.Text)))
            {
                otv.Text += " Зона неопределённости";
            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox5.SelectedIndex = listBox6.SelectedIndex;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            string fileName = "D:\\ММ\\lr7 QUG\\lr7 QUG\\text1.txt";
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

            string fileName2 = "D:\\ММ\\lr7 QUG\\lr7 QUG\\text2.txt";
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

            string fileName3 = "D:\\ММ\\lr7 QUG\\lr7 QUG\\text3.txt";
            listBox3.Items.Clear();
            using (FileStream fs = new FileStream(fileName3, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                while (br.PeekChar() != -1)
                {
                    listBox3.Items.Add(br.ReadString());
                }
                br.Close();
                fs.Close();
            }

            string fileName4 = "D:\\ММ\\lr7 QUG\\lr7 QUG\\text4.txt";
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
        }
    }
}
