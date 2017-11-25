using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    public partial class Automotive : Form
    {
        public Automotive()
        {
            InitializeComponent();
        }
     //Global variables
        double oilLubeCost;             //variable to hold the cost of the oil and/or lube job
        double flushCost;               //variable to hold the cost of the flush(es)
        double miscCost;                //variable to hold the cost of the misc services
        double partsCost;               //variable to hold the cost of the parts
        double hrsLabor;                //variable to hold the cost of the hours of labor
        double laborCost;               //variable to hold the cost of the labor
        double tax;                     //variable to hold the tax
        double total;                   //variable to hold the total service cost
        double laborServiceCost;        //variable to hold the cost of the service and the labor
        double otherCost;               //variable to hold the cost of parts and the labor

/****************************************
*            Return Functions           *
* **************************************/           

        /*** Function that determines the oil and lube charges. Returns the oil and lube cost as a double ***/
        private double oilLubeCharges()
        {
            const double OIL = 26.00;   //constant variable to hold the cost of an oil change
            const double LUBE = 18.00;  //constant variable to hold the cost of a lube job

            //if oil change only is checked
            if ((oilChangeCheckBox.Checked) && !(lubeJobCheckBox.Checked))
            { oilLubeCost = OIL; }
            //if lube job only checked
            else if (!(oilChangeCheckBox.Checked) && (lubeJobCheckBox.Checked))
            {  oilLubeCost = LUBE; }
            //if both checked
            else if ((oilChangeCheckBox.Checked) && (lubeJobCheckBox.Checked))
            { oilLubeCost = (OIL + LUBE); }
            //if none checked
            else 
            { oilLubeCost = 0; }
            return oilLubeCost;
        }

        /*** Function that determines the flush charges. Returns the flush cost as a double ***/
        private double flushCharges()
        {
            const double RFLUSH = 30.00;    //constant variable to hold the cost of a radiator flush
            const double TFLUSH = 80.00;    //constant variable to hold the cost of a transmission flush

            //if r. flush only checked
            if ((radiatorCheckBox.Checked) && !(transmissionCheckBox.Checked))
            { flushCost = RFLUSH; }
            //if t. flush only checked
            else  if (!(radiatorCheckBox.Checked) && (transmissionCheckBox.Checked))
            { flushCost = TFLUSH; }
            //if both checked
            else  if ((radiatorCheckBox.Checked) && (transmissionCheckBox.Checked))
            { flushCost = (RFLUSH + TFLUSH); }
             //if none checked
            else
            { flushCost = 0; }
            return flushCost;
        }

        /*** Function that determines the misc charges. Returns the misc cost as a double ***/
        private double miscCharges()
        {
            const double INSPECT = 15.00;   //constant variable to hold the cost of an inspection
            const double MUFFLER = 100.00;  //constant variable to hold the cost of a muffler replacement
            const double ROTATION = 20.00;  //constant variable to hold the cost of a tire rotation

            //if inspection only checked
            if ((inspectionCheckBox.Checked) && !(mufflerCheckBox.Checked) && !(tireCheckBox.Checked))
            {miscCost = INSPECT; }//
                //if muffler only checked
            else if (!(inspectionCheckBox.Checked) && (mufflerCheckBox.Checked) && !(tireCheckBox.Checked))
            {miscCost = MUFFLER; }
                //if rotation only checked
            else if (!(inspectionCheckBox.Checked) && !(mufflerCheckBox.Checked) && (tireCheckBox.Checked))
            {miscCost = ROTATION; }//
                //if inspection and muffler checked
            else if ((inspectionCheckBox.Checked) && (mufflerCheckBox.Checked) && !(tireCheckBox.Checked))
            {miscCost = (INSPECT + MUFFLER); }//
                //if inspection and rotation checked
            else if ((inspectionCheckBox.Checked) && !(mufflerCheckBox.Checked) && (tireCheckBox.Checked))
            {miscCost = (INSPECT + ROTATION); }//
                //if muffler and rotation checked
            else if (!(inspectionCheckBox.Checked) && (mufflerCheckBox.Checked) && (tireCheckBox.Checked))
            {miscCost = (MUFFLER + ROTATION); } //
                 //if all checked
            else if ((inspectionCheckBox.Checked) && (mufflerCheckBox.Checked) && (tireCheckBox.Checked))
            {miscCost = (INSPECT + MUFFLER + ROTATION); }//)
                //if none checked
            else
            {miscCost = 0; }//
            return miscCost;

        }

        /*** Function that accepts the labor cost and parts cost variables, which are passed by reference. Returns the other cost as a double ***/
        private double otherCharges(ref double laborCost, ref double partsCost)
        {
            const double LABOR_RATE = 20.00;        //constant variable to hold the cost of an hour of labor
            double partsInput;                      //variable to hold the parts input
            double hrsInput;                        //variable to hold the hours input
            //get the hours of labor input
            if (double.TryParse(laborTextBox.Text, out hrsInput))
            {
                hrsLabor = hrsInput;                     //Set the hours of labor to the validated input
                //calculate the cost of labor   
                laborCost = (hrsLabor * LABOR_RATE);     //the cost of labor is the rate multiplied by the number of hours   
            }
            else
            {
                MessageBox.Show("Enter a numeric value for the hours.");
            }

            //get the part cost input
            if (double.TryParse(partsTextBox.Text, out partsInput))
            {
                partsCost = partsInput;                  //Set the cost of parts to the validated input
            }
            else
            {
                MessageBox.Show("Enter a numeric value for the cost of parts.");
            }
            //calculate the total of the parts and the labor
            otherCost = (partsCost + laborCost);         //other cost is the parts cost added to the cost of labor
            return otherCost;
        }
        
        /*** Function that accepts the cost of the parts and uses it to calculate the tax. Returns the tax as a double ***/
        private double taxCharges(double partsCost)
        {
            const double TAX_RATE = 0.06;   //Constant variable to hold the tax rate
            //calculate the tax
            tax = (partsCost * TAX_RATE);   //calculated tax is the cost of parts multiplied by the tax rate
            return tax;
        }

        /*** Function that accepts all of the calculated costs and adds them. Returns the total charges as a double ***/
        private double totalCharges(double oilLubeCost, double flushCost, double miscCost, double otherCost, double tax)
        {
            total = (oilLubeCost + flushCost + miscCost + otherCost + tax);
            return total;
        }
/****************************************
*              Void Functions           *
* **************************************/
        //Function that unchecks the oil and lube checkboxes
       private void clearOilLube()
        {
            //set the checked boxes to not checked
            oilChangeCheckBox.Checked = false;
            lubeJobCheckBox.Checked = false;
        }
        //Function that unchecks flush checkboxes
        private void clearFlushes()
        {
            //set the checked boxes to not checked
            radiatorCheckBox.Checked = false;
            transmissionCheckBox.Checked = false;
        }
        //Function that unchecks the misc checkboxes
        private void clearMisc()
        {
            //set the checked boxes to not checked
            inspectionCheckBox.Checked = false;
            mufflerCheckBox.Checked = false;
            tireCheckBox.Checked = false;
        }
        //Function that clears the text boxes
        private void clearOther()
        {
            //set the text boxes to defaults
            laborTextBox.Text = "0.00";
            partsTextBox.Text = "0.00";
        }
        //Function that clears the labels
        private void clearFees()
        {
            //set the labels to empty strings
            serviceTotalLabel.Text = "";
            partsTotalLabel.Text = "";
            taxTotalLabel.Text = "";
            totalCostlabel.Text = "";
        }

        /******Event handlers*******/

      //event handler for the calculate button
        private void calculateButton_Click(object sender, EventArgs e)
        {
            oilLubeCost = oilLubeCharges();
            flushCost = flushCharges();
            miscCost = miscCharges();
            otherCost = otherCharges(ref laborCost, ref partsCost);
            tax = taxCharges(partsCost);

            //calculate the charges
            total = totalCharges(oilLubeCost, flushCost, miscCost, otherCost, tax);
            laborServiceCost = (oilLubeCost + flushCost + miscCost + laborCost);

            serviceTotalLabel.Text = laborServiceCost.ToString("c");
            partsTotalLabel.Text = partsCost.ToString("c");
            taxTotalLabel.Text = tax.ToString("c");
            totalCostlabel.Text = total.ToString("c");
        }
      //event handler for the clear button
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearOilLube();
            clearFlushes();
            clearMisc();
            clearOther();
            clearFees();
        }
       //event handler for the clear button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
