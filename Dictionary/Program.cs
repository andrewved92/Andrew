using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, Figure> figures = new Dictionary<char, Figure>();
            figures.Add('t', new Figure() { Name = "Triangle" });
            figures.Add('s', new Figure() { Name = "Square" });
            figures.Add('p', new Figure() { Name = "Polygon" });
            Stopwatch stopwatch = Stopwatch.StartNew();

            foreach (KeyValuePair<char, Figure> keyValue in figures)
            {
                stopwatch.Stop();
                TimeSpan t = stopwatch.Elapsed;
                Console.WriteLine($"{figures}. Operation time: {t}");
                Console.WriteLine( keyValue.Key + " - " + keyValue.Value.Name, $"{figures}");
               

            }

        }
    }
}

