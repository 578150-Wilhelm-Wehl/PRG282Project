using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.Logic
{
    class Exeptions : Exception
    {
    }

    class EXFailedLogin : Exception
    {
        public EXFailedLogin() : base("User login failed \n Please ensure logindetails are correct or create an account")
        {
        }
    }

    class EXFailedUserCreation : Exception
    {
        public EXFailedUserCreation() : base("User could not be created")
        {
        }
    }

    class EXDatabaseLoginFailed : Exception
    {
        public EXDatabaseLoginFailed() : base("User could not be created")
        {
        }
    }

    class EXStudentNotFound : Exception
    {
        public EXStudentNotFound() : base("User could not be created")
        {
        }
    }

    class EXModuleNotFound : Exception
    {
        public EXModuleNotFound() : base("User could not be created")
        {
        }
    }

    class EXPasswordResetFailed : Exception
    {
        public EXPasswordResetFailed() : base("User could not be created")
        {
        }
    }

}
