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
                if (username.Length > 2 && regexNewUserName.IsMatch(username) && regexNewUserPassword.IsMatch(password) && !string.IsNullOrEmpty(secQuestion) && !string.IsNullOrEmpty(secAnswer))
                {
                    newuser += username+'-'+password+'-'+secQuestion+'-'+secAnswer;
                    MessageBox.Show("Your user has been created successfully");
                }
                else
                {
                    throw new EXFailedUserCreation();
                }
                sw.WriteLine(newuser);
                sw.Close();
            }
            catch (EXFailedUserCreation fuc)
            {
                MessageBox.Show(fuc.Message);
            }
            finally
            {
                sw.Close();
            }
        }

        public bool VeryfyUser(string username, string password, Label wrongCredentials)
        {
            try
            {
                string userPath = Directory.GetCurrentDirectory() + "/ActiveUsers.txt";
                string[] activeuserlist = File.ReadAllLines(userPath);
                bool accessgrant = false;

                for (int i = 0; i < activeuserlist.Length; i++)
                {
                    string[] splitusers = activeuserlist[i].Split('-');

                    if (splitusers[0] == username && splitusers[1] == password)
                    {
                        accessgrant = true;
                        break;
                    }
                }
                return accessgrant;
            }
            catch (EXFailedLogin fl)
            {
                MessageBox.Show(fl.Message);
                return false;
            }
        }

        public void LoginPanelManger(Panel panel1, Panel panel2, Panel panel3)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
        }

        public void PasswordReset(string Username, string SecAnswer, string newPassword)
        {
            try
            {
                var regexNewUserName = new Regex("^[a-zA-Z0-9 ]*$");
                var regexNewUserPassword = new Regex("(?=.*[a-z])(?=.*[A-Z])([^|-]+){6,12}");
                string userPath = Directory.GetCurrentDirectory() + "/ActiveUsers.txt";
                string[] activeuserlist = File.ReadAllLines(userPath);
                string replace = string.Empty;
                string newdetails = string.Empty;
                bool resetgrant = false;
                for (int i = 0; i < activeuserlist.Length; i++)
                {
                    string[] splitusers = activeuserlist[i].Split('-');
                    if (splitusers[0] == Username && splitusers[3] == SecAnswer && regexNewUserName.IsMatch(Username) && regexNewUserPassword.IsMatch(newPassword))
                    {
                        replace = splitusers[0] + '-' + splitusers[1] + '-' + splitusers[2] + '-' + splitusers[3];
                        newdetails = splitusers[0] + '-' + newPassword + '-' + splitusers[2] + '-' + splitusers[3];
                        resetgrant = true;
                        break;
                    }
                }
                if (resetgrant == true)
                {
                    string text = File.ReadAllText(userPath);
                    text = text.Replace(replace, newdetails);
                    File.WriteAllText(userPath, text);
                    MessageBox.Show("Your password has been reset");
                }
                else
                {
                    throw new EXPasswordResetFailed();
                }
            }
            catch (Exception prf)
            {
                MessageBox.Show(prf.Message);
            }
        }

        public void SecurityQuestion(string username, Label Question)
        {
            string userPath = Directory.GetCurrentDirectory() + "/ActiveUsers.txt";
            string[] activeuserlist = File.ReadAllLines(userPath);
            for (int i = 0; i < activeuserlist.Length; i++)
            {
                string[] splitusers = activeuserlist[i].Split('-');

                if (splitusers[0] == username)
                {
                    Question.Text = splitusers[2];
                    break;
                }
                else
                {
                    Question.Text = "user not found";
                }
            }
        }

        public void MainPanelManger(Panel panel1, Panel panel2, Panel panel3, Panel panel4, Panel panel5, Panel panel6)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel1.Visible = true;
        }
    }
}
