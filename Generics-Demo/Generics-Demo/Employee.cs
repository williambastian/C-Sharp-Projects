using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Demo
{
    public class Employee<T>        // The class is defined as taking a generic type parameter
    {
        public List<T> Things { get; set; }   // Things is a public List property of Employee objects
    }
}
