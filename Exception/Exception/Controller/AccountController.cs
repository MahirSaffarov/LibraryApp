using Domain.Models;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exception.Controller
{
    public class AccountController
    {
		public void GetUserById()
		{
			try
			{
				IAccountService account = new AccountService();
				var result = account.GetUserById(3);
				Console.WriteLine(result.Name);
			}
			catch(System.Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
       public void Register()
       {
			try
			{
				Console.WriteLine("Add Username: ");
				string username = Console.ReadLine();

				Console.WriteLine("Email: ");
				string email = Console.ReadLine();

				Console.WriteLine("Password: ");
				string password = Console.ReadLine();

				IAccountService service = new AccountService();

				User newUser = new User()
				{
					Name = username,
					Email = email,
					Password = password
				};

				var result = service.Register(newUser);

				if (!result) throw new System.Exception("Email doesnt hvae symbol @");

				Console.WriteLine("Success");
			}
			catch (System.Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
       }
    }
}
