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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pnlAddstudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmbModuleAmount_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbModuleAmount.Text == "1")
            {
                lblModule1.Visible = true;
                cmbModule1.Visible = true;

                lblModule2.Visible = false;
                cmbModule2.Visible = false;
                lblModule3.Visible = false;
                cmbModule3.Visible = false;
                lblModule4.Visible = false;
                cmbModule4.Visible = false;
                lblModule5.Visible = false;
                cmbModule5.Visible = false;
                lblModule6.Visible = false;
                cmbModule6.Visible = false;

            }
            else if (cmbModuleAmount.Text == "2")
            {
                lblModule1.Visible = true;
                cmbModule1.Visible = true;
                lblModule2.Visible = true;
                cmbModule2.Visible = true;

                lblModule3.Visible = false;
                cmbModule3.Visible = false;
                lblModule4.Visible = false;
                cmbModule4.Visible = false;
                lblModule5.Visible = false;
                cmbModule5.Visible = false;
                lblModule6.Visible = false;
                cmbModule6.Visible = false;
            }
            else if (cmbModuleAmount.Text == "3")
            {
                lblModule1.Visible = true;
                cmbModule1.Visible = true;
                lblModule2.Visible = true;
                cmbModule2.Visible = true;
                lblModule3.Visible = true;
                cmbModule3.Visible = true;

                lblModule4.Visible = false;
                cmbModule4.Visible = false;
                lblModule5.Visible = false;
                cmbModule5.Visible = false;
                lblModule6.Visible = false;
                cmbModule6.Visible = false;

            }
            else if (cmbModuleAmount.Text == "4")
            {
                lblModule1.Visible = true;
                cmbModule1.Visible = true;
                lblModule2.Visible = true;
                cmbModule2.Visible = true;
                lblModule3.Visible = true;
                cmbModule3.Visible = true;
                lblModule4.Visible = true;
                cmbModule4.Visible = true;

                lblModule5.Visible = false;
                cmbModule5.Visible = false;
                lblModule6.Visible = false;
                cmbModule6.Visible = false;
            }
            else if (cmbModuleAmount.Text == "5")
            {
                lblModule1.Visible = true;
                cmbModule1.Visible = true;
                lblModule2.Visible = true;
                cmbModule2.Visible = true;
                lblModule3.Visible = true;
                cmbModule3.Visible = true;
                lblModule4.Visible = true;
                cmbModule4.Visible = true;
                lblModule5.Visible = true;
                cmbModule5.Visible = true;

                lblModule6.Visible = false;
                cmbModule6.Visible = false;
            }
            else if (cmbModuleAmount.Text == "6")
            {
                lblModule1.Visible = true;
                cmbModule1.Visible = true;
                lblModule2.Visible = true;
                cmbModule2.Visible = true;
                lblModule3.Visible = true;
                cmbModule3.Visible = true;
                lblModule4.Visible = true;
                cmbModule4.Visible = true;
                lblModule5.Visible = true;
                cmbModule5.Visible = true;
                lblModule6.Visible = true;
                cmbModule6.Visible = true;
            }


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

        private void rbnSearchUsingStudentNo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
