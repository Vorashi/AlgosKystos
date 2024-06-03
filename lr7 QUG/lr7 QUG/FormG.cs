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
    public partial class FormG : Form
    {
        public FormG()
        {
            InitializeComponent();
        }
        public static int pologhit = 0;
        public static int otric = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Visible = true;
            label3.Visible = true;

            object[] Arr1 = new object[listBox1.Items.Count];
            listBox1.Items.CopyTo(Arr1, 0);
            int[] Arr1_ = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Arr1_[i] = int.Parse(Arr1[i].ToString());
            }

            object[] Arr2 = new object[listBox2.Items.Count];
            listBox2.Items.CopyTo(Arr2, 0);
            int[] Arr2_ = new int[listBox2.Items.Count];
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                Arr2_[i] = int.Parse(Arr2[i].ToString());
            }

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox3.Items.Add(Arr2_[i] - Arr1_[i]);
            }

            label4.Text = "После необходимо опредилить типичные и нетипичные сдвиги:";
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            textBox1.Visible = false;
            button4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object[] Arr3 = new object[listBox3.Items.Count];
            listBox3.Items.CopyTo(Arr3, 0);
            int[] Arr3_ = new int[listBox3.Items.Count];
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                Arr3_[i] = int.Parse(Arr3[i].ToString());
            }

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (Arr3_[i] > 0)
                {
                    pologhit++;
                }
                else if (Arr3_[i] < 0)
                {
                    otric++;
                }
            }

            if (pologhit > otric)
            {
                tip.Text = pologhit.ToString();
                netip.Text = otric.ToString();
            }
            else if (otric > pologhit)
            {
                tip.Text = otric.ToString();
                netip.Text = pologhit.ToString();
            }
            label4.Text = "Далее необходимо найти критические значения G.";
            button4.Visible = false;
            button5.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox3.SelectedIndex;
            listBox1.SelectedIndex = listBox3.SelectedIndex;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] Arr5 = new int[26] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 3, 3, 3, 4, 4, 5, 5, 5, 6, 6, 7, 7, 7 };
            int[] Arr1 = new int[26] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 4, 4, 4, 5, 5, 5, 6 };

            int n = pologhit + otric;

            for (int i = 0; i < 26; i++)
            {
                if (i == n)
                {
                    Gkrit5.Text = Arr5[i].ToString();
                }
            }

            for (int i = 0; i < 26; i++)
            {
                if (i == n)
                {
                    Gkrit1.Text = Arr1[i].ToString();
                }
            }
            label4.Text = "Осталось получить ответ.";
            button5.Visible = false;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (int.Parse(netip.Text) > int.Parse(Gkrit5.Text))
            {
                otv.Text += " Принимается";
            }
            if (int.Parse(netip.Text) <= int.Parse(Gkrit5.Text))
            {
                otv.Text += " Не принимается";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string fileName = "D:\\ММ\\lr7 QUG\\lr7 QUG\\textG1.txt";
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

            string fileName2 = "D:\\ММ\\lr7 QUG\\lr7 QUG\\textG2.txt";
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
    }
}
