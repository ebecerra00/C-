using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecerraEstevan_Assignment06
{/*=========================================================
* Estevan Becerra
* ebecerra@purdue.edu
* CNIT155 Assignment04
* Lab Section:   Fr. 1:30
* Program Description:  This code is able to validate/ approve your loan.
* as well as add how much the loans were and how many people are n the system.
*
* Academic Honesty: 
*	I attest that this is my original work.
*	I have not used unauthorized source code, either modified or unmodified.
*	I have not given other fellow student(s) access to my program.
*=========================================================== */
    public partial class Form1 : Form
    {
        private double cTotal;
        private int cApproved;
        private double Interest = .0425;

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayMessageOK(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private bool ValidateInputs()
        {

            int num1;


            if (txtFirstname.Text=="")
            {
                DisplayMessageOK("Enter First Name");
                txtFirstname.Focus();
                return false;
            }

            if (txtLastname.Text == "")
            {
                DisplayMessageOK("Enter Last Name");
                txtLastname.Focus();
                return false;
            }

            if (int.TryParse(txtLoanamount.Text, out num1) == false)
            {
                DisplayMessageOK("Loan amount must be an integer");
                txtLoanamount.Focus();
                return false;
            }

            if (num1 < 2000 || num1 > 3000000)
            {
                DisplayMessageOK("Make sure the loan amount is between 2000 and 300000");
                txtLoanamount.Focus();
                return false;
            }

            if (radTen.Checked == false && radFifteen.Checked == false && radTwenty.Checked == false && radThirty.Checked == false)
            {
                DisplayMessageOK("Make sure you seleced a radio button");
                return false;

            }


            return true;

        }


        private void ClearInput()
        {
            radTen.Checked = false;
            radFifteen.Checked = false;
            radTwenty.Checked = false;
            radThirty.Checked = false;
            txtFirstname.Clear();
            txtLastname.Clear();
            txtLoanamount.Clear();
            txtOutput.Clear();
            txtFirstname.Focus();
        }
            

            private double ComputeMonthlyPay(double Loan, double duration)
        {
            double rate;
            duration = duration * 12;
            double month;

            rate = (Interest / 12);
            month = Loan * (rate+(rate/((Math.Pow((1+rate),(duration)))-1)));
            return month;
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            double ans;
            double duration;
            double Loan;

            if (ValidateInputs() == false)
            {
                return;

            }

            if (radTen.Checked == true)
            {
                duration = 10;

            }

            else if (radFifteen.Checked == true)
            {
                duration = 15;

            }

            else if (radTwenty.Checked == true)
            {
                duration = 20;

            }
            else
                duration = 30;

            Loan = int.Parse(txtLoanamount.Text);
            ans = ComputeMonthlyPay(Loan, duration);

            txtOutput.Text = txtFirstname.Text + txtLastname.Text + "\r\n" + "Loan Amount: " + Loan.ToString("c")+"\r\n"+ "Duration: "+duration.ToString("N0")+"\r\n"+"Annual Interest Rate: 4.25"+"%"+"\r\n"+ "Monthly Payment: "+ ans.ToString("N2");
            cApproved++;
            cTotal = ComputeMonthlyPay(Loan, duration);
        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "Number of Loans Processed: " + cApproved.ToString("N0")+"\r\n"+"Total Loans Processed: "+cTotal.ToString("N2");
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
