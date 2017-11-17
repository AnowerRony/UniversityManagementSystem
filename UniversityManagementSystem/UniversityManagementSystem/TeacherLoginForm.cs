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
    public partial class TeacherLoginForm : Form
    {
        UserManager userManager = new UserManager();
        public TeacherLoginForm()
        {
            InitializeComponent();
        }

        private void teacherBackPictureBox_Click(object sender, EventArgs e)
        {
            startForm openForm = new startForm();
            openForm.Show();
            Visible = false;
        }

        private void teacherExitPictureBox_Click(object sender, EventArgs e)
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

        private void teacherLogInButton_Click(object sender, EventArgs e)
        {
            string userName = teacherUserNameTextBox.Text;
            string password = teacherPasswordTextBox.Text;
            if (userManager.LogIn(userName, password))
            {
                TeacherPanel opnFrm = new TeacherPanel();
                opnFrm.Show();
                Visible = false;
            }
            else if (teacherUserNameTextBox.Text == "" || teacherPasswordTextBox.Text == "")
            {
                if (teacherUserNameTextBox.Text == "" && teacherPasswordTextBox.Text == "")
                {
                    warningLabel.Text = "Please provide a Username and Password";
                    warningLabel.Visible = true;
                }
                else if (teacherPasswordTextBox.Text == "")
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
                teacherUserNameTextBox.Clear();
                teacherPasswordTextBox.Clear();
            }
        }
    }
}
