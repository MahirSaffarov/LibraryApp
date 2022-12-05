using DomainLayer.Entities;
using RepositoryLayer.Helpers.Exceptions;
using RepositoryLayer.Repositories;
using ServiceLayer.DepartamentService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DepartamentService
{
    public class DepartamentService : IDepartamentService
    {
        private readonly DepartamentRepository _repo;
        private int _count;

        public DepartamentService()
        {
            _repo = new DepartamentRepository();
        }

        public Departament Create(Departament departament)
        {
            departament.Id = _count;
            _repo.Add(departament);
            _count++;
            return departament;
        }
        public Departament Update(int? id, Departament departament)
        {
            if (id is null) throw new ArgumentNullException();
           _repo.Update(departament);
            return departament;
        }
        public void Delete(int? id)
        {
            if (id == null) throw new ArgumentNullException();

            Departament departament = GetById(id);

            if (departament == null) throw new NotFoundException("Data not found");

            _repo.Delete(departament);

        }
        public Departament GetById(int? id)
        {
            if (id is null) throw new ArgumentNullException();
            return _repo.Get(m => m.Id == id);
        }
        public List<Departament> GetAll()
        {
            _repo.GetAll();
            return _repo.GetAll();
        }

        public List<Departament> Search(string searchText)
        {
            return _repo.GetAll(m => m.Name.ToLower().Contains(searchText.ToLower()));
        }

        
    }
}
