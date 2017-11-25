using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knittingCalculator
{
    public partial class knittingCalculator : Form
    {
        public knittingCalculator()
        {
            InitializeComponent();
        }

    /** Section for the first tab**/
        private void calculateYardageButton_Click(object sender, EventArgs e)
        {
            //define the variables and arrays
            double patternYardage = 0;                                                  //double variable to hold the input pattern yardage
            double yardage = 0; double price = 0;
            double skeins = 0; double cost = 0;
            const int ROWS = 4;    
            Label[,] lArray = { {yarn1SkeinLabel, yarn1CostLabel},                       //array to hold the output labels
                                { yarn2SkeinLabel, yarn2CostLabel }, 
                                { yarn3SkeinLabel, yarn3CostLabel }, 
                                { yarn4SkeinLabel, yarn4CostLabel } };
            TextBox[,] tArray = { { yarn1SkeinTextBox,yarn1PriceTextBox},                //array to hold the input textboxes
                                  { yarn2SkeinTextBox,yarn2PriceTextBox},
                                  { yarn3SkeinTextBox,yarn3PriceTextBox},
                                   {yarn4SkeinTextBox,yarn4PriceTextBox} };

            //get the input from the pattern yaradge text box and make sure it is valid
            if (!double.TryParse(patternYardageTextBox.Text, out patternYardage))
            {MessageBox.Show("Please enter a numeric value greater than zero");}
            //make sure the input isn't a negative number
            if (patternYardage < 0)
            { MessageBox.Show("Please enter a numeric value greater than zero"); }

            //for each of the rows of input
            for (int i = 0; i < ROWS; i++)
             {
                //Initalize the variables to back zero
               yardage = 0; price = 0;
               skeins = 0; cost = 0;

                //Validate the yardage input and make sure there are no exceptions
                if (double.TryParse(tArray[i, 0].Text, out yardage))
                {
                    if (yardage < 0)
                    { MessageBox.Show("Please enter a numeric value greater than zero"); }
                }
                else
                { MessageBox.Show("Please enter a numeric value greater than zero"); }

                //Validate the price input and make sure there are no exceptions
                if (double.TryParse(tArray[i, 1].Text, out price))
                {
                    //make sure the input is a positive number
                    if (price < 0)
                    { MessageBox.Show("Please enter a numeric value greater than zero");}
                }
                else
                { MessageBox.Show("Please enter a numeric value greater than zero");}

                //do not allow divison by zero
                if (yardage == 0)
                { MessageBox.Show("Please enter a numeric value"); }
                else
                {
                    //number of skeins is equal to the pattern yardage devided by the yardage per skein
                    skeins = patternYardage / yardage;
                }

                //the field was left 'blank'
                if ((yardage == 0) || (price == 0))
                {
                    skeins = 0;
                    cost = 0;
                }
                //total cost of the yarn is equal to the number of skeins multiplied by the price per skein
                else
                { cost = skeins * price; }

               //display the skeins and cost in the labels
                lArray[i, 0].Text = skeins.ToString("n2");
                lArray[i, 1].Text = cost.ToString("c");             //format the cost so that it has a $
            }


        }

        //event handler that clears the tab's input and outputs
        private void clearYardageButton_Click(object sender, EventArgs e)
        {
            const int ROWS = 4;
            Label[,] lArray2 = { {yarn1SkeinLabel, yarn1CostLabel},                       //array to hold the output labels
                                { yarn2SkeinLabel, yarn2CostLabel },
                                { yarn3SkeinLabel, yarn3CostLabel },
                                { yarn4SkeinLabel, yarn4CostLabel } };
            TextBox[,] tArray2 = { { yarn1SkeinTextBox,yarn1PriceTextBox},                //array to hold the input textboxes
                                  { yarn2SkeinTextBox,yarn2PriceTextBox},
                                  { yarn3SkeinTextBox,yarn3PriceTextBox},
                                   {yarn4SkeinTextBox,yarn4PriceTextBox} };

            clearTextBoxes(tArray2, ROWS);
            clearOutputLabels(lArray2, ROWS);
        }


        //function that clears the textboxes
        private void clearTextBoxes(TextBox[,] tArray, int ROWS)
        {
            patternYardageTextBox.Text = "";
            for (int i = 0; i < ROWS; i++)
            {
                tArray[i,0].Text = "";
                tArray[i, 1].Text = "";
            }

        }
        //function that clears the labels
        private void clearOutputLabels(Label[,] lArray, int ROWS)
        {
            for (int i = 0; i < ROWS; i++)
            {
                lArray[i, 0].Text = "";
                lArray[i, 1].Text = "";
            }

        }





        /**Section for the second tab**/
        //Group box 1
        //calculate the cast on 
        private void castOnCalculateButton_Click(object sender, EventArgs e)
        {
            //define variables
            double stitchesC = 0; double widthC = 0; double castonC = 0;
            //get stitches
            if (double.TryParse(stitchesTextBox1.Text, out stitchesC))
            {
                if (stitchesC < 0)
                { MessageBox.Show("Please enter a numeric value greater than zero"); }
            }
            else
            { MessageBox.Show("Please enter a numeric value greater than zero"); }
            //get width
            if (double.TryParse(widthTextBox.Text, out widthC))
            {
                if (widthC < 0)
                { MessageBox.Show("Please enter a numeric value greater than zero"); }
            }
            else
            { MessageBox.Show("Please enter a numeric value greater than zero"); }
            //calculate cast on
            castonC = stitchesC * widthC;
            //display cast on 
            castOnOutput.Text = castonC.ToString("n2");
        }
        //clear the groupbox
        private void clearButton1_Click(object sender, EventArgs e)
        {
            stitchesTextBox1.Text = "";
            widthTextBox.Text = "";
            castOnOutput.Text = "";
        }

    //Group box 2
        //calculate the width
        private void widthCalculateButton_Click(object sender, EventArgs e)
        {
            //define variables
            double stitchesW =0; double widthW = 0; double castonW = 0;
            //get stitches
            if (double.TryParse(stitchesTextBox2.Text, out stitchesW))
            {   //prevent division by zero
                if (stitchesW <= 0)
                { MessageBox.Show("Please enter a numeric value greater than zero"); }
            }
            else
            { MessageBox.Show("Please enter a numeric value greater than zero"); }
            //get cast on
            if (double.TryParse(castOnTextBox.Text, out castonW))
            {   
                if (castonW < 0)
                { MessageBox.Show("Please enter a numeric value greater than zero"); }
            }
            else
            { MessageBox.Show("Please enter a numeric value greater than zero"); }

            //calculate width
            widthW =  castonW/stitchesW ;

            //display width 
            widthOutput.Text = widthW.ToString("n2");
        }
        //clear the groupbox
        private void clearWidthButton_Click(object sender, EventArgs e)
        {
            stitchesTextBox2.Text = "";
            castOnTextBox.Text = "";
            widthOutput.Text = "";
        }

    //Group box 3
        //calculate the row count
        private void RowCalculateButton_Click(object sender, EventArgs e)
        {
            //define variables
            double rowsR = 0; double heightR = 0; double rowCountR = 0;
            //get rows
            if (double.TryParse(rowTextBox1.Text, out rowsR))
            {
                if (rowsR < 0)
                { MessageBox.Show("Please enter a numeric value greater than zero"); }
            }
            else
            { MessageBox.Show("Please enter a numeric value greater than zero"); }
            //get height
            if (double.TryParse(heightTextBox.Text, out heightR))
            {
                if (heightR < 0)
                { MessageBox.Show("Please enter a numeric value greater than zero"); }
            }
            else
            { MessageBox.Show("Please enter a numeric value greater than zero"); }
            //calculate cast on
            rowCountR = rowsR * heightR;
            //display cast on 
            rowCountOutput.Text = rowCountR.ToString("n2");
        }
        //clear the groupbox
        private void clearRowButton_Click(object sender, EventArgs e)
        {
            rowTextBox1.Text = "";
            heightTextBox.Text = "";
            rowCountOutput.Text = "";
        }

    //Group box 4
        //calculate the total height
        private void heightCalculateButton_Click(object sender, EventArgs e)
        {
            //define variables
            double rowsH = 0; double heightH = 0; double rowCountH = 0;
            //get rows
            if (double.TryParse(rowTextBox2.Text, out rowsH))
            {   //prevent division by zero
                if (rowsH <= 0)
                { MessageBox.Show("Please enter a numeric value greater than zero"); }
            }
            else
            { MessageBox.Show("Please enter a numeric value greater than zero"); }
            //get row count
            if (double.TryParse(rowCountTextBox.Text, out rowCountH))
            {   //prevent division by zero
                if (rowCountH < 0)
                { MessageBox.Show("Please enter a numeric value greater than zero"); }
            }
            else
            { MessageBox.Show("Please enter a numeric value greater than zero"); }

            //calculate height
            heightH =  rowCountH/rowsH ;

            //display hegiht 
            heightOutput.Text = heightH.ToString("n2");
        }
        //clear the groupbox
        private void clearHeightButton_Click(object sender, EventArgs e)
        {
            rowTextBox2.Text = "";
            rowCountTextBox.Text = "";
            heightOutput.Text = "";
        }
        //clear all the inputs and outputs
        private void clearAllGaugeButton_Click(object sender, EventArgs e)
        {
            //group box 1
            stitchesTextBox1.Text = "";
            widthTextBox.Text = "";
            castOnOutput.Text = "";
            //group box 2
            stitchesTextBox2.Text = "";
            castOnTextBox.Text = "";
            widthOutput.Text = "";
            //group box 3
            rowTextBox1.Text = "";
            heightTextBox.Text = "";
            rowCountOutput.Text = "";
            //group box 4
            rowTextBox2.Text = "";
            rowCountTextBox.Text = "";
            heightOutput.Text = "";
        }

        /**Section for the unit converter tab**/
        //event handler for the length calculate button
        private void lengthCalculateButton_Click(object sender, EventArgs e)
        {
            //define the variables
            double inputL = 0; double outputL = 0;
            string fromUnitL = ""; string toUnitL = "";
            //constants
            const double METER1 = .9144; const double METER2 = .0254;
            const double CM1 = 2.54; const double CM2 = 91.44;
            const double YARD1 = .028; const double METER3 = .01;
            const double YARD2 = 1.0936; const double INCH = 36;


            //get the from unit
            if (lengthFromListBox.SelectedIndex != -1)
            { fromUnitL = lengthFromListBox.SelectedItem.ToString();}
            else
            { MessageBox.Show("Please select a unit"); }

            //get the to unit
            if (lengthToListBox.SelectedIndex != -1)
            { toUnitL = lengthToListBox.SelectedItem.ToString();}
            else
            { MessageBox.Show("Please select a unit"); }

            //get and validate the input value
            if (double.TryParse(lengthTextBox.Text, out inputL))
            {
                if (inputL <= 0)
                { MessageBox.Show("Please enter a numeric value greater than zero."); }
            }
            else
            { MessageBox.Show("Please enter a numeric value greater than zero."); }

            //the from unit is inches
            if (fromUnitL == "Inches")
            {
                switch (toUnitL)
                {
                    case "Inches":
                        {
                        outputL = inputL;
                        break;
                        }
                    case "Centimeters":
                        {
                        outputL = inputL * CM1;
                        break;
                        }
                    case "Yards":
                        {
                        outputL = inputL * YARD1;
                         break;
                        }
                    case "Meters":
                        {
                        outputL = inputL * METER2;
                        break;
                        }
                }
            }
            //the from unit is centimeters
            else if (fromUnitL == "Centimeters")
            {
                switch (toUnitL)
                {
                    case "Inches":
                        {
                        outputL = inputL / CM1;
                        break;
                        }
                    case "Centimeters":
                        {
                        outputL = inputL;
                         break;
                        }
                    case "Yards":
                        {
                         outputL = inputL / CM2;
                         break;
                        }
                    case "Meters":
                        {
                         outputL = inputL * METER3;
                         break;
                        }
                }
            }
            //the from unit is yards
            else if (fromUnitL == "Yards")
            {
                switch (toUnitL)
                {
                    case "Inches":
                        {
                        outputL = inputL * INCH;
                        break;
                        }
                    case "Centimeters":
                        {
                        outputL = inputL * CM2;
                        break;
                        }
                    case "Yards":
                        {
                        outputL = inputL;
                        break;
                        }
                    case "Meters":
                        {
                        outputL = inputL * METER1;
                        break;
                        }
                }
            }
            //the from unit is meters. 
            else
            {
                switch (toUnitL)
                {
                    case "Inches":
                        {
                        outputL = inputL / METER2;
                        break;
                        }
                    case "Centimeters":
                        {
                        outputL = inputL / METER3;
                        break;
                        }
                    case "Yards":
                        {
                        outputL = inputL * YARD2;
                        break;
                        }
                    case "Meters":
                        {
                        outputL = inputL;
                        break;
                        }
                
                }

            } 
            //display the output, formated to 2 decimal places
            lengthOutput.Text = outputL.ToString("n2");
        }
        //event handler for the button that clears the length input and out put
        private void lengthClearButton_Click(object sender, EventArgs e)
        {
            //clear input
            lengthTextBox.Text = "";
            //clear output
            lengthOutput.Text = "";
        }



        //event handler for the button that calculates the mass
        private void massCalculateButton_Click(object sender, EventArgs e)
        {
            //define the variables
            double inputM = 0; double outputM = 0;
            string fromUnitM = ""; string toUnitM = "";
            //constant
            const double OUNCES = 0.035274; 
            //get the from unit
            if (massFromListBox.SelectedIndex != -1)
            { fromUnitM = massFromListBox.SelectedItem.ToString(); }
            else
            { MessageBox.Show("Please select a unit"); }

            //get the to unit
            if (massToListBox.SelectedIndex != -1)
            { toUnitM = massToListBox.SelectedItem.ToString();}
            else
            { MessageBox.Show("Please select a unit"); }

            //get and validate the input value
            if (double.TryParse(massTextBox.Text, out inputM))
            {
                if (inputM <= 0)
                { MessageBox.Show("Please enter a numeric value greater than zero."); }
            }
            else
            { MessageBox.Show("Please enter a numeric value greater than zero."); }

            //from unit is ounces
            if (fromUnitM == "Ounces")
            { 
                switch (toUnitM)
                {
                    //case ounces
                    case "Ounces":
                    {
                        outputM = inputM;
                        break;
                    }
                    //case grams
                    case "Grams":
                    {
                        outputM = inputM / OUNCES;
                        break;
                    }
                }
            }

            //from unit is grams
            else { 
            switch (toUnitM)
                { 
                    case "Ounces":
                    {
                        outputM = inputM * OUNCES;
                        break;
                    }
                    case "Grams":
                    {
                         outputM = inputM;
                         break;
                    }
                }
            }
            //display the output, formated to 2 decimal places
            massOutput.Text = outputM.ToString("n2");
        }
        //event handler for the button that clears the mass input and output
        private void massClearButton_Click(object sender, EventArgs e)
        {
            //clear input
            massTextBox.Text = "";
            //clear output
            massOutput.Text = "";
        }

    }
}
