using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        // The result of the mathematical operation will be stored in this variable
        decimal result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {
            // Add the two numeric values
            result = numericUpDown1.Value + numericUpDown2.Value;

            // Display the result
            label2.Text = result.ToString();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            // Subtract the second number from the first
            result = numericUpDown1.Value - numericUpDown2.Value;

            // Display the result
            label2.Text = result.ToString(); 
        }

        public void button2_Click(object sender, EventArgs e)
        {
            // Multiply the two numeric values
            result = numericUpDown1.Value * numericUpDown2.Value;

            // Display the result
            label2.Text = result.ToString(); 
        }

        public void button4_Click(object sender, EventArgs e)
        {
            // Check if the user is trying to divide by zero
            if (numericUpDown2.Value == 0)
            {
                // Display a message saying that division by zero is not possible
                label2.Text = "Division by zero is not possible";
            }
            else
            {
                // Perform division
                result = numericUpDown1.Value / numericUpDown2.Value;

                // Display the result
                label2.Text = result.ToString();
            }
        }
    }
}
