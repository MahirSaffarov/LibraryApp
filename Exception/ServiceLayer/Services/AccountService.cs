using Domain.Models;
using ServiceLayer.Services.Exceptions;
using ServiceLayer.Services.Helpers.Constants;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AccountService : IAccountService
    {
        public User GetUserById(int? id)
        {
            if (id is null) throw new BadRequestException(ExceptionMessage.BadRequest );

            var users = GetAllUsers();

            var result  = users.Find(m => m.Id == id);
                
            if(result == null)
            {
                throw new NotFoundExceptions(ExceptionMessage.NotFound);
            }
            return result;
        }
        private List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            users.Add(new User { Id = 1, Name = "Mahir", Email = "mahirsaffarov@gmail.com", Password = "Mahir12345" });
            users.Add(new User { Id = 1, Name = "Mahir", Email = "mahirsaffarov@gmail.com", Password = "Mahir12345" });
            users.Add(new User { Id = 1, Name = "Mahir", Email = "mahirsaffarov@gmail.com", Password = "Mahir12345" });
            users.Add(new User { Id = 1, Name = "Mahir", Email = "mahirsaffarov@gmail.com", Password = "Mahir12345" });
            users.Add(new User { Id = 1, Name = "Mahir", Email = "mahirsaffarov@gmail.com", Password = "Mahir12345" });

            return users;
        }

        public bool Register(User user)
        {
            if (!user.Email.Contains("@"))
            {
                return false;
            }
            return true;
        }
    }
}
