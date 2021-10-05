using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282Project.Logic;

namespace PRG282Project.Presentation
{
    public partial class Login : Form
    {

        DataHandler handler = new DataHandler();
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignMeIn_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            handler.VeryfyUser(txtSignInUserName.Text, txtSignInPassword.Text, lblWrongLogin);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (txtSignInPassword.PasswordChar == '*')
            {
                txtSignInPassword.PasswordChar = '\0';
            }
            else
            {
                txtSignInPassword.PasswordChar = '*';
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            btnSignUp.BackColor = Color.FromArgb(229,229,229);
            btnSignIn.BackColor = Color.FromArgb(245,245,245);
            handler.LoginPanelManger(pnlSignUp, pnlLoginSignIn, pnlPasswordReset);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            btnSignUp.BackColor = Color.FromArgb(245, 245, 245);
            btnSignIn.BackColor = Color.FromArgb(229, 229, 229);
            handler.LoginPanelManger(pnlLoginSignIn,pnlSignUp, pnlPasswordReset);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            handler.AddUser(txtSignUpUserName.Text,txtSignUpPassword.Text,cmbSignUpSecurityQuestion.Text,txtSignUpSecurityAnswer.Text);
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            handler.LoginPanelManger(pnlPasswordReset, pnlLoginSignIn, pnlSignUp);
            btnSignUp.BackColor = Color.FromArgb(245, 245, 245);
            btnSignIn.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.FromArgb(245, 245, 245);
            btnSignIn.BackColor = Color.FromArgb(229, 229, 229);
            handler.LoginPanelManger(pnlLoginSignIn, pnlSignUp, pnlPasswordReset);
        }

        private void txtResetAnswer_Click(object sender, EventArgs e)
        {
            handler.SecurityQuestion(txtResetUserName.Text, lblSecQuest);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            handler.PasswordReset(txtResetUserName.Text,  txtResetAnswer.Text, txtNewPassword.Text);
        }
    }
}
