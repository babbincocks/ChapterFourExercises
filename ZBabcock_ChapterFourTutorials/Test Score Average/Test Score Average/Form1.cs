using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a constant, and several variables.
                const double HIGH_SCORE = 95.0;
                double test1, test2, test3, average;

                //Get the test scores from the TextBoxes.
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                //Calculate the average test score.
                average = (test1 + test2 + test3) / 3.0;

                //Display the average, rounded to 2 decimal places.
                averageLabel.Text = average.ToString("n1");

                //If the average is a high score, congratulate the user with a message box.
                if (average > HIGH_SCORE)
                {
                    MessageBox.Show("Congratulations! Great Job!");
                }


            }
            catch (Exception ex)
            {
                //Display the default error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the TextBoxes and the averageLabel control.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            //Reset the focus to the test1 control.
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
