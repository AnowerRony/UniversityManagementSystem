using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class TeacherLoginForm : Form
    {
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
    }
}
