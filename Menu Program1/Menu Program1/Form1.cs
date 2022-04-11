using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Program1
    //TWO HOURS ON PROJECT INCREMENTAL 3/31/22
    //FOUR HOURS ON PROJECT INCREMENTAL 4/03/22


{
    public partial class Form1 : Form
    {
        Image chickenrecipe1, steakrecipe1, seafoodrecipe1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Chicken is good!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Steak is Awesome!!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            steakrecipe1 = Image.FromFile("steakrecipe1.jpg");
            pictureBox2.Image = steakrecipe1;
            //IMAGE OF STEAK
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seafoodrecipe1 = Image.FromFile("seafoodrecipe1.png");
            pictureBox3.Image = seafoodrecipe1;
            //IMAGE OF SEAFOOD

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ADDED COMBO BOX FOR CHICKEN TOTAL ITEMS 03/31/22

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ADDED COMBO BOX FOR SEAFOOD TOTAL ITEMS 3/31/22

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ADDED COMBO BOX FOR STEAK TOTAL ITEMS 3/31/22

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //PRICE OF CHICKEN 3/31/22

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //PRICE OF SEAFOOD 3/31/22
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //PRICE OF STEAK 3/31/22

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //TOTAL NUMBER OF ITEMS (DISHES) 3/31/22

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
            //BUTTON GOES TO BILL 3/31/22

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chickenrecipe1 = Image.FromFile("chickenrecipe1.jpg");
            pictureBox1.Image = chickenrecipe1;
            MessageBox.Show("Good Choice");
            //CHECKBOX FOR CHICKEN 4/03/22

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            steakrecipe1 = Image.FromFile("steakrecipe1.jpg");
            pictureBox1.Image = steakrecipe1;
            MessageBox.Show("Excellent Choice");
            //CHECKBOX FOR STEAK 04/03/22
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            seafoodrecipe1 = Image.FromFile("seafoodrecipe1.png");
            pictureBox1.Image = seafoodrecipe1;
            MessageBox.Show("House Specialty");
            //CHECKBOX FOR SEAFOOD 04/03/22
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //CHANGE TO LABEL 04/03/22
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //CHANGE TO LABEL 04/03/22
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //CHANGE TO LABEL 04/03/22
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //CHANGED TO LABEL 04/06/22
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //CHAGED TO LABEL 04/06/22
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //CHAGED TO LABEL 04/06/22
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://cafedelites.com/oven-baked-chicken-breast");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://natashaskitchen.com/pan-seared-steak/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.dinneratthezoo.com/seafood-boil-recipe/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chickenrecipe1 = Image.FromFile("chickenrecipe1.jpg");
            pictureBox1.Image = chickenrecipe1;
            //IMAGE OF CHICKEN

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Seafood is out of this world!!");
        }
    }
}
