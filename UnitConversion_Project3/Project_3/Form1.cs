using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class unitConverter : Form
    {   //Initialize the variables
        double input;               //double variable to hold the user input
        double output;              //double variable to hold the calculated output
        string from;                //string variable to hold the unit being converted from
        string to;                  //string variable to hold the unit being converted to.

        public unitConverter()
        {
            InitializeComponent();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {   //Catch exceptions caused by user input and validate the input. 
            try
            {
                //Make sure the input is a number
                input = double.Parse(inputTextBox.Text);
                //Make sure that the number is greater than 0
                if (input < 0)
                {
                    MessageBox.Show("Please enter a value greater than zero.");
                }
            }
            catch (Exception ex)
            {   //Show the default error message if the input is not a number
                MessageBox.Show(ex.Message);
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {   //If a unit from each list box is selected, calculate the output
            if (fromListBox.SelectedIndex != -1 && toListBox.SelectedIndex != -1)
            {
                //Get the units from the list boxes
                from = fromListBox.SelectedItem.ToString();
                to = toListBox.SelectedItem.ToString();

                //Determine which formula to use
                switch (from)
                {   //If the distance to convert FROM is inches
                    case "Inches":
                            //Convert to inches
                        if (to == "Inches")
                        {output = input;}
                            //Convert to feet
                        else if (to == "Feet")
                        {output = input / 12;}
                            //Convert to yards
                        else if (to == "Yards")
                        {output = input / 36;}
                        break;
                    //If the distance to convert FROM is feet
                    case "Feet":
                            //Convert to inches
                        if (to == "Inches")
                        {output = input * 12;}
                            //Convert to feet
                        else if (to == "Feet")
                        {output = input;}
                            //Convert to yards
                        else if (to == "Yards")
                        {output = input / 3;}
                        break;
                    //If the distance to convert FROM is yards
                    case "Yards":
                            //Convert to inches
                        if (to == "Inches")
                        {output = input * 36;}
                            //Convert to feet
                        else if (to == "Feet")
                        {output = input * 3;}
                            //Convert to yards
                        else if (to == "Yards")
                        {output = input;}
                        break;
                }

                //Display the output in the output label
                calculationLabel.Text = output.ToString("n2");
                //Display the selected to in the unit label
                unitLabel.Text = toListBox.SelectedItem.ToString();
            }
            //If no value has been entered to convert
            else if (input == 0)
            {
                MessageBox.Show("Please enter a value to convert");
            }
            //Make sure that the list box items have been selected
            else
            {
                MessageBox.Show("Please select units from the lists");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the from
            this.Close();
        }
    }
}
