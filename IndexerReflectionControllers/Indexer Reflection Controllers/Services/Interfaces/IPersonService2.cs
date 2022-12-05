using Indexer_Reflection_Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Controllers.Services.Interfaces
{
    public interface IPersonService2
    {
        public double BeginCNameSquareCount(Predicate<Person2> predicate);
    }
}
