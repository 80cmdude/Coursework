using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Firebrand.Demos.Demo15_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = 1200;
            var dir = Directory.GetCurrentDirectory();
            foreach (var file in Directory.GetFiles(dir))
            {
                Console.WriteLine(file);
            }
            //Create a file
            var fileName = dir + "\\test.txt";
            //File.Create(fileName);

            //Write to a file
            File.AppendAllText(fileName, "MUCH TEXT, WOW");
            var inf = new FileInfo(fileName);
            Console.WriteLine("File length: {0}", inf.Length);

            Console.ReadKey();
        }
    }
}
