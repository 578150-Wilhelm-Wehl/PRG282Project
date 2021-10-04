﻿
namespace PRG282Project.Presentation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlBaseLogin = new System.Windows.Forms.Panel();
            this.pnlLoginSignIn = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblWrongLogin = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.ckRememberMe = new System.Windows.Forms.CheckBox();
            this.txtSignInPassword = new System.Windows.Forms.TextBox();
            this.txtSignInUserName = new System.Windows.Forms.TextBox();
            this.btnSignMeIn = new System.Windows.Forms.Button();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.btnViewPassword = new System.Windows.Forms.Button();
            this.pnlLoginImge = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlBaseLogin.SuspendLayout();
            this.pnlLoginSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBaseLogin
            // 
            this.pnlBaseLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBaseLogin.Controls.Add(this.pnlLoginSignIn);
            this.pnlBaseLogin.Controls.Add(this.pnlLoginImge);
            this.pnlBaseLogin.Controls.Add(this.btnSignUp);
            this.pnlBaseLogin.Controls.Add(this.btnSignIn);
            this.pnlBaseLogin.Location = new System.Drawing.Point(239, 31);
            this.pnlBaseLogin.Name = "pnlBaseLogin";
            this.pnlBaseLogin.Size = new System.Drawing.Size(315, 415);
            this.pnlBaseLogin.TabIndex = 0;
            // 
            // pnlLoginSignIn
            // 
            this.pnlLoginSignIn.Controls.Add(this.lblPassword);
            this.pnlLoginSignIn.Controls.Add(this.lblWrongLogin);
            this.pnlLoginSignIn.Controls.Add(this.lblUserName);
            this.pnlLoginSignIn.Controls.Add(this.ckRememberMe);
            this.pnlLoginSignIn.Controls.Add(this.txtSignInPassword);
            this.pnlLoginSignIn.Controls.Add(this.txtSignInUserName);
            this.pnlLoginSignIn.Controls.Add(this.btnSignMeIn);
            this.pnlLoginSignIn.Controls.Add(this.btnForgotPassword);
            this.pnlLoginSignIn.Controls.Add(this.btnViewPassword);
            this.pnlLoginSignIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLoginSignIn.Location = new System.Drawing.Point(0, 196);
            this.pnlLoginSignIn.Name = "pnlLoginSignIn";
            this.pnlLoginSignIn.Size = new System.Drawing.Size(315, 219);
            this.pnlLoginSignIn.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(130, 65);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblWrongLogin
            // 
            this.lblWrongLogin.AutoSize = true;
            this.lblWrongLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongLogin.ForeColor = System.Drawing.Color.Red;
            this.lblWrongLogin.Location = new System.Drawing.Point(87, 109);
            this.lblWrongLogin.Name = "lblWrongLogin";
            this.lblWrongLogin.Size = new System.Drawing.Size(156, 20);
            this.lblWrongLogin.TabIndex = 2;
            this.lblWrongLogin.Text = "Incorrect Credentials";
            this.lblWrongLogin.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(126, 21);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(77, 16);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // ckRememberMe
            // 
            this.ckRememberMe.AutoSize = true;
            this.ckRememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.ckRememberMe.ForeColor = System.Drawing.Color.Gray;
            this.ckRememberMe.Location = new System.Drawing.Point(17, 149);
            this.ckRememberMe.Name = "ckRememberMe";
            this.ckRememberMe.Size = new System.Drawing.Size(107, 19);
            this.ckRememberMe.TabIndex = 1;
            this.ckRememberMe.Text = "Remember Me";
            this.ckRememberMe.UseVisualStyleBackColor = true;
            // 
            // txtSignInPassword
            // 
            this.txtSignInPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignInPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignInPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSignInPassword.Location = new System.Drawing.Point(72, 84);
            this.txtSignInPassword.Name = "txtSignInPassword";
            this.txtSignInPassword.PasswordChar = '*';
            this.txtSignInPassword.Size = new System.Drawing.Size(181, 22);
            this.txtSignInPassword.TabIndex = 0;
            this.txtSignInPassword.Text = "Admin";
            this.txtSignInPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSignInUserName
            // 
            this.txtSignInUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignInUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignInUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSignInUserName.Location = new System.Drawing.Point(72, 40);
            this.txtSignInUserName.Name = "txtSignInUserName";
            this.txtSignInUserName.Size = new System.Drawing.Size(181, 22);
            this.txtSignInUserName.TabIndex = 0;
            this.txtSignInUserName.Text = "Admin";
            this.txtSignInUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSignMeIn
            // 
            this.btnSignMeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(217)))), ((int)(((byte)(227)))));
            this.btnSignMeIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignMeIn.FlatAppearance.BorderSize = 0;
            this.btnSignMeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignMeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignMeIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignMeIn.Location = new System.Drawing.Point(0, 174);
            this.btnSignMeIn.Name = "btnSignMeIn";
            this.btnSignMeIn.Size = new System.Drawing.Size(315, 45);
            this.btnSignMeIn.TabIndex = 0;
            this.btnSignMeIn.Text = "Sign Me In";
            this.btnSignMeIn.UseVisualStyleBackColor = false;
            this.btnSignMeIn.Click += new System.EventHandler(this.btnSignMeIn_Click);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnForgotPassword.FlatAppearance.BorderSize = 0;
            this.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPassword.ForeColor = System.Drawing.Color.Gray;
            this.btnForgotPassword.Location = new System.Drawing.Point(179, 145);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(136, 26);
            this.btnForgotPassword.TabIndex = 0;
            this.btnForgotPassword.Text = "Forgot Password?";
            this.btnForgotPassword.UseVisualStyleBackColor = false;
            // 
            // btnViewPassword
            // 
            this.btnViewPassword.BackColor = System.Drawing.SystemColors.Window;
            this.btnViewPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewPassword.BackgroundImage")));
            this.btnViewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPassword.ForeColor = System.Drawing.Color.Gray;
            this.btnViewPassword.Location = new System.Drawing.Point(249, 84);
            this.btnViewPassword.Name = "btnViewPassword";
            this.btnViewPassword.Size = new System.Drawing.Size(34, 22);
            this.btnViewPassword.TabIndex = 0;
            this.btnViewPassword.UseVisualStyleBackColor = false;
            this.btnViewPassword.Click += new System.EventHandler(this.btnViewPassword_Click);
            // 
            // pnlLoginImge
            // 
            this.pnlLoginImge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLoginImge.BackgroundImage")));
            this.pnlLoginImge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLoginImge.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoginImge.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginImge.Name = "pnlLoginImge";
            this.pnlLoginImge.Size = new System.Drawing.Size(315, 168);
            this.pnlLoginImge.TabIndex = 0;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSignUp.Location = new System.Drawing.Point(158, 165);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(157, 33);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSignIn.Location = new System.Drawing.Point(0, 165);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(157, 33);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.Location = new System.Drawing.Point(772, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinimize.Location = new System.Drawing.Point(747, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.pnlBaseLogin);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.pnlBaseLogin.ResumeLayout(false);
            this.pnlLoginSignIn.ResumeLayout(false);
            this.pnlLoginSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBaseLogin;
        private System.Windows.Forms.Panel pnlLoginImge;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Panel pnlLoginSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.CheckBox ckRememberMe;
        private System.Windows.Forms.TextBox txtSignInPassword;
        private System.Windows.Forms.TextBox txtSignInUserName;
        private System.Windows.Forms.Button btnSignMeIn;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.Button btnViewPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblWrongLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
    }
}