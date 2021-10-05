
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
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbSignUpSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.lblSecurityAnswer = new System.Windows.Forms.Label();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.lblSignUpPassword = new System.Windows.Forms.Label();
            this.lblCreateNewUser = new System.Windows.Forms.Label();
            this.lblSignUpUserName = new System.Windows.Forms.Label();
            this.txtSignUpSecurityAnswer = new System.Windows.Forms.TextBox();
            this.txtSignUpPassword = new System.Windows.Forms.TextBox();
            this.txtSignUpUserName = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.pnlLoginImge = new System.Windows.Forms.Panel();
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlPasswordReset = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbResetQuestion = new System.Windows.Forms.ComboBox();
            this.lblResetAnswer = new System.Windows.Forms.Label();
            this.lblResetQuestion = new System.Windows.Forms.Label();
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.lblResetUserName = new System.Windows.Forms.Label();
            this.txtResetAnswer = new System.Windows.Forms.TextBox();
            this.txtResetUserName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlBaseLogin.SuspendLayout();
            this.pnlSignUp.SuspendLayout();
            this.pnlLoginSignIn.SuspendLayout();
            this.pnlPasswordReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBaseLogin
            // 
            this.pnlBaseLogin.AutoScroll = true;
            this.pnlBaseLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBaseLogin.Controls.Add(this.btnSignIn);
            this.pnlBaseLogin.Controls.Add(this.pnlLoginImge);
            this.pnlBaseLogin.Controls.Add(this.pnlLoginSignIn);
            this.pnlBaseLogin.Controls.Add(this.btnSignUp);
            this.pnlBaseLogin.Controls.Add(this.pnlSignUp);
            this.pnlBaseLogin.Controls.Add(this.pnlPasswordReset);
            this.pnlBaseLogin.Location = new System.Drawing.Point(247, 26);
            this.pnlBaseLogin.Name = "pnlBaseLogin";
            this.pnlBaseLogin.Size = new System.Drawing.Size(315, 426);
            this.pnlBaseLogin.TabIndex = 0;
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.Controls.Add(this.btnSubmit);
            this.pnlSignUp.Controls.Add(this.cmbSignUpSecurityQuestion);
            this.pnlSignUp.Controls.Add(this.lblSecurityAnswer);
            this.pnlSignUp.Controls.Add(this.lblSecurityQuestion);
            this.pnlSignUp.Controls.Add(this.lblSignUpPassword);
            this.pnlSignUp.Controls.Add(this.lblCreateNewUser);
            this.pnlSignUp.Controls.Add(this.lblSignUpUserName);
            this.pnlSignUp.Controls.Add(this.txtSignUpSecurityAnswer);
            this.pnlSignUp.Controls.Add(this.txtSignUpPassword);
            this.pnlSignUp.Controls.Add(this.txtSignUpUserName);
            this.pnlSignUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSignUp.Location = new System.Drawing.Point(0, 418);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(315, 220);
            this.pnlSignUp.TabIndex = 3;
            this.pnlSignUp.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Cyan;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(0, 190);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(315, 30);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbSignUpSecurityQuestion
            // 
            this.cmbSignUpSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbSignUpSecurityQuestion.FormattingEnabled = true;
            this.cmbSignUpSecurityQuestion.Items.AddRange(new object[] {
            "First car brand",
            "First pet name",
            "Anevirsary date",
            "Shoe size"});
            this.cmbSignUpSecurityQuestion.Location = new System.Drawing.Point(22, 112);
            this.cmbSignUpSecurityQuestion.Name = "cmbSignUpSecurityQuestion";
            this.cmbSignUpSecurityQuestion.Size = new System.Drawing.Size(279, 24);
            this.cmbSignUpSecurityQuestion.TabIndex = 7;
            // 
            // lblSecurityAnswer
            // 
            this.lblSecurityAnswer.AutoSize = true;
            this.lblSecurityAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityAnswer.Location = new System.Drawing.Point(8, 148);
            this.lblSecurityAnswer.Name = "lblSecurityAnswer";
            this.lblSecurityAnswer.Size = new System.Drawing.Size(103, 16);
            this.lblSecurityAnswer.TabIndex = 5;
            this.lblSecurityAnswer.Text = "Security Answer";
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestion.Location = new System.Drawing.Point(108, 94);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(112, 16);
            this.lblSecurityQuestion.TabIndex = 5;
            this.lblSecurityQuestion.Text = "Security Question";
            // 
            // lblSignUpPassword
            // 
            this.lblSignUpPassword.AutoSize = true;
            this.lblSignUpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpPassword.Location = new System.Drawing.Point(8, 71);
            this.lblSignUpPassword.Name = "lblSignUpPassword";
            this.lblSignUpPassword.Size = new System.Drawing.Size(68, 16);
            this.lblSignUpPassword.TabIndex = 5;
            this.lblSignUpPassword.Text = "Password";
            // 
            // lblCreateNewUser
            // 
            this.lblCreateNewUser.AutoSize = true;
            this.lblCreateNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateNewUser.Location = new System.Drawing.Point(108, 13);
            this.lblCreateNewUser.Name = "lblCreateNewUser";
            this.lblCreateNewUser.Size = new System.Drawing.Size(125, 16);
            this.lblCreateNewUser.TabIndex = 6;
            this.lblCreateNewUser.Text = "Create New User";
            // 
            // lblSignUpUserName
            // 
            this.lblSignUpUserName.AutoSize = true;
            this.lblSignUpUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpUserName.Location = new System.Drawing.Point(8, 43);
            this.lblSignUpUserName.Name = "lblSignUpUserName";
            this.lblSignUpUserName.Size = new System.Drawing.Size(77, 16);
            this.lblSignUpUserName.TabIndex = 6;
            this.lblSignUpUserName.Text = "User Name";
            // 
            // txtSignUpSecurityAnswer
            // 
            this.txtSignUpSecurityAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignUpSecurityAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUpSecurityAnswer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSignUpSecurityAnswer.Location = new System.Drawing.Point(117, 146);
            this.txtSignUpSecurityAnswer.Name = "txtSignUpSecurityAnswer";
            this.txtSignUpSecurityAnswer.Size = new System.Drawing.Size(155, 22);
            this.txtSignUpSecurityAnswer.TabIndex = 3;
            this.txtSignUpSecurityAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSignUpPassword
            // 
            this.txtSignUpPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignUpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUpPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSignUpPassword.Location = new System.Drawing.Point(91, 69);
            this.txtSignUpPassword.Name = "txtSignUpPassword";
            this.txtSignUpPassword.Size = new System.Drawing.Size(181, 22);
            this.txtSignUpPassword.TabIndex = 3;
            this.txtSignUpPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSignUpUserName
            // 
            this.txtSignUpUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSignUpUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUpUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSignUpUserName.Location = new System.Drawing.Point(91, 41);
            this.txtSignUpUserName.Name = "txtSignUpUserName";
            this.txtSignUpUserName.Size = new System.Drawing.Size(181, 22);
            this.txtSignUpUserName.TabIndex = 4;
            this.txtSignUpUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
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
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
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
            this.pnlLoginSignIn.Location = new System.Drawing.Point(0, 198);
            this.pnlLoginSignIn.Name = "pnlLoginSignIn";
            this.pnlLoginSignIn.Size = new System.Drawing.Size(315, 220);
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
            this.btnSignMeIn.BackColor = System.Drawing.Color.Cyan;
            this.btnSignMeIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignMeIn.FlatAppearance.BorderSize = 0;
            this.btnSignMeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignMeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignMeIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignMeIn.Location = new System.Drawing.Point(0, 190);
            this.btnSignMeIn.Name = "btnSignMeIn";
            this.btnSignMeIn.Size = new System.Drawing.Size(315, 30);
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
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
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
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
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
            // pnlPasswordReset
            // 
            this.pnlPasswordReset.Controls.Add(this.btnBack);
            this.pnlPasswordReset.Controls.Add(this.btnReset);
            this.pnlPasswordReset.Controls.Add(this.cmbResetQuestion);
            this.pnlPasswordReset.Controls.Add(this.lblResetAnswer);
            this.pnlPasswordReset.Controls.Add(this.lblResetQuestion);
            this.pnlPasswordReset.Controls.Add(this.lblResetPassword);
            this.pnlPasswordReset.Controls.Add(this.lblResetUserName);
            this.pnlPasswordReset.Controls.Add(this.txtResetAnswer);
            this.pnlPasswordReset.Controls.Add(this.txtResetUserName);
            this.pnlPasswordReset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPasswordReset.Location = new System.Drawing.Point(0, 638);
            this.pnlPasswordReset.Name = "pnlPasswordReset";
            this.pnlPasswordReset.Size = new System.Drawing.Size(315, 220);
            this.pnlPasswordReset.TabIndex = 4;
            this.pnlPasswordReset.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Cyan;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(0, 187);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(156, 30);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // cmbResetQuestion
            // 
            this.cmbResetQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbResetQuestion.FormattingEnabled = true;
            this.cmbResetQuestion.Items.AddRange(new object[] {
            "First car brand",
            "First pet name",
            "Anevirsary date",
            "Shoe size"});
            this.cmbResetQuestion.Location = new System.Drawing.Point(22, 97);
            this.cmbResetQuestion.Name = "cmbResetQuestion";
            this.cmbResetQuestion.Size = new System.Drawing.Size(279, 24);
            this.cmbResetQuestion.TabIndex = 7;
            // 
            // lblResetAnswer
            // 
            this.lblResetAnswer.AutoSize = true;
            this.lblResetAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetAnswer.Location = new System.Drawing.Point(8, 148);
            this.lblResetAnswer.Name = "lblResetAnswer";
            this.lblResetAnswer.Size = new System.Drawing.Size(103, 16);
            this.lblResetAnswer.TabIndex = 5;
            this.lblResetAnswer.Text = "Security Answer";
            // 
            // lblResetQuestion
            // 
            this.lblResetQuestion.AutoSize = true;
            this.lblResetQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetQuestion.Location = new System.Drawing.Point(108, 79);
            this.lblResetQuestion.Name = "lblResetQuestion";
            this.lblResetQuestion.Size = new System.Drawing.Size(112, 16);
            this.lblResetQuestion.TabIndex = 5;
            this.lblResetQuestion.Text = "Security Question";
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPassword.Location = new System.Drawing.Point(108, 13);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(121, 16);
            this.lblResetPassword.TabIndex = 6;
            this.lblResetPassword.Text = "Reset Password";
            // 
            // lblResetUserName
            // 
            this.lblResetUserName.AutoSize = true;
            this.lblResetUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetUserName.Location = new System.Drawing.Point(8, 43);
            this.lblResetUserName.Name = "lblResetUserName";
            this.lblResetUserName.Size = new System.Drawing.Size(77, 16);
            this.lblResetUserName.TabIndex = 6;
            this.lblResetUserName.Text = "User Name";
            // 
            // txtResetAnswer
            // 
            this.txtResetAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResetAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResetAnswer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtResetAnswer.Location = new System.Drawing.Point(117, 146);
            this.txtResetAnswer.Name = "txtResetAnswer";
            this.txtResetAnswer.Size = new System.Drawing.Size(155, 22);
            this.txtResetAnswer.TabIndex = 3;
            this.txtResetAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResetUserName
            // 
            this.txtResetUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResetUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResetUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtResetUserName.Location = new System.Drawing.Point(91, 41);
            this.txtResetUserName.Name = "txtResetUserName";
            this.txtResetUserName.Size = new System.Drawing.Size(181, 22);
            this.txtResetUserName.TabIndex = 4;
            this.txtResetUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Cyan;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(159, 187);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 30);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.pnlBaseLogin);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.pnlBaseLogin.ResumeLayout(false);
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            this.pnlLoginSignIn.ResumeLayout(false);
            this.pnlLoginSignIn.PerformLayout();
            this.pnlPasswordReset.ResumeLayout(false);
            this.pnlPasswordReset.PerformLayout();
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
        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbSignUpSecurityQuestion;
        private System.Windows.Forms.Label lblSecurityAnswer;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.Label lblSignUpPassword;
        private System.Windows.Forms.Label lblCreateNewUser;
        private System.Windows.Forms.Label lblSignUpUserName;
        private System.Windows.Forms.TextBox txtSignUpSecurityAnswer;
        private System.Windows.Forms.TextBox txtSignUpPassword;
        private System.Windows.Forms.TextBox txtSignUpUserName;
        private System.Windows.Forms.Panel pnlPasswordReset;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbResetQuestion;
        private System.Windows.Forms.Label lblResetAnswer;
        private System.Windows.Forms.Label lblResetQuestion;
        private System.Windows.Forms.Label lblResetPassword;
        private System.Windows.Forms.Label lblResetUserName;
        private System.Windows.Forms.TextBox txtResetAnswer;
        private System.Windows.Forms.TextBox txtResetUserName;
        private System.Windows.Forms.Button btnBack;
    }
}