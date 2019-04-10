/*
 * Created by: Tisham Islam
 * Created on: 10/04/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Rounding Program
 * This program rounds any number inputted to the decimal point chosen
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

namespace RoundingProgramTishamI
{
    public partial class frmRoundingProgram : Form
    {
        //variables
        double bigNumber;

        public frmRoundingProgram()
        {
            InitializeComponent();
            lblRounded.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bigNumber = double.Parse(txtNumbers.Text);
            this.RathDotMound(ref bigNumber, nudRound.Value);
        }

        //Procedure: Rath.Mound
        //input: ref double number, decimal round
        //output: void
        //Description: Rounds the number given to the decimal point inputted
        private void RathDotMound(ref double number, decimal round)
        {
            number = number * Math.Pow((double)10, (double)round);
            number += (double)0.5;
            number = Math.Truncate(number);
            number = number / Math.Pow((double)10, (double)round);

            lblRounded.Show();
            lblRounded.Text = "Your number has been rounded down to: " + Convert.ToString(number);
        }
    }
}
