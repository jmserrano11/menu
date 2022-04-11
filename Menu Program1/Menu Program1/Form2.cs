using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Menu_Program1
{
    public partial class Form2 : Form
    {
        int num1, num2, num3;
        double tax;
        double tip;
        double sum;
        double total;


        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //CHANGE IN TEXT 04/03/22
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
            //BUTTON GOES TO MENU 3/31/22
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //CHANGE IN TEXT 04/03/22
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //CHANGE IN TEXT 04/03/22
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //CHAGED TO LABEL 04/06/22
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //CHAGED TO LABEL 04/06/22
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //CHAGED TO LABEL 04/06/22
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //CHAGED TO LABEL 04/06/22
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //CHAGED TO LABEL 04/06/22
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //CHAGED TO LABEL 04/06/22
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //CHAGED TO LABEL 04/06/22

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox4.Text, out num1))
            {
                if (int.TryParse(textBox5.Text, out num2))
                {
                    if (int.TryParse(textBox6.Text, out num3))
                    {
                        num1 = num1 * 10;
                        num2 = num2 * 12;
                        num3 = num3 * 15;

                        
                        
                            sum = num1 + num2 + num3;
                        tax = sum * .10;
                        textBox8.Text = tax.ToString();
                        tip = sum * .20;
                        textBox10.Text = tip.ToString();
                        total = sum + tax + tip;
                        textBox15.Text = sum.ToString();
                        textBox12.Text = total.ToString();


                           
                        
                        textBox15.Text = sum.ToString();

                    }
                }
            }

        }
    }
}
