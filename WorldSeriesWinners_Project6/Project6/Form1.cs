using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project6
{
    public partial class worldSeriesWinners : Form
    {
        public worldSeriesWinners()
        {
            InitializeComponent();
        }
        //Declare global variables
        const int SIZE = 107;                       //the world series was played 107 times between 1903 and 2012. 
        string[] worldSeries = new string[SIZE];    //array to hold the winning team from each year


        /*** Function that handles the file tasks when the form loads***/
       private void worldSeriesWinners_Load(object sender, EventArgs e)
        {
            readToListBox();
            readToArray(worldSeries);
        }

        /*** Function that reads the contents of the Teams file into the ListBox Control***/
        private void readToListBox()
        {
            //Try to open the file and read the contents
            try
            {
                //Declare StreamReader Object for teams
                StreamReader teamsFile;
                //Open the file and get the object
                teamsFile = File.OpenText("../../Teams.txt");

                string winningTeam;         //variable to hold the team

                while (!teamsFile.EndOfStream)
                {
                    //Get the team
                    winningTeam = teamsFile.ReadLine();
                    //Add the team to the list box
                    teamsListBox.Items.Add(winningTeam);
                }
                //Close the file
                teamsFile.Close();
            }
            //Catch and handle an exception.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /***Function that reads the contents of the World Series file into an array ***/
        private void readToArray(string[] worldSeries)
        {  
            //Try to open the file and read the contents
            try {
                 //Declare StreamReader Object for world series
                    StreamReader worldSeriesFile;
                    //Open the file and get the object
                    worldSeriesFile = File.OpenText("../../WorldSeries.txt");
                    string worldSeriesYear;         //variable to hold the world series year

                    //Read the file
                    while (!worldSeriesFile.EndOfStream)
                    {   //Step through the array and add the winning team from that year to it
                        for (int i = 0; i < 107; i++)
                        {   //Read the line from the file into the variable
                            worldSeriesYear = worldSeriesFile.ReadLine();
                            //Set the element to the contents of the variable
                            worldSeries[i] = worldSeriesYear;
                        }
                    }
                //Close the file
                worldSeriesFile.Close();
                }
            //Catch and handle an exception.
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        /***Function that searches the array of winners and returns the count***/
        private int arraySearch(string team, int count)
        { 
            //Step through the array
            for (int i = 0; i < SIZE; i++)
            {   
                //If the name of the selected team matches the contents at the array index
                if (team == worldSeries[i])
                { count++;}            //add one to the counter  
            }
            return count;
        }

        /***Event handler for the ListBox Control***/
        private void teamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;                              //variable to hold the number of times the selected team has won
            string team = "";                           //varaible to hold the team selected by the user

            //Get the selected item
            team = teamsListBox.SelectedItem.ToString();
            //Call the arraySearch function to get the count
            count = arraySearch(team, count);
            //Display the results in the label
            resultLabel.Text = "The " + team + " have won the World Series " + count.ToString() + " time(s).";
        }
        /***Event Handler for the exit button***/
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
