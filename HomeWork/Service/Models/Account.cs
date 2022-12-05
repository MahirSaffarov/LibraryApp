using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Models
{
    public class Account : IAccount
    {
        public void CheckGmailAndPass(string gmail, string password, int roleId)
        {
            if (roleId == (int)Roles.SuperAdmin && gmail == "test@code.edu.az" && password == "test12345")
            {
                Console.WriteLine("Login is successful");
            }
            else if(roleId == (int)Roles.Admin || roleId == (int)Roles.Member)
            {
                Console.WriteLine("You do not have permission to log in");
            }
            else if (gmail != "test@code.edu.az" || password != "test12345")
            {
                Console.WriteLine("Gmail or password is wrong");
            }
            else
            {
                Console.WriteLine("This role is not found.");
            }
        }
    }
}
