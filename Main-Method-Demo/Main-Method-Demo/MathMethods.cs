using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Demo
{
    class MathMethods
    {
        public int someMath(int num1)      //all methods have the same, vague name for demonstration purposes
        {                                  // this class demonstrates the basics of how methods can be overloaded for unique use cases

            return (num1 + 5);        //if input is integer format, add input to 5
        }

        public int someMath(decimal num2)
        {
            decimal oneDec = 12.00m;                                  // if input is decimal, multiply by 12
            decimal resultDec = Decimal.Multiply(oneDec, num2);
            int resultInt = Decimal.ToInt32(resultDec);
            return resultInt;
        }

        public int someMath(string num3)
        {
            int num3int = Convert.ToInt32(num3);       // if input is string, multiply by 3
            int resultInt3 = num3int * 3;
            return resultInt3;
        }
    }
}
