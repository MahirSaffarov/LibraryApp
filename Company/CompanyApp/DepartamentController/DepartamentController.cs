
using DomainLayer.Entities;
using RepositoryLayer.Helpers;
using ServiceLayer.DepartamentService;

namespace CompanyApp.Controllers
{
    public class DepartamentController
    {
        private readonly DepartamentService _departamentService;

        public DepartamentController()
        {
            _departamentService = new DepartamentService();
        }

        public void Create()
        {

            try
            {
                ConsoleColor.DarkCyan.WriteConsole("Please enter departament name: ");

                string name = Console.ReadLine();

                ConsoleColor.DarkCyan.WriteConsole("Please enter departament capacity: ");

            CapacityCount: string capacityCountStr = Console.ReadLine();

                int capacityCount;

                bool isParseCapacitycount = int.TryParse(capacityCountStr, out capacityCount);

                if (isParseCapacitycount)
                {
                    Departament departament = new()
                    {
                        Name = name,
                        Capacity = capacityCount
                    };

                    var result = _departamentService.Create(departament);

                    ConsoleColor.Green.WriteConsole($"Id: {result.Id}, Name: {result.Name}, Capacity count: {result.Capacity}");

                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct capacity count:");
                    goto CapacityCount;
                }
            }
            catch (Exception ex)
            {

                ConsoleColor.Red.WriteConsole(ex.Message);
            }

        }
        //public void Update() 
        //{
        //    try
        //    {
        //        ConsoleColor.DarkMagenta.WriteConsole("Add departament id:");

        //    Id: string idStr = Console.ReadLine();

        //        int id;

        //        bool isParseId = int.TryParse(idStr, out id);

        //        if (isParseId)
        //        {
        //            var result = _departamentService.GetById(id);

        //            if (result is null)
        //            {
        //                ConsoleColor.Red.WriteConsole("Departament not found, please try again:");
        //                goto Id;
        //            }
        //            ConsoleColor.DarkCyan.WriteConsole("Please enter new departament name: ");

        //            string name = Console.ReadLine();

        //            ConsoleColor.DarkCyan.WriteConsole("Please enter new departament capacity: ");

        //        CapacityCount: string capacityCountStr = Console.ReadLine();

        //            int capacityCount;

        //            bool isParseCapacitycount = int.TryParse(capacityCountStr, out capacityCount);

        //            result.Name = name;
        //            result.Capacity = capacityCount;

        //            if (isParseCapacitycount)
        //            {
        //                //Departament departament = new()
        //                //{
                           
        //                //};

        //                //_departamentService.Update(id,departament);

        //                ConsoleColor.Green.WriteConsole("Succesfully updated");
        //            }
        //            else
        //            {
        //                ConsoleColor.Red.WriteConsole("Please add correct capacity count:");
        //                goto CapacityCount;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        ConsoleColor.Red.WriteConsole(ex.Message);
        //    }
        //}
        public void Delete()
        {
            ConsoleColor.DarkMagenta.WriteConsole("Add departament id:");

        Id: string idStr = Console.ReadLine();

            try
            {
                int id;

                bool isParseId = int.TryParse(idStr, out id);

                if (isParseId)
                {
                    _departamentService.Delete(id);

                    ConsoleColor.Green.WriteConsole($"Successfully deleted");
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct id:");
                    goto Id;
                }
            }
            catch (Exception ex)
            {
                ConsoleColor.Red.WriteConsole(ex.Message);
                goto Id;
            }
        }
        public void GetById()
        {
            try
            {
                ConsoleColor.DarkMagenta.WriteConsole("Add departament id:");

            Id: string idStr = Console.ReadLine();

                int id;

                bool isParseId = int.TryParse(idStr, out id);

                if (isParseId)
                {
                    var result = _departamentService.GetById(id);
                    if (result is null)
                    {
                        ConsoleColor.Red.WriteConsole("Departament not found, please try again:");
                        goto Id;
                    }

                    ConsoleColor.Green.WriteConsole($"Id: {result.Id}, Name: {result.Name}, Capacity count: {result.Capacity}");
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct id:");
                    goto Id;
                }
            }
            catch (Exception ex)
            {

                ConsoleColor.Red.WriteConsole(ex.Message);
            }
        }
        public void GetAll() 
        {
            var result = _departamentService.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " " + item.Capacity + " " + item.Id);
            }
        }
        public void Search()
        {
            ConsoleColor.DarkMagenta.WriteConsole("Add departament name");

            string searchText = Console.ReadLine();

            var result = _departamentService.Search(searchText);

            foreach (var item in result)
            {
                ConsoleColor.Green.WriteConsole($"Id: {item.Id}, Name: {item.Name}, Capacity count: {item.Capacity}");
            }
        }
    }
}
