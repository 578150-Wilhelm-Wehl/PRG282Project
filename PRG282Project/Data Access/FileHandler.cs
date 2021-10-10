using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PRG282Project.Data_Access;
using System.Drawing.Imaging;
using System.Drawing;

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

        public void InsertStudent(string StudentName,string StudentSurname, Image StudentImage, string DateofBirth , string Gender,string phonenumber, string address)       {
            SqlConnection cn = new SqlConnection(connect);
            cn.Open();

            string query = @"INSERT INTO tblStudents( StundentName, StudentSurname, StudentImage, DateOfBirth, Gender, PhoneNumber, StudentAddress)VALUES ('" + StudentName + "','" +StudentSurname + "','" + StudentImage + "','" + DateofBirth +"','" +Gender+ "','" + phonenumber + "','" + address + "')";
            SqlCommand cmd = new SqlCommand(query, cn);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    

        public void UpdateModules()
        {

        }

        public void UpdateStudent()
        {

        }
        public void DeleteModules(string ModuleCode)
        {
            string DeleteBridgeModulequery = @"DELETE FROM tblBridge INNER JOIN tblModule ON tblBridge.ModuleID = tblModule.ModuleID WHERE tblModule.ModuleID = '" + ModuleCode + "'";
            string DeleteModulesquery = @"DELETE FROM tblModule WHERE ModuleCode = '" + ModuleCode + "'";
            SqlConnection sqlconnect = new SqlConnection(connect);
            SqlCommand SQLBridgeCommand = new SqlCommand(DeleteBridgeModulequery, sqlconnect);
            SqlCommand SQLModuleCommand = new SqlCommand(DeleteModulesquery, sqlconnect);
            try
            {
                sqlconnect.Open();
                SQLBridgeCommand.ExecuteNonQuery();
                SQLModuleCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconnect.Close();
            }
        }

        public void DeleteStudent()
        {

        }

        public DataTable getStudents()
        {
            string AllStudentsquery = @"SELECT * FROM tblStudent";
            SqlDataAdapter adapter = new SqlDataAdapter(AllStudentsquery, connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
          
            return dt;
            
        }
    }
}
