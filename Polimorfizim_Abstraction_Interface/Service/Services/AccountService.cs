using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        public void Register(string user, string pass)
        {
            Console.WriteLine("Registered");
        }
    }
}
