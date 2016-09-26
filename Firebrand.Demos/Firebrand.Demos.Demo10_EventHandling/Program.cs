using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos.Demo10_EventHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Manatee = new Animal();
            Human Ashley = new Human(Manatee);

            Ashley.Watch();

            Manatee.Run();

            Ashley.UnWatch();
            
            Ashley = null;

            Manatee.Run();

            Console.ReadKey();
        }
        
        public class Human
        {
            private Animal _animal;

            public Human(Animal animal)
            {
                _animal = animal;
            }

            public void UnWatch()
            {
                //Unsub from event faster than the FineBros
                _animal.onRun -= animal_onRun;
            }

            public void Watch()
            {
                //Subscribe to Event
                _animal.onRun += animal_onRun;
            }

            void animal_onRun(object sender, EventArgs e)
            {
                //react to event
                Console.WriteLine("RUN... RUNN....RUNNNNNNNNN");
            }
        }

        public class Animal
        {
            public event EventHandler onRun;

            public void Run()
            {
                Console.WriteLine("The animal is runing after you!!!");

            //if somebody is listening then raise the event
                if (onRun != null)
                onRun(this, new EventArgs());
            }
        }
    }
}
