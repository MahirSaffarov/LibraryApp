using Implicit__Explicit__Generic.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit__Explicit__Generic.Models
{
    public class Repository<T,U> where T : class
                               //where T : struct
                               //where T : Common
                               //where T : ITest
                               //where T : new()
                               //where T : U
    {
    }
}
