using Indexer_Reflection_Controllers.Models;
using Indexer_Reflection_Controllers.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Controllers.Services
{
    public class EmployeeService : IEmployeeService
    {
        public double ShowAverageSalary(Predicate<Employee> predicate)
        {
            var list = AddDatas();

            var result = list.FindAll(predicate);
            
            return AverageSalary(result);

        }
        public double AverageSalary(List<Employee> emp)
        {
            return emp.Average(m => m.Salary);
        }
        private List<Employee> AddDatas()
        {
            List<Employee> list = new();
            list.Add(new Employee {Age = 20, Salary = 900});
            list.Add(new Employee { Age = 25, Salary = 2600 });
            list.Add(new Employee { Age = 27, Salary = 6300 });
            list.Add(new Employee { Age = 45, Salary = 300 });

            return list;
        }
    }
}
