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
    public partial class StudentLoginForm : Form
    {
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
    }
}
