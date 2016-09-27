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

            GermanShepard max = new GermanShepard();
            max.Vocalize();

            Monkey harmabe = new Monkey();
            harmabe.DisplayName();
            harmabe.Vocalize();

            var animals = new IAnimal[] 
            {
                new Dog(),
                new GermanShepard(),
                new Monkey()
            };

            foreach (var animal in animals) 
            {
                animal.Vocalize();
            }

            Console.ReadKey();
        }
    }

    public class Monkey : Animal
    {
        public Monkey()
            : base(2, "Justice for me")
        {

        }
        
        public override void DisplayName()
        {
            Console.WriteLine("Monkey");
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

    public class GermanShepard : Dog
    {
        public GermanShepard() : base("Big Woof from German Shepard")
        {

        }
    }
}
