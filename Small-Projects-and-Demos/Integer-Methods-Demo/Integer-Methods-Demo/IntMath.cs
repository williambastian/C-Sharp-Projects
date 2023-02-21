using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Methods_Demo
{
    class IntMath                  // create a class with basic demos of integer arithmetic methods.
                                   // The arithmetic here is simple for purposes of demonstration.
    {
        public int IntSquared(int num1)      //IntSquared() will return the square of a given integer
        {
           return (num1 * num1);  
        }

        public int IntDoubled(int num2)      //IntDoubled() will double the value of a given integer
        {
            return (num2 + num2);
        }

        public int IntTimesTen(int num3)    //IntTimesTen() will multiply a given integer by ten
        {
            return (num3 * 10);
        }
    }
}
