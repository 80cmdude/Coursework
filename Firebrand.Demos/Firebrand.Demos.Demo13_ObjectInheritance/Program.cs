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
            Dog rover = new Dog("This dog can say hello!");

            rover.Vocalize();

            Console.ReadKey();
        }
    }

    public class Dog : Animal
    {
        public Dog(string sound) : base(4, sound)
        {

        }

        public Dog() : base(4, "Woof!")
        {
            
        }
        public override void DisplayName()
        {
            //base.DisplayName();
            Console.WriteLine("dog");
        }
    }
}
