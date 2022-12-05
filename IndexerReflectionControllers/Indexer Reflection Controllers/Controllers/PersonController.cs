using Indexer_Reflection_Controllers.Models;
using Indexer_Reflection_Controllers.Services;
using Indexer_Reflection_Controllers.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Controllers.Controllers
{
    public class PersonController
    {
        public static void CheckSalary()
        {
            IPersonService personService = new PersonService();

            var result = personService.GetData(m => m.Salary > 1000);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
