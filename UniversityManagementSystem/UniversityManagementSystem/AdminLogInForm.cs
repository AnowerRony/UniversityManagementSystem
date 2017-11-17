using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManagementSystem.BLL;

namespace UniversityManagementSystem
{
    public partial class AdminLogInForm : Form
    {
        UserManager userManager = new UserManager();
        public AdminLogInForm()
        {
            InitializeComponent();
        }

        private void adminBackPictureBox_Click(object sender, EventArgs e)
        {
            startForm openForm = new startForm();
            openForm.Show();
            Visible = false;
        }

        private void adminExitPictureBox_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit",
                MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                
            }
        }

        private void adminLogInButton_Click(object sender, EventArgs e)
        {
            string userName = adminUserNameTextBox.Text;
            string password = adminPasswordTextBox.Text;
            if (userManager.LogIn(userName, password))
            {
                AdminPanel openFrm = new AdminPanel();
                openFrm.Show();
                Visible = false;
            }
            else if (adminUserNameTextBox.Text=="" || adminPasswordTextBox.Text=="")
            {
                if (adminUserNameTextBox.Text=="" && adminPasswordTextBox.Text=="")
                {
                    warningLabel.Text = "Please provide a Username and Password";
                    warningLabel.Visible = true;
                }
                else if (adminPasswordTextBox.Text == "")
                {
                    warningLabel.Text = "Please provide a Password";
                    warningLabel.Visible = true;
                }
                else
                {
                    warningLabel.Text = "Please provide a Username";
                    warningLabel.Visible = true;
                }
            }
            else
            {
                warningLabel.Text = "Wrong Username Or Password";
                warningLabel.Visible = true;
                adminUserNameTextBox.Clear();
                adminPasswordTextBox.Clear();
            }
        }

        private void adminUserNameTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
