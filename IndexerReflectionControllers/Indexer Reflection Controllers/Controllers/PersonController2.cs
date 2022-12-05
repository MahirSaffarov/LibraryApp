using Indexer_Reflection_Controllers.Services;
using Indexer_Reflection_Controllers.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Controllers.Controllers
{
    public class PersonController2
    {
        public static void CheckFirstAlpha()
        {
            IPersonService2 personService2 = new PersonService2();

            string word = "c";

            Console.WriteLine(personService2.BeginCNameSquareCount(m=>m.Name.ToLower().StartsWith(word)));
        }
    }
}
