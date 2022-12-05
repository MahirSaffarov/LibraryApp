using DomainLayer.Entities;
using RepositoryLayer.Repositories;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class DepartamentService : IDepartamentService
    {
        private readonly DepartamentRepository _repo;
        private int _count;
        public DepartamentService()
        {
            _repo= new DepartamentRepository();
        }
        public Departament Create(Departament departament)
        {
            departament.Id = _count;
            _repo.Add(departament);
            _count++;
            return departament;
        }
    }
}
