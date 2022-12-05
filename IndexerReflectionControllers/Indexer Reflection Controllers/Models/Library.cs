using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Controllers.Models
{
    public class Library
    {
        public List<string> LibraryNames()
        {
            List<Library> list = new();
            Book2 book = new()
            {
                Name = "Xosrov",
                Author = "Nizami"
            };
            Book2 book2 = new()
            {
                Name = "Ferhad",
                Author = "Fuzuli"
            };
            Book2 book3 = new()
            {
                Name = "Sevil",
                Author = "Cavid"
            };
            Book2 book4 = new()
            {
                Name = "Koroglu",
                Author = "Qorqud"
            };

            

        }
    }
}
