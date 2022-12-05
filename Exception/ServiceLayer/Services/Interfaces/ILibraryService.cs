using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ILibraryService
    {
        public List<Library> Libraries();
        public List<Books> GetLibraries(Predicate<Books> predicate);
    }
}
