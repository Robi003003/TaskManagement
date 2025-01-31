using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (username == "manager" && password == "1234")
            {
                MessageBox.Show("Login successful! Welcome, Manager.");

                ProjectsForm projectsForm = new ProjectsForm();
                projectsForm.Show();
            }
            else if (username == "employee" && password == "5678")
            {
                MessageBox.Show("Login successful! Welcome, Employee.");

                ProjectsForm projectsForm = new ProjectsForm();
                projectsForm.Show();

            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
