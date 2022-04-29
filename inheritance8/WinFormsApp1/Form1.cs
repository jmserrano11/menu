using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        class addshoe
        {
            protected string color;
            protected double size;
            
            public addshoe(string Color, double Size)
            {
                this.color = Color;
                this.size = Size;
                //MessageBox.Show("inside type constructor " + color + " " + size);
            }
            public void display()
            {
                MessageBox.Show("inside size display " + color + " " + size);
                return;
            }
            public string getcolor()
            {
                return color;
            }
            public double getsize()
            {
                return size;
            }

        }
        class boot : addshoe
        {
            private string type ;

            
            public boot(string type, string Color, double Size) : base (Color,Size)
            {
                this.type = type;
            }
            public void displayboot()
            {
                base.display();
                MessageBox.Show("in boot display " + type.ToString());
               
            }
        }
        
        class addsandal : addshoe
        {
            private string type;


            public addsandal(string thong, string type) : base(thong, 0)
            {
                this.type = type;
            }
            public void displaytype()
            {
                base.display();
                MessageBox.Show("in sandal display " + type);

            }
        }
        public Form1()

        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addshoe shoe1 = new(textBox1.Text, double.Parse(textBox2.Text));
            shoe1.display();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            boot boot1 = new(textBox3.Text, textBox1.Text, double.Parse(textBox2.Text));
                //:base(textBox1.Text, double.Parse(textBox2.Text));
            boot1.displayboot();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addsandal sandal1 = new(textBox3.Text, textBox4.Text);
            sandal1.display();
            Console.WriteLine("hello");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
