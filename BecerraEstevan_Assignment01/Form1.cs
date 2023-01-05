using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecerraEstevan_Assignment_081
{/*=========================================================
* Estevan Becerra
* ebecerra@purdue.edu
* CNIT155 Assignment08
* Lab Section:   Fr. 1:30
* Program Description:  This code is able to display scores and the name of 
* the people who had this score.  It also displays the average score as well
* as the max score.
*
* Academic Honesty: 
*	I attest that this is my original work.
*	I have not used unauthorized source code, either modified or unmodified.
*	I have not given other fellow student(s) access to my program.
*=========================================================== */

    public partial class Form1 : Form
    {
        private const int cSize = 20;
        private string[] mData1 = new string[cSize];
        private int[] mData = new int[cSize];
        private int mIndex = 0;
        private int mCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayMessageOK(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private bool ValidateInput() //helper method for validation
        {
            int num;

            if (txtName.Text == "") //name must exist
            {
                DisplayMessageOK("Name must be filled");//display message
                return false;
            }

            if (int.TryParse(txtScore.Text, out num) == false) //score must be a real number
            {
                DisplayMessageOK("Score must be a whole number");//display message
                txtScore.Focus();
                return false;
            }

            if (num < 0 || num > 100) // score must be between 0 and 100
            {
                DisplayMessageOK("Score must be between 0 and 100");//display message
                txtScore.Focus();
                return false;

            }

            return true;
        }

        private void ClearInput() //this will clear the input
        {
            txtName.Clear();
            txtScore.Clear();
            lstShow.Items.Clear();

        }

        private string ToProperCase(string name) //will capitalize first letter of name
        {

            string proper;     // string in proper case
            string firstLetter;
            string rest;

            firstLetter = name.Substring(0, 1);
            rest = name.Substring(1);    // will give the resst of the straing after the first character
            proper = firstLetter.ToUpper() + rest.ToLower();

            return proper;

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            int num;
            string name;
            if (ValidateInput() == false) //validateing inputs
            {
                return;
            }

            name = txtName.Text;
            name = ToProperCase(name);

            num = int.Parse(txtScore.Text); //capitalize fist leter of name
            mData[mIndex] = num;
            mData1[mIndex] = name;
            mIndex++;

            if (mIndex == cSize)
            {
                DisplayMessageOK("Array is full"); //array is full
                btnEnter.Enabled = false;
            }
            txtScore.Clear();
            txtName.Clear();
            txtName.Focus();
            mCount++;
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            if (mIndex == 0) //array is empty
            {
                DisplayMessageOK("Array is empty");
                return;
            }

            lstShow.Items.Clear(); //clear list box

            lstShow.Items.Add("Name\t\tScore" + Environment.NewLine);
            lstShow.Items.Add("---------------------------------------" + Environment.NewLine);

            for (int k = 0; k < mIndex; k++)
            {
                lstShow.Items.Add(mData1[k] + "\t\t" + mData[k]);

            }

        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            double counter = mCount;


            if (mIndex == 0)
            {
                DisplayMessageOK("Array is empty");
                return;
            }

            lstShow.Items.Clear();

            lstShow.Items.Add("Number of students entered: " + counter);
            lstShow.Items.Add(Environment.NewLine);

            double average;
            double sum = 0;


            for (int k = 0; k < mIndex; k++)
            {
                sum = sum + mData[k];
            }

            average = sum / mIndex; //calculate the average
            lstShow.Items.Add("Average: " + average.ToString("N2"));

            lstShow.Items.Add(Environment.NewLine);

            int max = 0;
            int name = 0;


            for (int k = 0; k < mIndex; k++)
            {
                if (mData[k] > max)

                    max = mData[k];


            }

            lstShow.Items.Add("Maximum score: " + max); //display the max

            lstShow.Items.Add(Environment.NewLine);

            lstShow.Items.Add("Student's Name: " + mData1[name]); //display the name with the max
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
