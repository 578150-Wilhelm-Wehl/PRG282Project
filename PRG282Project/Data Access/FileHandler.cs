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

        public DataTable GetResources(string ModuleID)
        {
            string GetResourcesQuery = "SELECT * FROM tblResources WHERE ModuleID = " + ModuleID;
            SqlDataAdapter sqlData = new SqlDataAdapter(GetResourcesQuery, connect);
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

        public DataTable SearchStudents(string StudentNumber)
        {
            try
            {
                if (!String.IsNullOrEmpty(StudentNumber))
                {
                    string GetStudentsQuery = "SELECT * FROM tblStudents WHERE StudentNumber = " + StudentNumber;
                    SqlDataAdapter sqlData = new SqlDataAdapter(GetStudentsQuery, connect);
                    DataTable DataTableStudents = new DataTable();
                    sqlData.Fill(DataTableStudents);
                    return DataTableStudents;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public DataTable SearchStudentModules(string StudentNumber)
        {
            try
            {
                string GetStudentModulesQuery = "SELECT ts.StudentNumber, tm.ModuleCode, tm.ModuleName, tm.ModuleDescription " +
                "FROM tblStudents ts " +
                "JOIN tblBridge tb " +
                "ON ts.StudentNumber = tb.StudentNumber " +
                "JOIN tblModule tm " +
                "ON tb.ModuleID = tm.ModuleID " +
                "WHERE ts.StudentNumber = " + StudentNumber;


                DataTable DataTableStudentModules = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter(GetStudentModulesQuery, connect);
                sqlData.Fill(DataTableStudentModules);
                if (DataTableStudentModules.Rows.Count >0)
                {
                    return DataTableStudentModules;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
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
                int rowsaffected = sqlCommand.ExecuteNonQuery();
                if (rowsaffected > 0)
                {
                    // add exeption MessageBox.Show("Module has been added");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                // add exeption MessageBox.Show("Module has Not been added");
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public void InsertStudent(string StudentName, string StudentSurname, string StudentImage, string DateofBirth, string Gender, string phonenumber, string address)
        {
            SqlConnection cn = new SqlConnection(connect);
            cn.Open();


            string query = @"INSERT INTO tblStudents( StundentName, StudentSurname, StudentImage, DateOfBirth, Gender, PhoneNumber, StudentAddress)VALUES ('" + StudentName + "','" + StudentSurname + "',(SELECT * FROM OPENROWSET(BULK N'" + StudentImage + "', SINGLE_BLOB)as varbinary),'" + DateofBirth + "','" + Gender + "','" + phonenumber + "','" + address + "')";
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
        public void UpdateModules(string ModuleCode, string ModuleName, string ModuleDescription, int ModuleID)
        {
            string updatequery = "UPDATE tblModule SET ModuleCode = '" + ModuleCode + "' ,ModuleName = '" + ModuleName + "'  , ModuleDescription= '" + ModuleDescription + "' WHERE ModuleID = " + ModuleID;
            SqlConnection cn = new SqlConnection(connect);
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(updatequery, cn);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Module updated successfully");
                }
                else
                {
                    MessageBox.Show("Failed to Module student information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void UpdateStudent(string Name, string Surname, DateTime DateOfBirth, string gender, string phonenumber, string address, int studentnumber)
        {

            string updatequery = "UPDATE tblStudents SET StundentName = '" + Name + "' ,StudentSurname = '" + Surname + "'  , DateOfBirth= '" + DateOfBirth + "' ,Gender= '" + gender + "',PhoneNumber='" + phonenumber + "',StudentAddress= '" + address + "' WHERE StudentNumber = '" + studentnumber + "'";
            SqlConnection cn = new SqlConnection(connect);
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(updatequery, cn);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Student updated successfully");
                }
                else
                {
                    MessageBox.Show("Failed to update student information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void DeleteModules(string ModuleID)
        {
            string DeleteBridgequery = "DELETE FROM tblBridge WHERE ModuleID = " + ModuleID;
            string DeleteModulesquery = "DELETE FROM tblModule WHERE ModuleID = " + ModuleID;
            string DeleteResourcequery = "DELETE FROM tblResources WHERE ModuleID = " + ModuleID;
            SqlConnection sqlconnect = new SqlConnection(connect);
            SqlCommand SQLBridgeCommand = new SqlCommand(DeleteBridgequery, sqlconnect);
            SqlCommand SQResourceCommand = new SqlCommand(DeleteResourcequery, sqlconnect);
            SqlCommand SQLModuleCommand = new SqlCommand(DeleteModulesquery, sqlconnect);
            try
            {
                sqlconnect.Open();
                SQLBridgeCommand.ExecuteNonQuery();
                SQResourceCommand.ExecuteNonQuery();
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

        public void DeleteStudent(string studentnumber)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            sqlConnection.Open();
            try
            {
                string DeleteBridgeQuey = @"DELETE  FROM tblBridge WHERE StudentNumber= '" + studentnumber + "'";
                string DeleteStudentQuery = @"DELETE  FROM tblStudents WHERE StudentNumber= '" + studentnumber + "'";
                SqlCommand DeleteBridgeComand = new SqlCommand(DeleteBridgeQuey, sqlConnection);
                SqlCommand DeleteStudentComand = new SqlCommand(DeleteStudentQuery, sqlConnection);

                int tb1rows = DeleteBridgeComand.ExecuteNonQuery();
                int tb2rows = DeleteStudentComand.ExecuteNonQuery();

                if (tb2rows > 0)
                {
                    MessageBox.Show("Student Deleted");
                }
                else
                {
                    MessageBox.Show("Student deletion failed");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        public DataTable getStudents()
        {
            string AllStudentsquery = @"SELECT * FROM tblStudent";
            SqlDataAdapter adapter = new SqlDataAdapter(AllStudentsquery, connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public void InsertBridge(string StudentNumber, string ModuleID)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            sqlConnection.Open();
            try
            {
                string InsertBridgeQuery = "INSERT INTO tblBridge (StudentNumber,ModuleID) VALUES (" + StudentNumber + "," + ModuleID + ")";
                SqlCommand sqlCommand = new SqlCommand(InsertBridgeQuery, sqlConnection);
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

        public DataTable FetchStudent(string StudentName, string StudentSurname, string DateofBirth, string phonenumber, string address)
        {
            string FetchStudentQuery = "SELECT StudentNumber FROM tblStudents WHERE StundentName = '" + StudentName + "' AND StudentSurname = '" + StudentSurname + "' AND DateOfBirth = '" + DateofBirth + "' AND PhoneNumber = '" + phonenumber + "' AND StudentAddress = '" + address + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(FetchStudentQuery, connect);
            DataTable FetchStudentDatatable = new DataTable();
            adapter.Fill(FetchStudentDatatable);
            return FetchStudentDatatable;
        }
        public DataTable FetchModuleID(string ModuleCode)
        {
            string FetchModuleIDQuery = "SELECT ModuleID FROM tblModule WHERE ModuleCode = '" + ModuleCode + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(FetchModuleIDQuery, connect);
            DataTable FetchModuleIDDatatable = new DataTable();
            adapter.Fill(FetchModuleIDDatatable);
            return FetchModuleIDDatatable;
        }
        public void InsertResource(string ModuleID, string ResourceLink)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            sqlConnection.Open();
            try
            {
                string InsertResourceQuery = "INSERT INTO tblResources (ModuleID, ResouceLink) VALUES (" + ModuleID + ", '" + ResourceLink + "')";
                SqlCommand sqlCommand = new SqlCommand(InsertResourceQuery, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed");
                // add exception MessageBox.Show("Resource has Not been added");
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        public DataTable SearchModules(string Modulecode)
        {
            try
            {
                if (!String.IsNullOrEmpty(Modulecode))
                {
                    string GetModulesQuery = "SELECT * FROM tblModule WHERE ModuleCode = '" + Modulecode + "'";
                    SqlDataAdapter sqlData = new SqlDataAdapter(GetModulesQuery, connect);
                    DataTable DataTableStudents = new DataTable();
                    sqlData.Fill(DataTableStudents);
                    return DataTableStudents;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }


        }
    
        public DataTable ViewModules()
        {
            string ViewModulesQuery = "SELECT * FROM tblModule";
            SqlDataAdapter sqlData = new SqlDataAdapter(ViewModulesQuery, connect);
            DataTable DataTableStudents = new DataTable();
            sqlData.Fill(DataTableStudents);
            return DataTableStudents;
        }
    }
}

