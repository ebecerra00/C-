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
namespace BecerraEstevan_Assignment11
{
    public partial class Form1 : Form
    {
        private const int cSize = 40;
        private string[] mName = new string[cSize];
        private double[] mGPA = new double[cSize];
        private string[] mArea = new string[cSize];
        private int mIndex = 0;

        private string mFileName = Path.Combine(Application.StartupPath, "Students.txt");

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
            double GPA;
            
            if(txtName.Text =="")
            {
                DisplayMessageOK("Please enter name.");
                return false;
            }

            if (double.TryParse(txtGPA.Text, out GPA) == false)
            {
                DisplayMessageOK("GPA must be a whole number");
                return false;
            }

            if (GPA < 0 || GPA > 4.0)
            {
                DisplayMessageOK("GPA must be between 0 and 4");
                txtGPA.Focus();
                return false;
            }

            if(radCIT.Checked == false && radCyber.Checked == false && radNET.Checked == false && radSystem.Checked == false)
            {
                DisplayMessageOK("Must select radio button");
                return false;
            }

            return true;
        }

        private double ComputeAvg(double[] data, int count)
        {
            double average;
            double sum = 0;


            for (int k = 0; k < mIndex; k++)
            {
                sum = sum + mGPA[k];
            }

            average = sum / mIndex; //calculate the average
            return average;

        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtGPA.Clear();
            lstShow.Items.Clear();
            radCIT.Checked = false;
            radCyber.Checked = false;
            radNET.Checked = false;
            radSystem.Checked = false;
            txtName.Focus();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if(ValidateInputs()==false)
            {
                return;
            }

            string Name = txtName.Text;
            double GPA = double.Parse(txtGPA.Text);
            string Area;

            if(radCIT.Checked == true)
            {
                Area = "CIT";
            }

            else if(radCyber.Checked == true)
            {
                Area = "Cybersecurity";
            }

            else if(radNET.Checked == true)
            {
                Area = "NET";
            }

            else
            {
                Area = "System";
            }

            mName[mIndex] = Name;
            mGPA[mIndex] = GPA;
            mArea[mIndex] = Area;
            mIndex++;

            if(mIndex == cSize)
            {
                DisplayMessageOK("Array is full");
                btnEnter.Enabled = false;
            }

            ClearInputs();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            if (mIndex == 0) //check if array is empty
            {
                DisplayMessageOK("Array is empty");
                return;
            }

            lstShow.Items.Clear();

            string Name = "Name";
            string  Area = "Focus";
            string GPA = "GPA";

            lstShow.Items.Clear();

            lstShow.Items.Add(Name.PadRight(10) + Area.PadRight(15) + GPA);
            lstShow.Items.Add("====================================");

            for (int k = 0; k < mIndex; k++)
            {
                lstShow.Items.Add(mName[k].PadRight(10) + mArea[k].ToString().PadRight(15) + mGPA[k]);
            }

        }

        private void BtnAverage_Click(object sender, EventArgs e)
        {
            double Average;

            if(mIndex == 0)
            {
                DisplayMessageOK("Array is empty");
                return;
            }

            lstShow.Items.Clear();

            lstShow.Items.Add("Number of students entered: " + mIndex);

            Average = ComputeAvg(mGPA, mIndex);

            lstShow.Items.Add("Average: " + Average.ToString("N2"));

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            if (File.Exists(mFileName) == false)
            {
                DisplayMessageOK("There is no input file.");
                return;
            }

            StreamReader SR = null;

            string line;
            string[] parts = new string[3];

            try
            {
                SR = new StreamReader(mFileName);

                while (SR.Peek() != -1)
                {

                    line = SR.ReadLine();

                    parts = line.Split('\t');

                    mName[mIndex] = parts[0];
                    mArea[mIndex] = parts[1];
                    mGPA[mIndex] = double.Parse(parts[2]);

                    mIndex++;

                    if (mIndex == cSize)
                    {
                        btnEnter.Enabled = false;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {


                if (SR != null)
                {
                    SR.Close();
                }
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            StreamWriter writer = null;

            if (MessageBox.Show("Are you sure you want to close the program?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                
                int i;
                writer = new StreamWriter(mFileName);

                for (i = 0; i < mIndex; i++)
                {
                    writer.WriteLine(mName[i] + "\t" + mArea[i] + "\t" + mGPA[i]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                          
                    writer.Close();
                
            }
        }
    }
}
    

