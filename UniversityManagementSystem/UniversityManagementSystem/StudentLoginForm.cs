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
    public partial class StudentLoginForm : Form
    {
        UserManager userManager = new UserManager();
        public StudentLoginForm()
        {
            InitializeComponent();
        }

        private void StudentLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void studentBackPictureBox_Click(object sender, EventArgs e)
        {
            startForm openForm = new startForm();
            openForm.Show();
            Visible = false;
        }

        private void studentExitPictureBox_Click(object sender, EventArgs e)
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

        private void studentLogInButton_Click(object sender, EventArgs e)
        {
            string userName = studentUserNameTextBox.Text;
            string password = studentPasswordTextBox.Text;
            if (userManager.LogIn(userName, password))
            {
                Student_Panel opnFrm = new Student_Panel();
                opnFrm.Show();
                Visible = false;
            }
            else if (studentUserNameTextBox.Text == "" || studentPasswordTextBox.Text == "")
            {
                if (studentUserNameTextBox.Text == "" && studentPasswordTextBox.Text == "")
                {
                    warningLabel.Text = "Please provide a Username and Password";
                    warningLabel.Visible = true;
                }
                else if (studentPasswordTextBox.Text == "")
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
                studentUserNameTextBox.Clear();
                studentPasswordTextBox.Clear();
            }
        }
    }
}
