using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.Data_Access
{
    class FileHandler
    {
        string connect = "Server=.;Initial Catalog=DBstudents;Integrated security=SSPI";
        public FileHandler()
        {

        }

        public void GetModules()
        {

        }

        public void GetStudents()
        {

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
