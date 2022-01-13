using System;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class tipCalculator : Form
    {
        public tipCalculator()
        {
            InitializeComponent();
        }


        private void tipIncButton_Click(object sender, EventArgs e)
        {
            //Try Catch block for exception handling
            try
            {
                //Storing Values
                int tipPercent = int.Parse(tipPercentTextBox.Text);
                double billAmt = double.Parse(billAmtTextBox.Text);
                int people = int.Parse(peopleTextBox.Text);

                
                if (tipPercent < 100)       // Tip should not be more than 100
                {
                    tipPercent += 1;         // Increase Tip Percent by 1 
                }
                else
                {
                    tipErrorLabel.Text = "Tip cannot be greater than 100 !";
                    var t = new System.Windows.Forms.Timer();
                    t.Interval = 3000;       // Timer for 3 seconds
                    t.Tick += (s, e) =>
                    {
                        tipErrorLabel.Text = "";
                        t.Stop();
                    };
                    t.Start();
                }

                //Performing Calculations
                double tip = ((billAmt * tipPercent) / (double)100) / people;
                double tipPerPerson = (billAmt / people) + tip;

                //Updating changes 
                tipPercentTextBox.Text = tipPercent.ToString();
                tipCalcLabel.Text = tip.ToString();
                totalCalcLabel.Text = tipPerPerson.ToString();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Input string was not in a correct format.")
                {
                    billErrorLabel.Text = "Please input valid number !";
                }
                else
                    billErrorLabel.Text = "Please try again !";

                //Resetting the labels
                tipCalcLabel.Text = "";
                totalCalcLabel.Text = "";
            }
            
        }


        private void tipDecButton_Click(object sender, EventArgs e)
        {
            //Try Catch block for exception handling
            try
            {
                //Storing Values
                int tipPercent = int.Parse(tipPercentTextBox.Text);
                double billAmt = double.Parse(billAmtTextBox.Text);
                int people = int.Parse(peopleTextBox.Text);

                
                if (tipPercent > 0)             // Tip percent cannot be less than zero 
                {
                    tipPercent -= 1;            // Subtract 1 from the tip percent
                }
                else
                {
                    tipErrorLabel.Text = "Tip cannot be less than zero !";
                    var t = new System.Windows.Forms.Timer();
                    t.Interval = 3000;          // Timer for 3 seconds
                    t.Tick += (s, e) =>
                    {
                        tipErrorLabel.Text = "";
                        t.Stop();
                    };
                    t.Start();
                }

                //Performing Calculations
                double tip = ((billAmt * tipPercent) / (double)100) / people;
                double tipPerPerson = (billAmt / people) + tip;

                //Updating changes 
                tipPercentTextBox.Text = tipPercent.ToString();
                tipCalcLabel.Text = tip.ToString();
                totalCalcLabel.Text = tipPerPerson.ToString();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Input string was not in a correct format.")
                {
                    billErrorLabel.Text = "Please input valid number !";
                }
                else
                    billErrorLabel.Text = "Please try again !";

                //Resetting the labels
                tipCalcLabel.Text = "";
                totalCalcLabel.Text = "";
            }
           

        }



        private void peopleIncButton_Click(object sender, EventArgs e)
        {
            //Try Catch block for exception handling
            try
            {
                //Storing Values
                int tipPercent = int.Parse(tipPercentTextBox.Text);
                double billAmt = double.Parse(billAmtTextBox.Text);
                int people = int.Parse(peopleTextBox.Text);

                people += 1;                //Add 1 to 

                //Performing Calculations
                double tip = ((billAmt * tipPercent) / (double)100) / people;
                double tipPerPerson = (billAmt / people) + tip;

                //Updating Changes
                peopleTextBox.Text = people.ToString();
                tipCalcLabel.Text = tip.ToString();
                totalCalcLabel.Text = tipPerPerson.ToString();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Input string was not in a correct format.")
                {
                    billErrorLabel.Text = "Please input valid number !";
                }
                else
                    billErrorLabel.Text = "Please try again !";

                //Resetting the labels
                tipCalcLabel.Text = "";
                totalCalcLabel.Text = "";
            }
            

        }

        private void peopleDecButton_Click(object sender, EventArgs e)
        {
            //Try Catch block for exception handling
            try
            {
                //Storing Values
                int tipPercent = int.Parse(tipPercentTextBox.Text);
                double billAmt = double.Parse(billAmtTextBox.Text);
                int people = int.Parse(peopleTextBox.Text);
                if (people > 1)                 //People should not be less than 1
                {
                    people -= 1;                // Subtract 1 from people
                }
                else
                {
                    peopleErrorLabel.Text = "People cannot be less than one !";
                    var t = new System.Windows.Forms.Timer();
                    t.Interval = 3000;          // Timer for 3 seconds
                    t.Tick += (s, e) =>
                    {
                        peopleErrorLabel.Text = "";
                        t.Stop();
                    };
                    t.Start();
                }

                //Performing Calculations
                double tip = ((billAmt * tipPercent) / (double)100) / people;
                double tipPerPerson = (billAmt / people) + tip;

                //Updating changes 
                peopleTextBox.Text = people.ToString();
                tipCalcLabel.Text = tip.ToString();
                totalCalcLabel.Text = tipPerPerson.ToString();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Input string was not in a correct format.")
                {
                    billErrorLabel.Text = "Please input valid number !";
                }
                else
                    billErrorLabel.Text = "Please try again !";

                //Resetting the labels
                tipCalcLabel.Text = "";
                totalCalcLabel.Text = "";
            }

        }


        private void billAmtTextBox_TextChanged(object sender, EventArgs e)
        {
            //Try Catch block for exception handling
            try
            {
                //Checking for negative values
                if (billAmtTextBox.Text.Contains('-'))
                {
                    billErrorLabel.Text = "Bill Amount cannot be negative";
                    tipCalcLabel.Text = "";
                    totalCalcLabel.Text = "";
                }
                //Checking for Empty Field
                else if (String.IsNullOrWhiteSpace(billAmtTextBox.Text))
                {
                    billErrorLabel.Text = "Bill Amount cannot be empty";
                    tipCalcLabel.Text = "";
                    totalCalcLabel.Text = "";
                }
                else
                {

                    billErrorLabel.Text = "";

                    //Storing Values
                    int tipPercent = int.Parse(tipPercentTextBox.Text);
                    double billAmt = double.Parse(billAmtTextBox.Text);
                    int people = int.Parse(peopleTextBox.Text);

                    //Performing Calculations
                    double tip = ((billAmt * tipPercent) / (double)100) / people;
                    double tipPerPerson = (billAmt / people) + tip;

                    //Updating changes 
                    tipCalcLabel.Text = tip.ToString();
                    totalCalcLabel.Text = tipPerPerson.ToString();
                }

            }
            catch (Exception ex)
            {
                if (ex.Message == "Input string was not in a correct format.")
                {
                    billErrorLabel.Text = "Please input valid number !";
                }
                else
                    billErrorLabel.Text = "Please try again !";

                //Resetting the labels
                tipCalcLabel.Text = "";
                totalCalcLabel.Text = "";
            }

        }

        


    }
}