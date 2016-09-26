using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos
{
    public class AdvancedCalculator : SimpleCalculator
    {
        public int mod(int x, int y)
        {
            return x % y;
        }
    }
}
