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

        //private float num1 = 0;
        private bool AddButton_clicked = false;

        public void button1_Click(object sender, EventArgs e)
        {
            float num1 = 0;
            richTextBox1.Text += "1";
            num1 = float.Parse(richTextBox1.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void num2_Click(object sender, EventArgs e)
        {
            float num2 = 0;
            richTextBox1.Text += "2";
            num2 = float.Parse(richTextBox1.Text);
           
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
            float ans;
            if(AddButton_clicked)
            {
                ans = num1 + num2;
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }
    }
}
