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

            //if (y == 0)
            //{
            //    throw new ArgumentOutOfRangeException("Y Cannot be 0!");
            //}
            //if (x == null || y == null)
            //{
            //    throw new ArgumentNullException("X and Y must be a number");
            //}
            try
            {
                return x / y;
            }
            catch (DivideByZeroException e)
            {
                throw new ArgumentOutOfRangeException("Y Cannot be 0!");
            }
            catch (Exception e)
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
