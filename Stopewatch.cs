using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class stopewatch
    {
        public static void Watch()
        {
            Console.WriteLine("Press any key to start the stopwatch");
            Console.ReadKey();

            DateTime startTime = DateTime.Now;

            Console.WriteLine("Stopwatch started...");

            Console.WriteLine("Press any key to stop the stopwatch");
            Console.ReadKey();

            TimeSpan elapsedTime = DateTime.Now - startTime;

            Console.WriteLine("Elapsed time: {0}", elapsedTime);
        }
    }
}
