using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace ConsoleApp13
{
    class Program
    {


        static void Main(string[] args)
            {
            Random r = new Random();
            List<Figure> figures = new List<Figure>();
            for (int i = 0; i < 1000; i++)
            {
                int n = r.Next(1, 3);
                    if (n == 1) figures.Add(new Circle(new Point(r.Next(100), r.Next(100))));
                    else figures.Add(new Triangle(new Point(r.Next(100), r.Next(100))));
                }
            foreach (Figure f in figures)
            {
                f.Draw();
                }

            Stopwatch stopwatch = Stopwatch.StartNew();
            Point p = new Point(r.Next(100), r.Next(100));
            string find = "";
            foreach (Figure f in figures)
            {
                if (p == f.Center)
                    {
                        find = "Find";
                        break;
                    }
            }
                stopwatch.Stop();
                TimeSpan t = stopwatch.Elapsed;
                Console.WriteLine($"{find}. Operation time: {t}");
            }
        }
    }
        
    

