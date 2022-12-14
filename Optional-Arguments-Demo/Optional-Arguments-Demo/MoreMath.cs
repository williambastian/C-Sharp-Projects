using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Arguments_Demo
{
    class MoreMath
    {
        public int argsDemo( int requiredVal, int optionalVal=1 )  //set optional parameter equal to 1, which is appropriate for a multiplication method (multiplication by 1 results in no change to output)
        {
            return requiredVal * optionalVal;
        }
    }
}
