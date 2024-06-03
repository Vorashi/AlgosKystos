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
    public partial class Form2 : Form
    {
        private Form1 osnokno;
        public Form2(Form1 form)
        {
            InitializeComponent();
            osnokno = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            osnokno.shapka(Convert.ToInt32(textBox1.Text));
            Close();
        }
    }
}
