using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operationPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            //Take the 0 away once user starts clicking buttons
            if ((txtResult.Text == "0") || (operationPressed))
                txtResult.Clear();

            operationPressed = false;
            //Displays the text for each button in TextBox
            Button b = (Button)sender;
            txtResult.Text = txtResult.Text + b.Text;
        }

        private void ClearEverything_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(txtResult.Text);
            operationPressed = true;
            lblEquation.Text = value + " " + operation;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            

            lblEquation.Text = "";
            switch(operation)
            {
                case "+" :
                    txtResult.Text = (value + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (value - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (value * Double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (value / Double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;
            } /*End switch*/
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            value = 0;
        }
    }
}
