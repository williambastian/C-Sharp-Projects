using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Class_Methods_Demo
{
    class MoreMethods
    {
        public void DivByTwo(int num1)      //void method, accepts integer, outputs integer that is passed in value divided by two.
        {
            int dividend = (num1 / 2);
            Console.WriteLine("The number " + num1 + " divided by two is: " + dividend);
        }

        public void OutParams( out int outNum1, out int outNum2)     //static void method with output parameters; values of variables assigned within method
        {
            outNum1 = 15;
            outNum2 = 25;
            outNum1 += outNum1;
            outNum2 += outNum2;
            
        }

        public void OutParams(out double outNum3, out double outNum4)      //overload OutParams() with decimal type inputs. If variables provided are decimal, different values are assigned.
        {
            outNum3 = 1.257;
            outNum4 = 2.652;
            outNum3 += outNum3;
            outNum4 += outNum4;
        }
    }
}
