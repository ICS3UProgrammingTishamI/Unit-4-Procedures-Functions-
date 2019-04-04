/*
 * Created by: Tisham Islam
 * Created on: 04/04/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Convert To Fahrenheit
 * This program converts the inputted temperature from Celsius to Fahrenheit
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertToFahrTishamI
{
    public partial class frmConvertToFahr : Form
    {
        public frmConvertToFahr()
        {
            InitializeComponent();
            lblConversion.Hide();
        }

        //Procedure: ConvertToFahr
        //Input: celsiusTemp
        //Output: void
        //This will convert degrees Celsius to degrees Fahrenheit
        private void ConvertToFahr(decimal celsiusTemp)
        {
            //variables
            decimal fahrenheitTemp;

            //Calculations for Cel to Fahr
            fahrenheitTemp = celsiusTemp * (decimal)9 / (decimal)5 + 32;

            //Display the conversion
            lblConversion.Text = "Here is your temperature in degrees Fahrenheit: " + fahrenheitTemp;
            lblConversion.Show();
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            //variables
            decimal userTemp;

            //Make userTemp into your input for temperature
            userTemp = Convert.ToDecimal(txtTemp.Text);

            //Call the procedure
            this.ConvertToFahr(userTemp);

        }
    }
}
