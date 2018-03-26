using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare the constants.
                const decimal MINIMUM_SALARY = 40000m;
                const int MINIMUM_YEARS_ON_JOB = 2;

                //Local variables.
                decimal salary;
                int yearsOnJob;

                //Get the salary and years on the job.
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                //Detremine whether the user qualifies.
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        //The user qualifies.
                        decisionLabel.Text = "You qualify for the loan.";
                    }
                    else
                    {
                        //The user does not qualify.
                        decisionLabel.Text = "Minimum years at current job not met.";
                    }



                }
                else
                {
                    //The user does not qualify.
                    decisionLabel.Text = "Minimum salary requirement not met.";

                }

            }
            catch (Exception ex)
            {
                //Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears the TextBoxes and the decisionLabel control.
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            //Reset the focus.
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
