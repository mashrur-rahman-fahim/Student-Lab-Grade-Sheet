using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentLabGradeSheet
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            panelLogin = new Panel();
            btnExit = new Button();
            loginBtn = new Button();
            password = new TextBox();
            userName = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pictureBoxLogo = new PictureBox();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(btnExit);
            panelLogin.Controls.Add(loginBtn);
            panelLogin.Controls.Add(password);
            panelLogin.Controls.Add(userName);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Controls.Add(lblSubtitle);
            panelLogin.Controls.Add(lblTitle);
            panelLogin.Location = new Point(350, 120);
            panelLogin.Name = "panelLogin";
            panelLogin.Padding = new Padding(40);
            panelLogin.Size = new Size(400, 450);
            panelLogin.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(108, 117, 125);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(50, 360);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 40);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(0, 123, 255);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(230, 360);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(120, 40);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += button1_Click;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Segoe UI", 11F);
            password.Location = new Point(50, 280);
            password.Name = "password";
            password.Size = new Size(300, 27);
            password.TabIndex = 2;
            password.UseSystemPasswordChar = true;
            password.KeyPress += password_KeyPress;
            // 
            // userName
            // 
            userName.BorderStyle = BorderStyle.FixedSingle;
            userName.Font = new Font("Segoe UI", 11F);
            userName.Location = new Point(50, 200);
            userName.Name = "userName";
            userName.Size = new Size(300, 27);
            userName.TabIndex = 1;
            userName.KeyPress += userName_KeyPress;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F);
            lblPassword.ForeColor = Color.FromArgb(33, 37, 41);
            lblPassword.Location = new Point(50, 250);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            lblPassword.Click += label3_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11F);
            lblUsername.ForeColor = Color.FromArgb(33, 37, 41);
            lblUsername.Location = new Point(50, 170);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            lblUsername.Click += label2_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitle.Location = new Point(50, 80);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(300, 50);
            lblSubtitle.TabIndex = 4;
            lblSubtitle.Text = "Please enter your credentials to access the Student Grade Management System";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 123, 255);
            lblTitle.Location = new Point(130, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 45);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Welcome";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Location = new Point(100, 200);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 200);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 255);
            ClientSize = new Size(1100, 700);
            Controls.Add(pictureBoxLogo);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Grade Sheet - Login";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private TextBox userName;
        private TextBox password;
        private Button loginBtn;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblSubtitle;
        private Button btnExit;
        private PictureBox pictureBoxLogo;
    }
}