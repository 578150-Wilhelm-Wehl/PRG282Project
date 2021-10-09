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

    class FailedLoginEX : Exception
    {
        public FailedLoginEX() : base("")
        {
        }
    }

    class FailedUserCreationEX : Exception
    {
        public FailedUserCreationEX() : base("")
        {
        }
    }
}
