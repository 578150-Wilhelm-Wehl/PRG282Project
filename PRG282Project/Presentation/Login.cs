using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282Project.Presentation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignMeIn_Click(object sender, EventArgs e)
        {

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
            btnSignUp.BackColor = Color.FromArgb(229,229,229);
            btnSignIn.BackColor = Color.FromArgb(245,245,245);
            pnlLoginSignIn.Visible = false;
            pnlLoginSignIn.Enabled = false;
            pnlSignUp.Visible = true;
            pnlSignUp.Enabled = true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.FromArgb(245, 245, 245);
            btnSignIn.BackColor = Color.FromArgb(229, 229, 229);
            pnlSignUp.Enabled = false;
            pnlSignUp.Visible = false;
            pnlLoginSignIn.Visible = true;
            pnlLoginSignIn.Enabled = true;

        }
    }
}
