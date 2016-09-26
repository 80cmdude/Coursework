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

            Console.WriteLine("Enter x");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Operation");
            op = Console.ReadLine();

            AdvancedCalculator calc = new AdvancedCalculator();

            switch (op)
            {
                case "Add":
                    result = calc.Add(x, y);
                    break;
                case "Sub":
                    result = calc.Sub(x, y);
                    break;
                case "Mul":
                    result = calc.Mul(x, y);
                    break;
                case "Div":
                    result = calc.Div(x, y);
                    break;
                case "Mod":
                    result = calc.mod(x, y);
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);
            Console.WriteLine("Press enter to end");
            Console.ReadLine();
        }
    }
}
