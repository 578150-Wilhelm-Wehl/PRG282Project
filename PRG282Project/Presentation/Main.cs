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
            if (pnlStudentOptions.Visible == false)
            {
                pnlStudentOptions.Visible = true;
            }
            else
            {
                pnlStudentOptions.Visible = false;
            }

        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            pnlStudentOptions.Visible = false;
            if (pnlModuleOptions.Visible == false)
            {
                pnlModuleOptions.Visible = true;
            }
            else
            {
                pnlModuleOptions.Visible = false;
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            handler.MainPanelManger(pnlAddstudent, pnlManageStudents, pnlAddmodule, pnlManageModules, pnlInfo, pnlSpare1);
        }

        private void btnManagestudents_Click(object sender, EventArgs e)
        {
            handler.MainPanelManger(pnlManageStudents, pnlAddstudent, pnlAddmodule, pnlManageModules, pnlInfo, pnlSpare1);
        }

        private void btnaddmodule_Click(object sender, EventArgs e)
        {
            handler.MainPanelManger(pnlAddmodule, pnlManageStudents, pnlAddstudent,  pnlManageModules, pnlInfo, pnlSpare1);
        }

        private void btnManageModule_Click(object sender, EventArgs e)
        {
            handler.MainPanelManger(pnlManageModules, pnlAddmodule, pnlManageStudents, pnlAddstudent, pnlInfo, pnlSpare1);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            handler.MainPanelManger(pnlInfo, pnlManageModules, pnlAddmodule, pnlManageStudents, pnlAddstudent, pnlSpare1);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            lblStudentCount.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lblStudentCount.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have no messages");
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void lblCurrentStudent_Click(object sender, EventArgs e)
        {

        }

        private void pnlAddstudent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
