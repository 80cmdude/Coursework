using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireBrand.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;

            numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("1d Array");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
            //2D Array
            int[,] grid = new int[3, 4];

            grid[0, 0] = 20;
            Console.WriteLine("2D array");
            Console.WriteLine(grid[0, 0]);

            //Jagged array
            int[][] jagged = new int[3][];
            jagged[0] = new int[4];
            jagged[1] = new int[3];
            jagged[2] = new int[7];

            jagged[0][3] = 20;
            jagged[2][6] = 10;

            Console.WriteLine("Jagged Array");
            Console.WriteLine("{0} {1}", jagged[0][3], jagged[2][6]);
            Console.WriteLine("Press enter to close");
            Console.ReadLine();

        }
    }
}
