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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            float num1 = 0, num2 = 0, ans = 0;
            num1 = float.Parse(textBox1.Text);
            num2 = float.Parse(textBox2.Text);
            ans = num1 + num2;
            textBox3.Text = ans.ToString();
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            float num1 = 0, num2 = 0, ans = 0;
            num1 = float.Parse(textBox1.Text);
            num2 = float.Parse(textBox2.Text);
            ans = num1 - num2;
            textBox3.Text = ans.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            float num1 = 0, num2 = 0, ans = 0;
            num1 = float.Parse(textBox1.Text);
            num2 = float.Parse(textBox2.Text);
            ans = num1 * num2;
            textBox3.Text = ans.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*float num1 = 0, num2 = 0, ans = 0;
            num1 = float.Parse(textBox1.Text);
            num2 = float.Parse(textBox2.Text);
            ans = num1 / num2;
            textBox3.Text = ans.ToString();*/

            textBox3.Text = ((float.Parse(textBox1.Text)) / (float.Parse(textBox2.Text))).ToString();
        }

        private void RemButton_Click(object sender, EventArgs e)
        {
            float num1 = 0, num2 = 0, ans = 0;
            num1 = float.Parse(textBox1.Text);
            num2 = float.Parse(textBox2.Text);
            ans = num1 % num2;
            textBox3.Text = ans.ToString();
        }
    }
}
