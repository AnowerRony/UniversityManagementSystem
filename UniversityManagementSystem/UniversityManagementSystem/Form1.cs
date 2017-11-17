using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManagementSystem.Properties;

namespace UniversityManagementSystem
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        private void adminPictureBox_MouseHover(object sender, EventArgs e)
        {
            adminPictureBox.Image = Resources.admin1;
        }

        private void adminPictureBox_MouseLeave(object sender, EventArgs e)
        {
            adminPictureBox.Image = Resources.admin;
        }

        private void teacherPictureBox_MouseHover(object sender, EventArgs e)
        {
            teacherPictureBox.Image = Resources.professor;
        }

        private void teacherPictureBox_MouseLeave(object sender, EventArgs e)
        {
            teacherPictureBox.Image = Resources.professor1;
        }

        private void studentPictureBox_MouseHover(object sender, EventArgs e)
        {
            studentPictureBox.Image = Resources.graduate1;
        }

        private void studentPictureBox_MouseLeave(object sender, EventArgs e)
        {
            studentPictureBox.Image = Resources.graduate;
        }

        private void exitPictureBox_MouseHover(object sender, EventArgs e)
        {
            exitPictureBox.Image = Resources.icon1;
        }

        private void exitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            exitPictureBox.Image = Resources.icon;
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
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

        private void adminPictureBox_Click(object sender, EventArgs e)
        {
            AdminLogInForm openForm = new AdminLogInForm();
            openForm.Show();
            Visible = false;
        }

        private void teacherPictureBox_Click(object sender, EventArgs e)
        {
            TeacherLoginForm opnForm = new TeacherLoginForm();
            opnForm.Show();
            Visible = false;
        }

        private void studentPictureBox_Click(object sender, EventArgs e)
        {
            StudentLoginForm opnForm = new StudentLoginForm();
            opnForm.Show();
            Visible = false;
        }
    }
}
