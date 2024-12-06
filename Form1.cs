using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //összeadás
            textBox1.Text += "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kivonás
            textBox1.Text += "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //szorzás
            textBox1.Text += "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //osztás
            textBox1.Text += "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //eggyenlöségjel
            DataTable dt = new DataTable();
            textBox1.Text = dt.Compute(textBox1.Text,"").ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //0
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //1
            textBox1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //2
            textBox1.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //3
            textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //4
            textBox1.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //5
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //6
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //7
            textBox1.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //8
            textBox1.Text += "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //9
            textBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //back space
            string text = textBox1.Text;
            text = text.Remove( text.Length - 1,1);
            textBox1.Text = text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //clear
            textBox1.Clear();
        }
    }
}
