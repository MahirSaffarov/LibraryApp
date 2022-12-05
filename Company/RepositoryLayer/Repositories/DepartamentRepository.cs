using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RepositoryLayer.Repositories
{
    public class DepartamentRepository : IRepository<Departament>
    {
        public void Add(Departament entity)
        {
            if (entity is null) throw new ArgumentNullException();
            AppDbContext<Departament>.datas.Add(entity);
        }
        public void Update(Departament entity)
        {
            if (entity is null) throw new ArgumentNullException();
            AppDbContext<Departament>.datas[entity.Id] = entity;
        }

        public void Delete(Departament entity)
        {
            if (entity is null) throw new ArgumentNullException();
            AppDbContext<Departament>.datas.Remove(entity);
        }

        public Departament Get(Predicate<Departament> predicate)
        {
            return AppDbContext<Departament>.datas.Find(predicate);
        }

        public List<Departament> GetAll(Predicate<Departament> predicate = null)
        {
            return predicate == null ? AppDbContext<Departament>.datas : AppDbContext<Departament>.datas.FindAll(predicate);
        }
    }
}
