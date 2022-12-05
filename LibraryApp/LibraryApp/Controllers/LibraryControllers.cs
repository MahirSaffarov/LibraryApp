using DomainLayer.Entity;
using ServiceLayer.Helpers;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Controllers
{
    public class LibraryControllers
    {
        private readonly LibraryService _libraryService;
        public LibraryControllers()
        {
            _libraryService = new LibraryService();
        }
        public void Create()
        {
            try
            {
                ConsoleColor.Cyan.WriteConsole("Add library name: ");
                string name = Console.ReadLine();
                ConsoleColor.Cyan.WriteConsole("Add library seat count: ");
            SeatCount: string seatCountStr = Console.ReadLine();
                int seatCount;
                bool isParseSeatCount = int.TryParse(seatCountStr, out seatCount);

                if (isParseSeatCount)
                {
                    Library library = new()
                    {
                        Name = name,
                        SeatCount = seatCount
                    };
                    var result = _libraryService.Create(library);

                    ConsoleColor.DarkGreen.WriteConsole($"{result.Id} - {result.Name} - {result.SeatCount}");
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct seat count: ");
                    goto SeatCount;
                }
            }
            catch (Exception ex)
            {
                ConsoleColor.Red.WriteConsole(ex.Message);
            }
            

        }

        public void GetById()
        {
            try
            {
                ConsoleColor.Cyan.WriteConsole("Add library id: ");

                Id: string idStr = Console.ReadLine();

                int id;

                bool isParseId = int.TryParse(idStr, out id);

                if(isParseId)
                {
                    var result = _libraryService.GetById(id);
                    if(result is null) 
                    {
                        ConsoleColor.Red.WriteConsole("Not Found");
                        goto Id;
                    }
                    ConsoleColor.DarkGreen.WriteConsole($"Id: {result.Id}, Name: {result.Name}, SeatCount; {result.SeatCount}");

                }
                else
                {
                     ConsoleColor.Red.WriteConsole("Please add correct seat count: ");
                    goto Id;
                }
            }
            catch (Exception ex)
            {
                ConsoleColor.Red.WriteConsole(ex.Message);
            }
        }

        public void Delete()
        {
            try
            {
                ConsoleColor.Cyan.WriteConsole("Add library id: ");

                string idStr = Console.ReadLine();

                int id;

                bool isParseId = int.TryParse(idStr, out id);

                if (isParseId)
                {
                    _libraryService.Delete(id);
                
                    
                    ConsoleColor.DarkGreen.WriteConsole("Success");

                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct correct id : ");
                    
                }
            }
            catch (Exception ex)
            {
                ConsoleColor.Red.WriteConsole(ex.Message);
            }
        }
    }
}
