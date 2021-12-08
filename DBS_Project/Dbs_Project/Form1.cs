using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbs_Project
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //username and password of the user
            string myUsername = "admin";
            string myPassword = "admin";
            //getting the value from the textbox where user types
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            //check if the username and password are correct
            if (username == myUsername && password == myPassword)//if matches then login
            {
                MessageBox.Show("Login Success!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            //if one or more field is left empty
            else if (username == "" || password == "")
            {
                MessageBox.Show("One or more field empty !!! Please enter credentails!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //if doesnt match then show error message
            {
                MessageBox.Show("Invalid Credentials !!! Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
