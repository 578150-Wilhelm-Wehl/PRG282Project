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
    public partial class Main : Form
    {
        DataHandler handler = new DataHandler();

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

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            handler.MainPanelManger(pnlAddstudent, pnlManageStudents, pnlAddmodule, pnlManageModules, pnlSpare1, pnlSpare2);
        }

        private void btnManagestudents_Click(object sender, EventArgs e)
        {
            handler.MainPanelManger(pnlManageStudents, pnlAddstudent, pnlAddmodule, pnlManageModules, pnlSpare1, pnlSpare2);
        }

        private void btnaddmodule_Click(object sender, EventArgs e)
        {
            handler.MainPanelManger(pnlAddmodule, pnlManageStudents, pnlAddstudent,  pnlManageModules, pnlSpare1, pnlSpare2);
        }

        private void btnManageModule_Click(object sender, EventArgs e)
        {
            handler.MainPanelManger(pnlManageModules, pnlAddmodule, pnlManageStudents, pnlAddstudent, pnlSpare1, pnlSpare2);
        }
    }
}
