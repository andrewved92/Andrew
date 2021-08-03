using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ConsoleApp13
{
     public class Circle : Figure
    {
        public Circle(Point pt) : base(pt) { }
        public double Radius { get; set; }
        public override void Draw() => Console.WriteLine($"Drawing the Circle: {Center}");
    }
}
