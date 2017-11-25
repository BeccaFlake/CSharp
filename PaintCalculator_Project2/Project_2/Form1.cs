using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class PaintJobCostEstimator : Form
    {   //Define the variables
        private double sqFt;                                        //variable to hold the square footage
        private double galPrice;                                    //variable to hold the price of the paint
        private double totalGal;                                    //variable to hold the calculated number of gallons of paint
        private double laborReq;                                    //variable to hold the calculated hours of labor
        private double totalPaintCost;                              //variable to hold the calculated price of the paint
        private double totalLaborCost;                              //variable to hold the calculated cost of labor
        private double totalJobCost;                                //variable to hold the calculated cost of the job
        private const double SQFT_BASE = 115;                       //constant variable to hold the base square footage for the calculations
        private const double LABOR_BASE = 8;                        //constant variable to hold the base labor in hours for the calculations
        private const double LABOR_COST_BASE = 20.00;               //constant variable to hold the base cost of labor per hour for the calculations

        public PaintJobCostEstimator()
        {
            InitializeComponent();
        }

        private void PaintJobCostEstimator_Load(object sender, EventArgs e)
        { }   

        //Event handler for the square footage text input
        private void sqFtTextBox_TextChanged(object sender, EventArgs e)
        {   //Get the input, handle input type validation
            try
            {   //the square footage is a value entered by the user in the textbox
                sqFt = double.Parse(sqFtTextBox.Text);                      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Event handler for the gallon price text input
        private void gallonTextBox_TextChanged(object sender, EventArgs e)
        {   //Get the input, handle input type validation
            try
            {   //the gallon price is a value entered by the user in the textbox
                galPrice = double.Parse(gallonTextBox.Text);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Event handler for the calculate button
        private void calculateButton_Click(object sender, EventArgs e)
        {   //Calculations
            totalGal = (sqFt / SQFT_BASE);                          //total gallons needed is the input square foot value divided by the base square foot value
            laborReq = (LABOR_BASE * (sqFt/SQFT_BASE));             //needed labor is the input square foot value divided by the base square foot value, multiplied by the base labor value
            totalPaintCost = (totalGal * galPrice);                 //the total cost of the paint is the total gallons needed multiplied by the entered price per gallon
            totalLaborCost = (laborReq * LABOR_COST_BASE);          //the total cost of labor is the hours of labor needed multiplied by the base cost of the labor per hour
            totalJobCost = (totalPaintCost + totalLaborCost);       //the total job cost is the sum of the total paint cost and the total labor cost

            //Display the results of the calculations in the labels
            gallonResult.Text = totalGal.ToString("n2");
            laborResult.Text = laborReq.ToString("n2");
            paintCostResult.Text = totalPaintCost.ToString("c");
            laborCostResult.Text = totalLaborCost.ToString("c");
            totalResult.Text = totalJobCost.ToString("c");
        }

        //Event handler for the clear button
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear all of the labels
            gallonResult.Text = "";
            laborResult.Text = "";
            paintCostResult.Text = "";
            laborCostResult.Text = "";
            totalResult.Text = "";
        }

        //Event handler for the exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            //exit the form
            this.Close();
        }
    }
}
