using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Class_Methods_Demo
{
    static class StaticClass
    {
        public static void divideByFour(double num5)
        {
            double staticResult = num5 / 4;
            Console.WriteLine("The number " + num5 + " divided by 4 equals: " + staticResult);
        }
    }
}
