using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class DepartamentRepository : IRepository<Departament>
    {
        public void Add(Departament entity)
        {
            if (entity == null) throw new ArgumentNullException();
            AppDbContext<Departament>.datas.Add(entity);
        }
    }
}
