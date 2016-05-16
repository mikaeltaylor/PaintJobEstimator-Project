using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class paintJobEstimator : Form
    {
        public paintJobEstimator()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                double laborSquareFootageInput;//double to hold the square footage input
                double paintSquareFootageInput;//integer to hold the square footage input
                double billableHrs; //double to hold the billable hours output
                double paintPrice;//double to hold the paintprice input
                double paintCost;//double to hold the cost of a gallon of paint from user input
                double laborCost;//double to hold the cost of labor output
                double paintGallons; //integer to hold the number of gallons output
                double totalCost;//double to hold the total cost value for output
                                
                //Get the user input
                laborSquareFootageInput = double.Parse(txtSquareFootage.Text);
                paintSquareFootageInput = double.Parse(txtSquareFootage.Text);
                paintPrice = double.Parse(txtPaintPrice.Text);

                //Calculate the results
                billableHrs = (laborSquareFootageInput / 115) * 8;
                paintGallons = Math.Ceiling(paintSquareFootageInput / 115);
                paintCost = paintGallons * paintPrice;
                laborCost = billableHrs * 20;
                totalCost= laborCost+paintCost;

                //Display the results in the correct labels.
                lblPaintGallonsResults.Text = paintGallons.ToString("n0");
                lblBillableHrsResults.Text = billableHrs.ToString("n2");
                lblPaintCostResults.Text =("$"+ paintCost.ToString("n2"));
                lblLaborCostResults.Text = ("$" + laborCost.ToString("n2"));
                lblTotalCostResults.Text = ("$" + laborCost.ToString("n2"));
            }
            catch (Exception ex)
            {
                //Display the default error message
                MessageBox.Show("Incorrect input.  Please enter valid numerical data into the correct fields.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
