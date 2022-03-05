using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator_GitHub_
{
    public partial class Calculator : Form
    {
        Double result = 0;
        String operation = "";
        bool operationPerformed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void number_clicked(object sender, EventArgs e)
        {
            //Button sender (number)
            Button button = (Button)sender;

 
            if (textBox.Text == "0" || operationPerformed)
            {
                textBox.Text =  button.Text;
            }
            
            else { 
                textBox.Text = textBox.Text + button.Text;
            }

            operationPerformed = false;
        }

        private void operat_clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(textBox.Text);
            operationLabel.Text = result + " " + operation;
            operationPerformed = true;
        }

        private void cEntryButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
            operationLabel.Text = "";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox.Text = (result + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (result - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (result * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (result / Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;




            }
        }
    }
}
