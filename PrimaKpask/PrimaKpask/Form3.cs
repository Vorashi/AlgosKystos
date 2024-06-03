using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaKpask
{
    public partial class Form3 : Form
    {
        private Form1 osnokno;
        public Form3(int columnCount, Form1 form)
        {
            InitializeComponent();
            this.osnokno = form;

            // Задаем количество букв, которые будут отображены в Combobox
            int lettersCount = columnCount;

            // Заполняем первый Combobox алфавитом
            for (char c = 'A'; c < 'A' + lettersCount; c++)
            {
                comboBox1.Items.Add(c);
            }

            // Дублируем выбор для второго Combobox
            foreach (var item in comboBox1.Items)
            {
                comboBox2.Items.Add(item);
            }
        }
        private List<char> unavailableLetters = new List<char>();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            char selectedLetter = (char)comboBox1.SelectedItem;

            if (comboBox2.Items.Contains(selectedLetter))
            {
                if (!unavailableLetters.Contains(selectedLetter))
                {
                    unavailableLetters.Add(selectedLetter); // Добавить выбранную букву в список недоступных букв
                }
                comboBox2.Items.Remove(selectedLetter);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (char letter in unavailableLetters)
            {
                if (!comboBox2.Items.Contains(letter))
                {
                    comboBox2.Items.Add(letter); // Добавить букву обратно, если она стала доступной при открытии выпадающего списка
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char columnChar = comboBox1.SelectedItem.ToString()[0];
            char rowChar = comboBox2.SelectedItem.ToString()[0];
            int number = int.Parse(textBox1.Text);

            osnokno.InsertData(columnChar, rowChar, number);
        }
    }
}
