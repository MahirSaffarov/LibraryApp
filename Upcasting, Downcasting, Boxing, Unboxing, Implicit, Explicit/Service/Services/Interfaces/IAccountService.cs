using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interfaces
{
    public interface IAccountService
    {
        string Login(string gmail, string password, int role);
    }
}
