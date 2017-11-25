//Rebecca Flake
//COP2551.0M1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class cardIdentifier : Form
    {
        public cardIdentifier()
        {
            InitializeComponent();
        }
        //Far left card. When clicked display the name.
        private void card1_Click(object sender, EventArgs e)
        {
            cardName.Text = "Queen of Diamonds";
        }
        //Middle left card. When clicked display the name.
        private void card2_Click(object sender, EventArgs e)
        {
            cardName.Text = "Two of Hearts";
        }
        //Center card. When clicked display the name.
        private void card3_Click(object sender, EventArgs e)
        {
            cardName.Text = "Ace of Spades";
        }
        //Middle right card. When clicked display the name.
        private void card4_Click(object sender, EventArgs e)
        {
            cardName.Text = "Eight of Clubs";
        }
        //Far right card. When clicked display the name.
        private void card5_Click(object sender, EventArgs e)
        {
            cardName.Text = "Jack of Clubs";
        }
        //Close the form.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
