using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception.Controller
{
    public class LibraryController
    {
        public void GetAllBooks(int id)
        {
            ILibraryService service = new LibraryService();

            var result = service.GetLibraries(m => m.Id == id);

            foreach(var item in result)
            {
                 Console.WriteLine(item.Name + " " + item.Name);
            }
        }
    }
}
