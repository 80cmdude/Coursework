using System;
using System.Text;

namespace Firebrand.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            int UnitCost = 5;
            long Quantity;
            short DayOfYear = 365;
            Int16 DayOfWeek = 7;
            string Message = "Total " + "Amount";

            Quantity = 34567;

            //Casting
            int TotalCost = Convert.ToInt32(Quantity) * UnitCost;

            Console.WriteLine("Total Cost: {0} {1} {2}", Quantity, UnitCost, TotalCost);

            Console.WriteLine("Press enter to quit");

            Console.ReadLine();
        }
    }
}
