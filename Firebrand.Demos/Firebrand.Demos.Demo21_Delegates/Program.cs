using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos.Demo21_Delegates
{
    class Program
    {
        //Create class called MyDelegate
        delegate void MyDelegate(string name);

        static void Main(string[] args)
        {
            SayHello("Sam");

            //Get a hold of a reference to a method
            MyDelegate del = new MyDelegate(SayGoodbye);
            del.Invoke("Ash");
            del("Orochi");
            Test(del);

            MyDelegate del1 = delegate(string name) { Console.WriteLine("Hey There!, {0}", name); };
            del1("Anonomous Delegate");

            //lamda expressions


            Console.ReadKey();
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hey There!, {0}", name);
        }

        static void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye, {0}", name);
        }

        static void Test(MyDelegate del)
        {
            del("Desu");
        }
    }
}
