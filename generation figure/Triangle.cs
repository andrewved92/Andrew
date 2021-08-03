using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ConsoleApp13
{
   public  class Triangle : Figure
    {
        public Triangle(Point pt) : base(pt) { }
        public double Perimeter { get; set; }
        public override void Draw() => Console.WriteLine($"Drawing the Triangle: {Center}");
    }
}
