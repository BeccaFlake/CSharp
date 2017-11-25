using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    public partial class DiceRoller : Form
    {
        public DiceRoller()
        {
            InitializeComponent();
        }
        //method that hides the pictures
        private void hideAllPictures()
        {
            { pictureBoxR1D1.Visible = false; }
            { pictureBoxR1D2.Visible = false; }
            { pictureBoxR1D3.Visible = false; }
            { pictureBoxR1D4.Visible = false; }
            { pictureBoxR1D5.Visible = false; }
            { pictureBoxR1D6.Visible = false; }

            { pictureBoxR2D1.Visible = false; }
            { pictureBoxR2D2.Visible = false; }
            { pictureBoxR2D3.Visible = false; }
            { pictureBoxR2D4.Visible = false; }
            { pictureBoxR2D5.Visible = false; }
            { pictureBoxR2D6.Visible = false; }
        }
        //Event handler for the roll button
        private void rollButton_Click(object sender, EventArgs e)
        {   //initialize variables
            int num1 = 0;
            int num2 = 0;
            int total = 0;
            //create a random object
            Random rand = new Random();
            //hide all of the pictures
            hideAllPictures();
            //get the random numbers
            num1 = rand.Next(6) + 1;
            num2 = rand.Next(6) + 1;
            //calculate the total
            total = num1 + num2;

            //Something went wrong with the random numbers and the total is over 12
            if ((num1 > 6 ) || (num2 > 6))
            {
                MessageBox.Show("Something went wrong! Re-rolling.");
                //get new numbers, the roll was invalid. 
                num1 = rand.Next(6) + 1;
                num2 = rand.Next(6) + 1;
                //calculate the new total
                total = num1 + num2;
            }
            //everything is fine, proceed with the program
                switch (num1)
                {   //show picture for the first die
                    case 1: { pictureBoxR1D1.Visible = true; break; }
                    case 2: { pictureBoxR1D2.Visible = true; break; }
                    case 3: { pictureBoxR1D3.Visible = true; break; }
                    case 4: { pictureBoxR1D4.Visible = true; break; }
                    case 5: { pictureBoxR1D5.Visible = true; break; }
                    case 6: { pictureBoxR1D6.Visible = true; break; }
                      //Handle the unlikely event a bad number slipped in
                    default:
                        {
                            MessageBox.Show("Something seems to have gone wrong with the first die. Please re-roll.");
                            total = 0;
                            hideAllPictures();
                            break;
                        }
                }

                switch (num2)
                {   //show the picture for the second die
                    case 1: { pictureBoxR2D1.Visible = true; break; }
                    case 2: { pictureBoxR2D2.Visible = true; break; }
                    case 3: { pictureBoxR2D3.Visible = true; break; }
                    case 4: { pictureBoxR2D4.Visible = true; break; }
                    case 5: { pictureBoxR2D5.Visible = true; break; }
                    case 6: { pictureBoxR2D6.Visible = true; break; }
                        //Handle the unlikely event a bad number slipped in
                    default:
                        {
                            MessageBox.Show("Something seems to have gone wrong with the second die. Please re-roll.");
                            total = 0;
                            hideAllPictures();
                            break;
                        }
                }
                //show the total roll in the label
                totalOutput.Text = total.ToString();
         }


        //exit the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
