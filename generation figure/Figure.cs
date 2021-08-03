using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ConsoleApp13
{
     public class Figure
    {
        public Point Center { get; set; }
        public Figure(Point pt) => Center = pt;
        public virtual void Draw() => Console.WriteLine("Drawing the Figure!");
    }
}
