using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRG282Project.Data_Access
{
    class FileHandler
    {
        string connect = "Server=.;Initial Catalog=DBstudents;Integrated security=SSPI";
        public FileHandler()
        {

        }

        public DataTable GetModules()
        {
            string GetModulesQuery = "SELECT * FROM tblModule";
            SqlDataAdapter sqlData = new SqlDataAdapter(GetModulesQuery, connect);
            DataTable DataTableModules = new DataTable();
            sqlData.Fill(DataTableModules);
            return DataTableModules;
        }

        public DataTable GetStudents()
        {
            string GetStudentsQuery = "SELECT * FROM tblStudents";
            SqlDataAdapter sqlData = new SqlDataAdapter(GetStudentsQuery, connect);
            DataTable DataTableStudents = new DataTable();
            sqlData.Fill(DataTableStudents);
            return DataTableStudents;
        }

        public DataTable GetStudentModules()
        {
            string GetStudentModulesQuery = "SELECT tblStudents.StudentImage, tblStudents.StudentNumber, tblStudents.StundentName, tblStudents.StudentSurname,tblStudents.DateOfBirth,tblStudents.PhoneNumber,tblStudents.StudentAddress,tblModule.ModuleCode,tblModule.ModuleName FROM tblStudents" +
            "JOIN tblBridge" +
            "ON tblStudents.StudentNumber = tblBridge.StudentNumber" +
            "JOIN tblModule" +
            "ON tblBridge.ModuleID = tblModule.ModuleID" +
            "WHERE tblStudents.StudentNumber = 10002";
            SqlDataAdapter sqlData = new SqlDataAdapter(GetStudentModulesQuery, connect);
            DataTable DataTableStudentModules = new DataTable();
            sqlData.Fill(DataTableStudentModules);
            return DataTableStudentModules;
        }

        public void InsertModules(string ModuleCode, string ModuleName, string ModuleDescription)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            sqlConnection.Open();
            try
            {
                string InsertModules = "INSERT INTO tblModule (ModuleCode, ModuleName, ModuleDescription)" +
                                        "VALUES('" + ModuleCode + "', '" + ModuleName + "', '" + ModuleDescription + "')";
                SqlCommand sqlCommand = new SqlCommand(InsertModules, sqlConnection);
                int rowsafected = sqlCommand.ExecuteNonQuery();
                if (rowsafected > 0)
                {
                   // add exeption MessageBox.Show("Client has been added");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                // add exeption MessageBox.Show("Client has Not been added");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void InsertStudent()
        {

        }

        public void UpdateModules()
        {

        }

        public void UpdateStudent()
        {

        }
        public void DeleteModules()
        {

        }

        public void DeleteStudent()
        {

        }
    }
}
