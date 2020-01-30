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

        private void btnEstimateStrength_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (password.Length > 10)
            {
                lblResult.Text = "Good";
                lblResult.BackColor = Color.LightGreen;
            }
            else
            {
                lblResult.Text = "Bad";
                lblResult.BackColor = Color.Red;
            }
        }

        private void btnEstimateStrength_Click_1(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (password.Length > 10 && password.Any(char.IsDigit) && password.Any(char.IsLetter) && password.Any(char.IsPunctuation))
            {
                lblResult.Text = "Good";
                lblResult.BackColor = Color.LightGreen;
            }
            else if (password.Length > 5 && password.Any(char.IsDigit) && password.Any(char.IsLetter))
            {
                lblResult.Text = "Ok";
                lblResult.BackColor = Color.Orange;
            }
            else
            {
                lblResult.Text = "Bad";
                lblResult.BackColor = Color.Red;
            }
        }
    }
}
