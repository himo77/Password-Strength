using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Strength
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void btnEstimateStrength_Click_1(object sender, EventArgs e)
        {
            //Created a variable to store user input in password textbox.
            string password = txtPassword.Text;

            //Conditions to check whether the password is good, bad or ok.
            if (password.Length > 10 && password.Any(char.IsDigit) && password.Any(char.IsLetter) && password.Any(char.IsPunctuation))
            {
                //if the password is good then the label display the word "good".
                lblResult.Text = "Good";

                //making the label to be color green when the password is good.
                lblResult.BackColor = Color.LightGreen;
            }
            else if (password.Length > 5 && password.Any(char.IsDigit) && password.Any(char.IsLetter))
            {
                //if the password is ok then the label display the word "ok".
                lblResult.Text = "Ok";
                //making the label to be color orange when the password is ok.
                lblResult.BackColor = Color.Orange;
            }
            else
            {
                //if the password is bad then the label display the word "bad".
                lblResult.Text = "Bad";

                //making the label to be color red when the password is bad.
                lblResult.BackColor = Color.Red;  
            }
        }

       
    }
}
