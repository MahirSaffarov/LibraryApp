using Service.Models;
using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            Console.WriteLine("Please enter your id number.");
            int roleId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gmail: ");
            string Gmail = Console.ReadLine();
            Console.Write("Password: ");
            string Password = Console.ReadLine();
            
            account.CheckGmailAndPass(Gmail, Password,roleId);
        }
    }
}
