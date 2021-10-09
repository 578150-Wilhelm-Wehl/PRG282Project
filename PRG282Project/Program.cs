using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282Project.Presentation;
using System.IO;
using System.Threading;
using System.Data;
using System.Data.SqlClient;


namespace PRG282Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string UserFilePath = @Directory.GetCurrentDirectory() + "/ActiveUsers.txt";
            if (!File.Exists(UserFilePath))
            {
                var fs = File.CreateText(UserFilePath);
                fs.Close();
                StreamWriter sw = new StreamWriter(UserFilePath);
                sw.WriteLine("Admin-Admin-N/A-N/A");
                sw.Close();
            }

            string connect = "Server=localhost;Integrated security=SSPI;database=master";
            String Database ;
            SqlConnection sqlconnect = new SqlConnection(connect);

            Database = "CREATE DATABASE DBstudents ON PRIMARY " +
                       "(NAME = MyDatabase_Data, " +
                       "FILENAME = 'C:\\DBstudentsData.mdf', " +
                       "SIZE = 20MB, MAXSIZE = 25MB, FILEGROWTH = 10%)" +
                       "LOG ON (NAME = DBStudents_Log, " +
                       "FILENAME = 'C:\\DBStudents.ldf', " +
                       "SIZE = 5MB, " +
                       "MAXSIZE = 10MB, " +
                       "FILEGROWTH = 10%)";

            SqlCommand myCommand = new SqlCommand(Database, sqlconnect);
            try
            {
                sqlconnect.Open();
                myCommand.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                // create custom exeption
                MessageBox.Show("Problem occured while creating database");
            }
            
            
            { 

                try
                { 
                    using (SqlCommand sc = new SqlCommand(" USE DBstudents CREATE TABLE Student(StudentNumber INT,StudentName NVARCHAR(50),StudentSurname NVARCHAR(50),DateOfBirth Date,Phone NVARCHAR(10),Address NVARCHAR(255),Gender NVARCHAR(10),StudentImage VARBINARY(50));", sqlconnect))
                    sc.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    // create custom exeption
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlconnect.Close();
                }
            }





            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
