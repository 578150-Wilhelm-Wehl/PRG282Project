using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using PRG282Project.Presentation;

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
                if (username.Length > 2 && regexNewUserName.IsMatch(username) && regexNewUserPassword.IsMatch(password)&& !string.IsNullOrEmpty(secQuestion) && !string.IsNullOrEmpty(secAnswer))
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
            catch (Exception)
            {
                //create custom exeption
                //add a finally
                MessageBox.Show("Please ensure username and password meet requirements \n Username\n\tno special characters\nPassword\n\t Exclude - | \n\tAtleast one number\n\tAtleast one capital letter");
                sw.Close();
            }
        }
        public void VeryfyUser(string username, string password, Label wrongCredentials)
        {
            Login login = new Login();
            Main main = new Main();
            string userPath = Directory.GetCurrentDirectory() + "/ActiveUsers.txt";
            string[] activeuserlist = File.ReadAllLines(userPath);
            bool accessgrant = false;
            for (int i = 0; i < activeuserlist.Length; i++)
            {
                string[] splitusers = activeuserlist[i].Split('-');

                if (splitusers[0] == username && splitusers[1]==password)
                {
                    accessgrant = true;
                    break;
                }
            }
            if (accessgrant == true)
            {
                login.Hide();
                main.Show();
            }
            else
            { 
                MessageBox.Show("Please ensure that username and password is correct");
                wrongCredentials.Visible = true;
            }
        }
        public void LoginPanelManger(Panel panel1, Panel panel2, Panel panel3)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
        }

        public void PasswordReset(string Username, string SecQusetion, string SecAnswer)
        {

        }
    }
}
