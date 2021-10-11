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
using PRG282Project.Data_Access;
using System.IO;



namespace PRG282Project.Presentation
{
    public partial class Main : Form
    {

        DataHandler handler = new DataHandler();
        FileHandler Fhandler = new FileHandler();
        //string filename;
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
            handler.MainPanelManger(pnlAddmodule, pnlManageStudents, pnlAddstudent, pnlManageModules, pnlInfo, pnlSpare1);
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
            dgvmodules.DataSource = Fhandler.GetModules();
            dgvStudents.DataSource = Fhandler.GetStudents();
            dgvStudents.Columns["StudentImage"].Visible = false;


            foreach (DataRow item in Fhandler.GetModules().Rows)
            {
                string moduleList = item["ModuleID"].ToString() + "-"+item["ModuleCode"].ToString() + "-" + item["ModuleName"].ToString() + "-" + item["ModuleDescription"].ToString();
                lstSelectModules.Items.Add(moduleList);
            }
        }

        private void lblCurrentStudent_Click(object sender, EventArgs e)
        {

        }

        private void pnlAddstudent_Paint(object sender, PaintEventArgs e)
        {

        }

        string StuID = String.Empty;

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            string gender = null;
            if (rbtMale.Checked.Equals(true))
            {
                gender = "Male";
            }
            else if (rbtFemale.Checked.Equals(true))
            {
                gender = "Female";
            }
            else if (rbtOther.Checked.Equals(true))
            {
                gender = "Other";
            }
            else
            {
                MessageBox.Show("Please select a Gender");
            }

            

            Fhandler.InsertStudent(txtNewStudentName.Text, txtNewStudentSurname.Text, txtNewStudentImagePath.Text , txtNewDateOfBirth.Text, gender, txtNewPhoneNumber.Text, txtNewAddress.Text);
            foreach (DataRow item in Fhandler.FetchStudent(txtNewStudentName.Text, txtNewStudentSurname.Text, txtNewDateOfBirth.Text, txtNewPhoneNumber.Text, txtNewAddress.Text).Rows)
            {
                StuID += item["StudentNumber"].ToString();
            } 
            
            foreach (var item in lstSelectModules.SelectedItems)
            {
                string[] split = item.ToString().Split('-');
                Fhandler.InsertBridge(StuID,split[0]);
            }


        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; .bmp)|.jpg; *.jpeg; *.gif; *.bmp)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box

                picbxStudentImage.Image = new Bitmap(open.FileName);
                txtNewStudentImagePath.Text = open.FileName;
                picbxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvStudents.Rows[e.RowIndex];
                    if (row.Cells["StudentImage"].Value != DBNull.Value)
                    {
                        var data = (Byte[])(row.Cells["StudentImage"].Value);
                        var stream = new MemoryStream(data);
                        picManStudent.Image = Image.FromStream(stream);
                        picManStudent.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        picManStudent.Image = null;
                    }
                    txtManStudentsNumber.Text = row.Cells["StudentNumber"].Value.ToString();
                    txtManStudentsName.Text = row.Cells["StundentName"].Value.ToString(); ;
                    txtManStundentSurname.Text = row.Cells["StudentSurname"].Value.ToString(); ;
                    txtManDateOfBirth.Text = row.Cells["DateOfBirth"].Value.ToString(); ;
                    txtManPhones.Text = row.Cells["PhoneNumber"].Value.ToString(); ;
                    txtManAddress.Text = row.Cells["StudentAddress"].Value.ToString();
                    txtManGender.Text = row.Cells["Gender"].Value.ToString();

                    lsbStudentModules.Items.Clear();

                    foreach (DataRow item in Fhandler.SearchStudentModules(txtManStudentsNumber.Text).Rows)
                    {
                        string moduleList = item["ModuleCode"].ToString() + "\t\t" + item["ModuleName"].ToString() + "\t\t" + item["ModuleDescription"].ToString();
                        lsbStudentModules.Items.Add(moduleList);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = Fhandler.SearchStudents(txtSearchStudent.Text);

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = Fhandler.GetStudents();
            dgvStudents.Columns["StudentImage"].Visible = false;
        }

        private void btnModuleDelete_Click(object sender, EventArgs e)
        {
            dgvmodules.DataSource = null;
            Fhandler.DeleteModules(txtManModuleID.Text);
            dgvmodules.DataSource = Fhandler.GetModules();
        }

        private void dgvmodules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvmodules.Rows[e.RowIndex];
                txtManModuleID.Text = row.Cells["ModuleID"].Value.ToString();
                txtManModuleCode.Text = row.Cells["ModuleCode"].Value.ToString();
                txtManModuleName.Text = row.Cells["ModuleName"].Value.ToString();
                txtManModuleDescription.Text = row.Cells["ModuleDescription"].Value.ToString();
                lsbModuleResources.Items.Clear();
                foreach (DataRow item in Fhandler.GetResources(txtManModuleID.Text).Rows)
                {
                    string ResourceList = item["ResouceLink"].ToString();
                    lsbModuleResources.Items.Add(ResourceList);
                }
            }
        }

        private void btnModuleUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdatestudent_Click(object sender, EventArgs e)
        {
            Fhandler.UpdateStudent(txtManStudentsName.Text, txtManStundentSurname.Text, Convert.ToDateTime(txtManDateOfBirth.Text), txtManGender.Text, txtNewPhoneNumber.Text, txtNewAddress.Text, Convert.ToInt32(txtManStudentsNumber.Text));
        }

        private void btnDeletestudent_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = null;
            Fhandler.DeleteStudent(txtManStudentsNumber.Text);
            dgvStudents.DataSource = Fhandler.GetStudents();
            dgvStudents.Columns["StudentImage"].Visible = false;
        }

        private void btnRegisterModule_Click(object sender, EventArgs e)
        {
            Fhandler.InsertModules(txtNewModulecode.Text, txtNewModuleName.Text, txtNewModuleDescription.Text);
            foreach (var item in lsbNewModuleResources.SelectedItems)
            {
                Fhandler.InsertResource(txtNewModulecode.Text, item.ToString());
            }
            txtNewModulecode.Clear();
            txtNewModuleName.Clear();
            txtNewModuleDescription.Clear();
            txtNewModuleResource.Clear();
            lsbNewModuleResources.Items.Clear();
            dgvmodules.DataSource = Fhandler.GetModules();
        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            lsbNewModuleResources.Items.Add(txtNewModuleResource.Text);
        }
    }
}
