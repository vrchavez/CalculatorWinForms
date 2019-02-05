using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoWorkWinforms
{
    public partial class Form1 : Form
    {
        //Current value of all executed operations
        Double value = 0;

        //Current operation
        String operation = "";
        //bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){}

        //Called whenever a NUMBER button is clicked
        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") /*|| (operation_pressed)*/)
                result.Clear();

            string s = (sender as Button).Text;
            result.Text = result.Text + s;
        }

        //Called when CE button is clicked. Clears value and result of calculator. 
        private void buttonCE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }

        //Called when operator button is clicked. 
        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value == 0 || operation == "" )
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                //operation_pressed = true;
                equation.Text = value + " " + operation;
                result.Clear();
                return;
            } else
            {
                switch (operation)
                {
                    case "+":
                        equation.Text = (value + Double.Parse(result.Text)).ToString();
                        value = value + Double.Parse(result.Text);
                        break;
                    case "-":
                        equation.Text = (value - Double.Parse(result.Text)).ToString();
                        value = value - Double.Parse(result.Text);
                        break;
                    case "/":
                        equation.Text = (value / Double.Parse(result.Text)).ToString();
                        value = value / Double.Parse(result.Text);
                        break;
                    case "*":
                        equation.Text = (value * Double.Parse(result.Text)).ToString();
                        value = value * Double.Parse(result.Text);
                        break;
                }
                operation = b.Text;
                //operation_pressed = true;
                result.Clear();
            }
        }

        //Called when '=' button is clicked. Executes operation and current result.
        private void equals_Click(object sender, EventArgs e)
        {
            //operation_pressed = false;
            equation.Text = "";
            switch(operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    value = value + Double.Parse(result.Text);
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    value = value - Double.Parse(result.Text);
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    value = value / Double.Parse(result.Text);
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    value = value * Double.Parse(result.Text);
                    break;
            }
            operation = "";
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }
    }
}
