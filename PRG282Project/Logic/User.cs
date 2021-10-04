using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.Logic
{
    class User
    {
        List<User> users = new List<User>();
        //fields
        private string username, password, securtyQuestion, securityAnswer;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string SecurtyQuestion { get => securtyQuestion; set => securtyQuestion = value; }
        public string SecurityAnswer { get => securityAnswer; set => securityAnswer = value; }

        public User(string username, string password, string securtyQuestion, string securityAnswer)
        {
            this.username = username;
            this.password = password;
            this.securtyQuestion = securtyQuestion;
            this.securityAnswer = securityAnswer;
        }

        public User()
        {

        }
    }

}
