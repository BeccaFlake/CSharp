using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project7
{
    public partial class slotMachine : Form
    {
        public slotMachine()
        {
            InitializeComponent();
        }

        //define the global variables
        double spinTotal = 0;
        double totalAmount = 0;
        //define the random object
        Random rand = new Random();

      //**** General Functions ****//
        /*Function that gets the random index for the image*/
        private int getImage()
        {
            //get a random index from the image list
            int index = rand.Next(fruitImageList.Images.Count);
            return index;
        }
        /*Function that calculates the final values, using reference variables*/
        private void calculate(ref double spinTotal, ref double totalAmount, double spinResult, double inputAmount)
        {  
            //add the result of the spin to the spin total
            spinTotal += spinResult;
            //add the input amount to the total input
            totalAmount += inputAmount;
        }

    //**** Event Handlers ****//
        /*Event Handler for the spin button*/
        private void spinButton_Click(object sender, EventArgs e)
        {   
            //define local vaiables 
            double inputAmount = 0;
            double spinResult = 0;
            //get the input
            if (double.TryParse(amountTextBox.Text, out inputAmount))
            {   
                //get the indexes
                int img1 = getImage();
                int img2 = getImage();
                int img3 = getImage();

                //display the randomly generated images
                pictureBox1.Image = fruitImageList.Images[img1];
                pictureBox2.Image = fruitImageList.Images[img2];
                pictureBox3.Image = fruitImageList.Images[img3];

                //determine the winnings
                    //two match, double the input
                if ((img1 == img2) || (img1 == img3) || (img2 == img3))
                { spinResult = (inputAmount * 2);}
                    //three match, triple the input
                else if ((img1 == img2) && (img2 == img3))
                { spinResult = (inputAmount * 3);}
                    //none match, result is zero
                else
                { spinResult = 0;}

                //update the totals
                calculate(ref spinTotal, ref totalAmount, spinResult, inputAmount);

                //show spin result
                resultLabel.Text = spinResult.ToString();
                //clear the textbox
                amountTextBox.Text = "";
            }
            else
            { MessageBox.Show("Please enter a valid dollar amount.");}
        }
        /*Event handler for the exit button*/
        private void exitButton_Click(object sender, EventArgs e)
        {   
            //Show the user the results
            MessageBox.Show("Total Amount inserted: " + totalAmount + ". Total winnings: " + spinTotal + ".");
            //Close the application
            this.Close();
        }
    }
}
