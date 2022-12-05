using Indexer_Reflection_Controllers.Services;
using Indexer_Reflection_Controllers.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Controllers.Controllers
{
    public class BookController
    {
        public static void CheckAuthor()
        {
            IBookService bookService = new BookService();

            var result = bookService.GetCount(m => m.Author == "Nizami");

            foreach(var item in result) 
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
