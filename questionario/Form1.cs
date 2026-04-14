using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace questionario
{
    public partial class Form1 : Form
    {       public int certo;
            public int errado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            certo = 0;
            errado = 0;
            button1.Enabled = false;
            button1.Enabled = true;
            button1.Enabled = true;
            button1.Enabled = true;
            button1.Enabled = true;
            button1.Enabled = true;
            button1.Enabled = true;
            button1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            certo = certo + 1;
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            errado = errado + 1;
            button2.Enabled = false;
            button3.Enabled = false;



        }

        private void button4_Click(object sender, EventArgs e)
        {

            errado = errado + 1;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            certo = certo + 1;
            button4.Enabled = false;
            button5.Enabled = false;
        }
    }
}
