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
            string ViewAllClientsQuery = "SELECT * FROM tblModule";
            SqlDataAdapter sqlData = new SqlDataAdapter(ViewAllClientsQuery, connect);
            DataTable DataTableModules = new DataTable();
            sqlData.Fill(DataTableModules);
            return DataTableModules;
        }

        public DataTable GetStudents()
        {
            string ViewAllClientsQuery = "SELECT * FROM tblStudents";
            SqlDataAdapter sqlData = new SqlDataAdapter(ViewAllClientsQuery, connect);
            DataTable DataTableStudents = new DataTable();
            sqlData.Fill(DataTableStudents);
            return DataTableStudents;
        }

        public void GetStudentModules()
        {
            //SELECT* FROM tblStudents
            //JOIN tblBridge
            //ON tblStudents.StudentNumber = tblBridge.StudentNumber
            //JOIN tblModule
            //ON tblBridge.ModuleID = tblModule.ModuleID
            //WHERE tblStudents.StudentNumber = 10002;
        }

        public void InsertModules()
        {

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
