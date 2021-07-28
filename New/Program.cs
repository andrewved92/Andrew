using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle test = new Triangle();
            test.KolGraney = 2;
            test.DlinaGraney = 1;
            test = Poschitat(test);
            Console.WriteLine(test.PloshadFiguru);
            Console.Read();
        }
        public static Triangle Poschitat(Triangle triangle)
        {
            triangle.PloshadFiguru = triangle.DlinaGraney * triangle.KolGraney;
            return triangle;
        }
        }
    }

