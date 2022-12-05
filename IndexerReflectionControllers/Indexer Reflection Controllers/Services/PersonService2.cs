using Indexer_Reflection_Controllers.Models;
using Indexer_Reflection_Controllers.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Controllers.Services
{
    public class PersonService2 : IPersonService2
    {
        public double BeginCNameSquareCount(Predicate<Person2> predicate)
        {
            var list = AddName();

            var result = list.FindAll(predicate).Count;

            return Math.Pow(result, 2);

        }
        private List<Person2> AddName()
        {
            List<Person2> list = new List<Person2>();
            list.Add(new Person2 { Name = "Mahir" });
            list.Add(new Person2 { Name = "Camal" });
            list.Add(new Person2 { Name = "Cavid" });
            list.Add(new Person2 { Name = "Samir" });
            list.Add(new Person2 { Name = "Ceyhun" });

            return list;
        }
    }
}
