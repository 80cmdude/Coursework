using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos
{
    public class SimpleCalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        
        public int Sub(int x, int y)
        {
            return x - y;
        }
        
        public int Div(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException e)
            {
                return 0;
            }
        }
        
        public int Mul(int x, int y)
        {
            return x * y;
        }
    }
}
