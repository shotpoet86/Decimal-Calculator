//Programmer: Austin Parker
//Date: June 22,2020
//Assignment: Ch12/ PE 8/ Decimal Calculator
//Purpose: created a calculator for PE 7 to show example of exception handling for division in PE8

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecimalCalculatorCh12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declared variables
        decimal numerator;
        decimal denominator;
        string num = "";
        string denom = "";
        bool flag = false;
        decimal result;

        //Connects number buttons 0-9 using if statements
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                num += "1";
            }
            else
            {
                denom = "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                num += "2";
            }
            else
            {
                denom = "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                num += "3";
            }
            else
            {
                denom = "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                num += "4";
            }
            else
            {
                denom = "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                num += "5";
            }
            else
            {
                denom = "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                num += "6";
            }
            else
            {
                denom = "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                num += "7";
            }
            else
            {
                denom = "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                num += "8";
            }
            else
            {
                denom = "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                num += "9";
            }
            else
            {
                denom = "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                num += "0";
            }
            else
            {
                denom = "0";
            }

        }
        
        private void divideButton_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Converts numbers to decimal
            numerator = Convert.ToDecimal(num);
            denominator = Convert.ToDecimal(denom);

            //Here is where program will throw the error and notify user "0" action is not possible in calculator
            try
            {
                result = numerator / denominator;
                resultTextBox.Text = Convert.ToString(result);
            }

            catch
            { 
                MessageBox.Show("Division by zero is not possible because it's a non-integral value");
            }
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = string.Empty;
        }
    }
}

