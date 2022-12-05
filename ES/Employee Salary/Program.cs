using Employee_Salary.Models;
using System;

namespace Employee_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
        }


    }
    public class EmpList<T>
    {
        private Employee[] _arr;
        public EmpList()
        {
            _arr = new Employee[0];
        }
        public void Add(Employee emp)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = emp;
        }
        public void GetAll()
        {
            foreach (Employee item in _arr)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Surname);
                Console.WriteLine(item.Salary);
                Console.WriteLine(item.Brithday);
            }
        }
    }
}
