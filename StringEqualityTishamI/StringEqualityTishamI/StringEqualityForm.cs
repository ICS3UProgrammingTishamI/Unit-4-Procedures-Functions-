/*
 * Created by: Tisham Islam
 * Created on: 18/04/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - String Equality
 * This program checks if two inputted string are equal, caps excluded
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

namespace StringEqualityTishamI
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();
            lblEqual.Hide();
        }

        //Function: String Equalizer
        //Input string str1, string str2
        //Output: bool
        //Desc: Compares strings inputted and sees if they're the same, caps excluded
        private bool StringEqualizer(string str1, string str2)
        {
            //initialize bool to false
            bool equal = false;

            //checks length first for efficiency
            if (str1.Length == str2.Length)
            {
                //convert the strings to upper so that caps are ignored
                //this will not affect the actual strings
                str1 = str1.ToUpper();
                str2 = str2.ToUpper();

                //if they are the same, set the bool to true
                if (str1 == str2)
                {
                    equal = true;
                }
            }

            //return the value
            return equal;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //if the strings aren't equal, then
            if (StringEqualizer(txtInput1.Text, txtInput2.Text) == false)
            {
                lblEqual.Text = "Your strings are not equal. Bad";
                lblEqual.Show();
            }
            //if they are equal, then
            else
            {
                lblEqual.Text = "Your strings are equal. Good";
                lblEqual.Show();
            }
        }
    }
}
