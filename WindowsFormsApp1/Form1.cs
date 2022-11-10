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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string opeartion = "";
        double result = 0;
        bool isopearetion = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch (opeartion)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;
                
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (textBox1.Text == "0" || isopearetion==true) 
            { textBox1.Clear();
            }
            if(but.Text == ".")
            {
                if(!textBox1.Text.Contains(".")) 
                { 
                    textBox1.Text = textBox1.Text + but.Text; 
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + but.Text;
                isopearetion = false;
            }
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            opeartion = but.Text;
            result = double.Parse(textBox1.Text);
            isopearetion = true;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
        }
    }
}
