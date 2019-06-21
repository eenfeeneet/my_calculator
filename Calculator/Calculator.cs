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
    public partial class Calculator : Form
    {
        public double ans, num1;
        public int count;      


        public Calculator()
        {
            InitializeComponent();
        }

        public void calculate()
        {
            switch (count)
            {
                case 1:
                    ans = num1 + Double.Parse(textBoxInput.Text);
                    textBoxInput.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + Double.Parse(textBoxInput.Text);
                    textBoxInput.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 + Double.Parse(textBoxInput.Text);
                    textBoxInput.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 + Double.Parse(textBoxInput.Text);
                    textBoxInput.Text = ans.ToString();
                    break;
                default:
                    break;

            }
        }
        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
           textBoxInput.Show();                        
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "9";
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + ".";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBoxInput.Text);
            textBoxInput.Clear();
            count = 1;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBoxInput.Text);
            textBoxInput.Clear();
            count = 2;
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBoxInput.Text);
            textBoxInput.Clear();
            count = 3;
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBoxInput.Text);
            textBoxInput.Clear();
            count = 4;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //int length = textBoxInput.TextLength - 1;
            //string text = textBoxInput.Text;
            //textBoxInput.Clear();
            //for (int i = 0; i < length; i++)
            //    textBoxInput.Text = textBoxInput.Text + text[i];

            string text = textBoxInput.Text.Remove(1, 1);
            textBoxInput.Text = textBoxInput.Text + "0";


        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            calculate();
        }
    }
}
