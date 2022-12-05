using Indexer_Reflection_Controllers.Models;
using Indexer_Reflection_Controllers.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Controllers.Services
{
    public class PersonService : IPersonService
    {
        public List<string> GetData(Predicate<Person> predicate)
        {
            var list = AddDatas();

            var result = list.FindAll(predicate);

            List<string> fullData = new(); 

            foreach(var item in result) 
            {
                string datas = $"{item.Name} - {item.Surname} - {item.Adress}";
                fullData.Add(datas);
            }
            return fullData;
        }
        private List<Person> AddDatas() 
        {
            List<Person> list = new List<Person>();
            list.Add(new Person { Name = "Mahir", Surname = "Safarov", Adress = "Nesimi rayonu", Salary = 1200 });
            list.Add(new Person { Name = "Mahir", Surname = "Safarov", Adress = "Nesimi rayonu", Salary = 1200 });
            list.Add(new Person { Name = "Mahir", Surname = "Safarov", Adress = "Nesimi rayonu", Salary = 200 });
            list.Add(new Person { Name = "Mahir", Surname = "Safarov", Adress = "Nesimi rayonu", Salary = 1200 });
            list.Add(new Person { Name = "Mahir", Surname = "Safarov", Adress = "Nesimi rayonu", Salary = 100 });

            return list;
        }
    }
}
