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
        float number1, number2;
        public bool AddButton_clicked = false;
        public Form2()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            number1 = 1;
            richTextBox1.Text += "1";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void num2_Click(object sender, EventArgs e)
        {

            richTextBox1.Text += "2";
            number2 = 2;
           
        }

        private void num3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "+";
            AddButton_clicked = true;
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "-";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            float ans;
            if(AddButton_clicked)
            {
                ans = number1 + number2;
                richTextBox1.Text = ans.ToString();
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }
    }
}
