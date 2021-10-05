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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            pnlModuleOptions.Visible = false;
            pnlStudentOptions.Visible = true;
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            pnlStudentOptions.Visible = false;
            pnlModuleOptions.Visible = true;
        }
    }
}
