using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator_M
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void num2_Click(object sender, EventArgs e)
        {

            richTextBox1.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "+";
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "-";
        }

        public void EqualButton_Click(object sender, EventArgs e)
        {
            if (AddButton_clicked)
            {

            }
        }
    }
}
