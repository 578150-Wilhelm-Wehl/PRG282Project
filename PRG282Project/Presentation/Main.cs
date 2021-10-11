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
            lblAmountOfStudents.Text = Fhandler.GetStudents().Rows.Count.ToString();


            foreach (DataRow item in Fhandler.GetModules().Rows)
            {
                string moduleList = item["ModuleID"].ToString() + "-"+item["ModuleCode"].ToString() + "-" + item["ModuleName"].ToString() + "-" + item["ModuleDescription"].ToString();
                lstSelectModules.Items.Add(moduleList);
            }
        }
        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string StuID = String.Empty;
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
                    throw new EXStudentRegestrationFailed();
                }
                if (!String.IsNullOrEmpty(txtNewStudentName.Text) && !String.IsNullOrEmpty(txtNewStudentSurname.Text) && !String.IsNullOrEmpty(txtNewStudentImagePath.Text) && !String.IsNullOrEmpty(txtNewDateOfBirth.Text) && !String.IsNullOrEmpty(txtNewPhoneNumber.Text) && !String.IsNullOrEmpty(txtNewAddress.Text))
                {
                    Fhandler.InsertStudent(txtNewStudentName.Text, txtNewStudentSurname.Text, txtNewStudentImagePath.Text, txtNewDateOfBirth.Text, gender, txtNewPhoneNumber.Text, txtNewAddress.Text);
                    foreach (DataRow item in Fhandler.FetchStudent(txtNewStudentName.Text, txtNewStudentSurname.Text, txtNewDateOfBirth.Text, txtNewPhoneNumber.Text, txtNewAddress.Text).Rows)
                    {
                        StuID += item["StudentNumber"].ToString();
                    }
                    foreach (var item in lstSelectModules.SelectedItems)
                    {
                        string[] split = item.ToString().Split('-');
                        Fhandler.InsertBridge(StuID, split[0]);
                    }
                    lblAmountOfStudents.Text = Fhandler.GetStudents().Rows.Count.ToString();
                    rbtOther.Checked = false;
                    rbtFemale.Checked = false;
                    rbtMale.Checked = false;
                    txtNewStudentName.Clear();
                    txtNewStudentSurname.Clear();
                    txtNewStudentImagePath.Clear();
                    txtNewDateOfBirth.Value = DateTime.Today;
                    txtNewPhoneNumber.Clear();
                    txtNewAddress.Clear();
                }
                else
                {
                    throw new EXStudentRegestrationFailed();
                }
            }
            catch (EXStudentRegestrationFailed srf)
            {
                MessageBox.Show(srf.Message);
            }
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; .bmp)|*.jpg; *.jpeg; *.gif; *.bmp)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picbxStudentImage.Image = new Bitmap(open.FileName);
                txtNewStudentImagePath.Text = open.FileName;
                picbxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.RowIndex >= 0) && (e.RowIndex < dgvStudents.RowCount - 1))
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
                else
                {
                    txtManStudentsNumber.Clear();
                    txtManStudentsName.Clear();
                    txtManStundentSurname.Clear();
                    txtManPhones.Clear();
                    txtManAddress.Clear();
                    txtManGender.Clear();
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
            if ((e.RowIndex >= 0) && (e.RowIndex < dgvmodules.RowCount - 1))
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
            else
            {
                txtManModuleID.Clear();
                txtManModuleCode.Clear();
                txtManModuleName.Clear();
                txtManModuleDescription.Clear();
                lsbModuleResources.Items.Clear();
            }
        }
        private void btnModuleUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtManModuleCode.Text) && !String.IsNullOrEmpty(txtManModuleName.Text) && !String.IsNullOrEmpty(txtManModuleDescription.Text) && !String.IsNullOrEmpty(txtManModuleID.Text))
                {
                    Fhandler.UpdateModules(txtManModuleCode.Text, txtManModuleName.Text, txtManModuleDescription.Text, Convert.ToInt32(txtManModuleID.Text));
                }
                else
                {
                    throw new EXModuleUpdateFailed();
                }
            }
            catch (EXModuleUpdateFailed muf)
            {
                MessageBox.Show(muf.Message);
            }
        }
        private void btnUpdatestudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtManStudentsName.Text)&& !String.IsNullOrEmpty(txtManStundentSurname.Text)&& !String.IsNullOrEmpty(txtManDateOfBirth.Text)&& !String.IsNullOrEmpty(txtManGender.Text)&& !String.IsNullOrEmpty(txtNewPhoneNumber.Text)&& !String.IsNullOrEmpty(txtNewAddress.Text)&& !String.IsNullOrEmpty(txtManStudentsNumber.Text))
                {
                    Fhandler.UpdateStudent(txtManStudentsName.Text, txtManStundentSurname.Text, Convert.ToDateTime(txtManDateOfBirth.Text), txtManGender.Text, txtNewPhoneNumber.Text, txtNewAddress.Text, Convert.ToInt32(txtManStudentsNumber.Text));
                    dgvStudents.DataSource = Fhandler.GetStudents();
                }
                else
                {
                    throw new EXUpdateStudentFailed();
                }
            }
            catch (EXUpdateStudentFailed usf)
            {
                MessageBox.Show(usf.Message);
            }
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
            try
            {
                if (!String.IsNullOrEmpty(txtNewModulecode.Text)&& !String.IsNullOrEmpty(txtNewModuleName.Text)&& !String.IsNullOrEmpty(txtNewModuleDescription.Text)&& lsbNewModuleResources.Items.Count>0)
                {
                    string ModID = String.Empty;
                    Fhandler.InsertModules(txtNewModulecode.Text, txtNewModuleName.Text, txtNewModuleDescription.Text);
                    foreach (DataRow item in Fhandler.FetchModuleID(txtNewModulecode.Text).Rows)
                    {
                        ModID += item[0].ToString();
                    }
                    foreach (var item in lsbNewModuleResources.Items)
                    {
                        Fhandler.InsertResource(ModID, item.ToString());
                    }
                    txtNewModulecode.Clear();
                    txtNewModuleName.Clear();
                    txtNewModuleDescription.Clear();
                    txtNewModuleResource.Clear();
                    lsbNewModuleResources.Items.Clear();
                }
                else
                {
                    throw new EXRegisterModuleFailed();
                }
            }
            catch (EXRegisterModuleFailed rmf)
            {
                MessageBox.Show(rmf.Message);
            }
        }
        private void btnAddResource_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNewModuleResource.Text))
            {
                lsbNewModuleResources.Items.Add(txtNewModuleResource.Text);
                txtNewModuleResource.Clear();
            }
            else
            {
                MessageBox.Show("PLease add resource URL to the resource text box");
            }
        }
        private void btnModuleSearch_Click(object sender, EventArgs e)
        {
            dgvmodules.DataSource = Fhandler.SearchModules(txtManModuleSearch.Text);
        }
        private void btnViewAllModules_Click(object sender, EventArgs e)
        {
            dgvmodules.DataSource = Fhandler.ViewModules();
        }
    }
}
