using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr7_QUG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            FormU FormU = new FormU();
            FormU.ShowDialog();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            FormQ FormQ = new FormQ();
            FormQ.ShowDialog();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            FormG FormG = new FormG();
            FormG.ShowDialog();
        }
    }
}
