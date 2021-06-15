using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                Add.Enabled = true;
                SUBTRACT.Enabled = false;
                Multiply.Enabled = false;


            }
            else {
                MessageBox.Show("Nothing Clicked !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, sum;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox1.Text);
            sum = num1 + num2;
            label3.Text = " Thr  Sum of Two numbers is : " + sum;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                Add.Enabled = false;
                SUBTRACT.Enabled = true;
                Multiply.Enabled = false;


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1, num2, product;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            product= num1 * num2;
            label3.Text = " Thr  Product of Two numbers is : " + product;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double nums1, nums2;
            double different;
            nums1 = Convert.ToDouble(textBox1.Text);
            nums2 = Convert.ToInt32(textBox2.Text);
            different = nums1 - nums2;
            label3.Text = " The  Diefference of Two numbers is : " + different;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Multiply.Enabled = true;
                Add.Enabled = false;
                SUBTRACT.Enabled = false;
          

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // WinForms app
            // WinForms app
            System.Windows.Forms.Application.Exit();

        }
    }
}
