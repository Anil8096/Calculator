using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double result = 0;
        string operation = "";
        bool enter_value = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void number_only(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (textBox1.Text == "0" || (enter_value))
                textBox1.Text = "";
            enter_value = false;

            if(b.Text==".")
            {
                if(!textBox1.Text.Contains("."))
                {
                    textBox1.Text += b.Text;
                }
            }
            else
            {
                textBox1.Text += b.Text;
            }

        }

        private void Arthemetics(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if(result!=0)
            {
                buttonEqual.PerformClick();
                enter_value = true;
                operation = b.Text;
                labelOp.Text = Convert.ToString(result) + "   " + operation;

            }    
            else
            {
                operation = b.Text;
                result = Double.Parse(textBox1.Text);
                enter_value = true;
                labelOp.Text = Convert.ToString(result) + "   " + operation;
            }
            
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            labelOp.Text = "";
            switch(operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "X":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = double.Parse(textBox1.Text);
            operation = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if(textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            labelOp.Text = "";
        }
    }
}
