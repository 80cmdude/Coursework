using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, result = 0;
            string op;
            
            AdvancedCalculator calc = new AdvancedCalculator();
            
            while (true)
            {
                Console.WriteLine("Enter x");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter y");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Operation");
                op = Console.ReadLine().ToUpper();

                switch (op)
                {
                    case "ADD":
                        result = calc.Add(x, y);
                        break;
                    case "SUB":
                        result = calc.Sub(x, y);
                        break;
                    case "MUL":
                        result = calc.Mul(x, y);
                        break;
                    case "DIV":
                        result = calc.Div(x, y);
                        break;
                    case "MOD":
                        result = calc.mod(x, y);
                        break;
                    case "QUIT":
                        return;
                    default:
                        break;
                }
                Console.WriteLine("Answer = " + result);
            }
        }
    }
}
