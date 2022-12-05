using Demons.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class EmployeeService : IEmployeeService
    {
        public int GetFilteredEmployeesCount(DateTime start, DateTime end, double salary)
        {
            Employee[] employees = GetEmployees();
            int empCount = 0;
            foreach(Employee item in employees)
            {
                if((item.Birthday > start && item.Birthday < end)&& item.Salary > salary)
                {
                    empCount++;
                }
            }
            return empCount;

        }
        private Employee[] GetEmployees()
        {
            Employee emp1 = new Employee(DateTime.Now.AddDays(10));
            emp1.Salary = 2500;
            Employee emp2 = new Employee(DateTime.Now.AddDays(20));
            emp2.Salary = 2000;
            Employee emp3 = new Employee(DateTime.Now.AddDays(30));
            emp3.Salary = 3000;
            Employee emp4 = new Employee(DateTime.Now.AddDays(-20));
            emp4.Salary = 4000;

            Employee[] employees = { emp1, emp2, emp3, emp4 };

            return employees;
        }
    }
}
