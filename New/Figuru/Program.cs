﻿using System;

namespace ConsoleApp4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triangle triangletest = new Triangle();
            triangletest.KolGraney = 2;
            triangletest.DlinaGraney = 1;
            triangletest = Poschitat(triangletest);
           Console.WriteLine(triangletest.PloshadFigyru);


        }
           
           
       
       public static Triangle Poschitat(Triangle triangle)
        {
            triangle.PloshadFigyru = triangle.DlinaGraney * triangle.KolGraney;
            return triangle;

           
            

        }
       
        
          
        }
       
       



    }

    



