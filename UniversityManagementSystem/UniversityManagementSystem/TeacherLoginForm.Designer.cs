namespace UniversityManagementSystem
{
    partial class TeacherLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherLoginForm));
            this.teacherBackPictureBox = new System.Windows.Forms.PictureBox();
            this.teacherExitPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userNamePictureBox = new System.Windows.Forms.PictureBox();
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.teacherUserNameTextBox = new System.Windows.Forms.TextBox();
            this.studentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.teacherLogInButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherExitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNamePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherBackPictureBox
            // 
            this.teacherBackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("teacherBackPictureBox.Image")));
            this.teacherBackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.teacherBackPictureBox.Name = "teacherBackPictureBox";
            this.teacherBackPictureBox.Size = new System.Drawing.Size(39, 37);
            this.teacherBackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacherBackPictureBox.TabIndex = 0;
            this.teacherBackPictureBox.TabStop = false;
            this.teacherBackPictureBox.Click += new System.EventHandler(this.teacherBackPictureBox_Click);
            // 
            // teacherExitPictureBox
            // 
            this.teacherExitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("teacherExitPictureBox.Image")));
            this.teacherExitPictureBox.Location = new System.Drawing.Point(398, 12);
            this.teacherExitPictureBox.Name = "teacherExitPictureBox";
            this.teacherExitPictureBox.Size = new System.Drawing.Size(39, 37);
            this.teacherExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacherExitPictureBox.TabIndex = 1;
            this.teacherExitPictureBox.TabStop = false;
            this.teacherExitPictureBox.Click += new System.EventHandler(this.teacherExitPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "TEACHER LOGIN";
            // 
            // userNamePictureBox
            // 
            this.userNamePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userNamePictureBox.Image")));
            this.userNamePictureBox.Location = new System.Drawing.Point(77, 166);
            this.userNamePictureBox.Name = "userNamePictureBox";
            this.userNamePictureBox.Size = new System.Drawing.Size(29, 25);
            this.userNamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userNamePictureBox.TabIndex = 3;
            this.userNamePictureBox.TabStop = false;
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("passwordPictureBox.Image")));
            this.passwordPictureBox.Location = new System.Drawing.Point(77, 244);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(29, 27);
            this.passwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordPictureBox.TabIndex = 3;
            this.passwordPictureBox.TabStop = false;
            // 
            // teacherUserNameTextBox
            // 
            this.teacherUserNameTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.teacherUserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teacherUserNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherUserNameTextBox.Location = new System.Drawing.Point(121, 166);
            this.teacherUserNameTextBox.Name = "teacherUserNameTextBox";
            this.teacherUserNameTextBox.Size = new System.Drawing.Size(224, 27);
            this.teacherUserNameTextBox.TabIndex = 4;
            // 
            // studentPasswordTextBox
            // 
            this.studentPasswordTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.studentPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentPasswordTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentPasswordTextBox.Location = new System.Drawing.Point(121, 244);
            this.studentPasswordTextBox.Name = "studentPasswordTextBox";
            this.studentPasswordTextBox.Size = new System.Drawing.Size(224, 27);
            this.studentPasswordTextBox.TabIndex = 4;
            // 
            // teacherLogInButton
            // 
            this.teacherLogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.teacherLogInButton.FlatAppearance.BorderSize = 0;
            this.teacherLogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherLogInButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLogInButton.ForeColor = System.Drawing.Color.White;
            this.teacherLogInButton.Location = new System.Drawing.Point(77, 347);
            this.teacherLogInButton.Name = "teacherLogInButton";
            this.teacherLogInButton.Size = new System.Drawing.Size(268, 36);
            this.teacherLogInButton.TabIndex = 5;
            this.teacherLogInButton.Text = "Log In";
            this.teacherLogInButton.UseVisualStyleBackColor = false;
            // 
            // TeacherLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(449, 555);
            this.Controls.Add(this.teacherLogInButton);
            this.Controls.Add(this.studentPasswordTextBox);
            this.Controls.Add(this.teacherUserNameTextBox);
            this.Controls.Add(this.passwordPictureBox);
            this.Controls.Add(this.userNamePictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teacherExitPictureBox);
            this.Controls.Add(this.teacherBackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherLoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.teacherBackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherExitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNamePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox teacherBackPictureBox;
        private System.Windows.Forms.PictureBox teacherExitPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox userNamePictureBox;
        private System.Windows.Forms.PictureBox passwordPictureBox;
        private System.Windows.Forms.TextBox teacherUserNameTextBox;
        private System.Windows.Forms.TextBox studentPasswordTextBox;
        private System.Windows.Forms.Button teacherLogInButton;
    }
}