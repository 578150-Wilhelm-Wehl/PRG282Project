﻿using System;
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
            dgvStudents.DataSource = Fhandler.GetStudents();
        }

        private void lblCurrentStudent_Click(object sender, EventArgs e)
        {

        }

        private void pnlAddstudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            //string gender = null;
            //if (rbtMale.Checked.Equals(true))
            //{
            //    gender = "Male";
            //}
            //else if (rbtFemale.Checked.Equals(true))
            //{
            //    gender = "Female";
            //}
            //else if (rbtOther.Checked.Equals(true))
            //{
            //    gender = "Other";
            //}


            //Fhandler.InsertStudent(txtManStudentsName.Text, txtManStundentSurname.Text,  , txtManDateOfBirth.Text, gender, txtManPhones.Text, txtManAddress.Text);



        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
           // Image image = null;
           //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

           // // dh.image1();
           // using (OpenFileDialog odf = new OpenFileDialog() { Filter = "JPG|*.jpg", ValidateNames = true, Multiselect = false })
               
           // {
           //     if (odf.ShowDialog() == DialogResult.OK)
           //        filename = odf.FileName;
           //     MessageBox.Show("@" + "(" + filename + ")");

           //     pictureBox1.Image = Image.FromFile(filename);
           //     textBox2.Text = Path.GetFileName(filename);
           //     textBox1.Text = File.GetCreationTime(filename).ToString();
           // }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
