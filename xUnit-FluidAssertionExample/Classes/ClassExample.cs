using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnit_FluidAssertionExample.Classes
{
    public class ClassExample
    {
        public int sumResult(int a, int b)
        {
            return a + b;
        }

        public string returnFoxIfZero(int a)
        {
            if (a == 0)
            {
                return "Fox";
            }
            else { return "Not a Fox"; }
        }
    }
}
