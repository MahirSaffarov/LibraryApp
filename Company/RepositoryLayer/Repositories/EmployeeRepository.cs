using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public void Add(Employee entity)
        {
            
        }

        public void Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee Get(Predicate<Employee> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll(Predicate<Employee> predicate = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
