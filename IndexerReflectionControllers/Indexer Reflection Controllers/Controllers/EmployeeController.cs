using Indexer_Reflection_Controllers.Services;
using Indexer_Reflection_Controllers.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Controllers.Controllers
{
    public class EmployeeController
    {
        public static void CheckAge()
        {
            IEmployeeService employeeService = new EmployeeService();

            Console.WriteLine(employeeService.ShowAverageSalary(m => m.Age > 20 && m.Age < 40)); 

        }
    }
}
