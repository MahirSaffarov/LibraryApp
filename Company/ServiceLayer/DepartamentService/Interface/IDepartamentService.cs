using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Entities;

namespace ServiceLayer.DepartamentService.Interface
{
    public interface IDepartamentService
    {
        Departament Create(Departament library);
        Departament Update(int? id, Departament library);
        void Delete(int? id);
        Departament GetById(int? id);
        List<Departament> GetAll();
        List<Departament> Search(string searchText);
    }
}
