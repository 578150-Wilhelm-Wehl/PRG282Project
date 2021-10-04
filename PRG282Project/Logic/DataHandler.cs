using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace PRG282Project.Logic
{
    class DataHandler
    {
        public void AddUser(string username, string password, string secQuestion, string secAnswer)
        {
            string userPath = Directory.GetCurrentDirectory() + "/ActiveUsers.txt";
            string newuser = string.Empty;
            StreamWriter sw = new StreamWriter(userPath, true);
            var regexNewUserName = new Regex("^[a-zA-Z0-9 ]*$");
            var regexNewUserPassword = new Regex("(?=.*[a-z])(?=.*[A-Z])([^|-]+){6,12}");
            try
            {
                if (username.Length < 2 && regexNewUserName.IsMatch(username) && regexNewUserPassword.IsMatch(password)&& !string.IsNullOrEmpty(secQuestion) && !string.IsNullOrEmpty(secAnswer))
                {
                    newuser += username+'-'+password+'-'+secQuestion+'-'+secAnswer;
                }
                else
                {
                    throw new Exception();
                }
                sw.WriteLine(newuser);
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Please ensure username and password meet requirements \n Username\n\tno special characters\nPassword\n\t Exclude - | \n\tAtleast one number\n\tAtleast one capital letter");
                sw.Close();
            }
        }    
    }
}
