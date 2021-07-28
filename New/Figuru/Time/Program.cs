using System;
using System.Diagnostics;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                int a = 345;
                
                object b = a;
                Console.WriteLine(b);
                Console.WriteLine(stopwatch.ElapsedTicks);

                stopwatch.Stop();
               
                stopwatch.Start();
                int j = (int)b;
             
                stopwatch.Stop();

                Console.WriteLine(b);

                Console.WriteLine(stopwatch.ElapsedTicks);
            }
        }
    }
}

