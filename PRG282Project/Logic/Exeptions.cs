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
        //
        public EXFailedLogin() : base("User login failed \n Please ensure login details are correct \n Otherwise please create an account")
        {
        }
    }

    class EXFailedUserCreation : Exception
    {
        //
        public EXFailedUserCreation() : base("User could not be created \n Please Make sure that there are no special characters in the username\n The password must contain atleast one number, one lower case and one uppercase character\n the pasword must be 6 to 12 characters long\nNote the pasword cannot contain \"-\" \"|\"")
        {
        }
    }

    class EXPasswordResetFailed : Exception
    {
        //
        public EXPasswordResetFailed() : base("Your Password could not be reset.\n This can be caused by an incorrect username or an invalid security answer")
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
    class EXStudentRegestrationFailed : Exception
    {
        //
        public EXStudentRegestrationFailed() : base("Please Ensure that all fields ar filled out correctly \n If this error continues please contact the development team")
        {
        }
    }
    class EXModuleUpdateFailed : Exception
    {
        //
        public EXModuleUpdateFailed() : base("Please ensure that all fields are filled in then click update again")
        {
        }
    }
    class EXUpdateStudentFailed : Exception
    {
        //
        public EXUpdateStudentFailed() : base("Please ensure that all fields are filled in then click update again")
        {
        }
    }
    class EXRegisterModuleFailed : Exception
    {
        //
        public EXRegisterModuleFailed() : base("Module Regestration failed \nPlease Ensure that all fields ar filled out correctly")
        {
        }
    }
}

