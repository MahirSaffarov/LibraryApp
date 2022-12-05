using Service.Enums;
using Service.Helpers.Constant;
using Service.Services.Interfaces;
using System;

namespace Service
{
    public class AccountService : IAccountService
    {
        public string Login(string gmail, string password, int role)
        {
            if(gmail == AccountConstant.Gmail && password == AccountConstant.PassWord)
            {
                if (CheckRole(role))
                {
                    return "Enter is success";
                }
                else
                {
                    return "You have not permission to enter";
                }
            }

            return "Gmail oor password is wrong";
        }
        public bool CheckRole(int role)
        {
            //switch (role)
            //{
            //    case (int)Roles.SuperAdmin:
            //        return true;
            //    default:
            //        return false;
            //}

            if (role == (int)Roles.SuperAdmin)
                return true;
            return false;
        }
    }
}
