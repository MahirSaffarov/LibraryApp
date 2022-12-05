using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    interface IAccount
    {
        void CheckGmailAndPass(string gmail, string password, int roleId);
    }
}
