using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Firebrand.Demos.Demo22_ParallelTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Task(() => ExecuteLongRunningJob(1, 3000));
            t1.Start();
            var t2 = new Task(() => ExecuteLongRunningJob(2, 4000));
            t2.Start();
            var t3 = new Task(() => ExecuteLongRunningJob(3, 2000));
            t3.Start();

            Task.WaitAll(t1, t2, t3);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static void ExecuteLongRunningJob(int id, int SleepTime)
        {
            Console.WriteLine("Task {0} is begining", id);
            Thread.Sleep(SleepTime);
            Console.WriteLine("Task {0} is ended", id);

        }
    }
}
