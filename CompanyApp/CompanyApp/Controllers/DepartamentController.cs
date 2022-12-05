using DomainLayer.Entities;
using RepositoryLayer.Helpers;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.Controllers
{
    public class DepartamentController
    {
        private readonly DepartamentService _departamentService;
        public DepartamentController()
        {
            _departamentService= new DepartamentService();
        }
        public void Create()
        {
            try
            {
                ConsoleColor.DarkYellow.WriteConsole("Please enter departament name: ");

                string name = Console.ReadLine();

                ConsoleColor.DarkYellow.WriteConsole("Please enter departament capacity: ");

                Capacity: string capacity = Console.ReadLine();

                int capacityCount;

                bool isParseCapacity = int.TryParse(capacity, out capacityCount);

                if (isParseCapacity)
                {
                    Departament departament = new()
                    {
                        Name = name,
                        Capacity = capacityCount
                    };
                    var result = _departamentService.Create(departament);
                    ConsoleColor.DarkGreen.WriteConsole($"Id: {result.Id}, Name: {result.Name}, Capacity count: {result.Capacity}");
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct capacity count:");
                    goto Capacity;
                }
            }
            catch (Exception ex)
            {
                ConsoleColor.Red.WriteConsole(ex.Message);
            }
        }
    }
}
