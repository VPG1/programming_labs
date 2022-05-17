using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Task1.Properties;

namespace Task1
{
    internal class Program
    {

        public static void PrintShapes(Shape[] shapes, int numOfShapes)
        {
            for (int i = 0; i < 50; ++i)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
            
            for (int i = 0; i < numOfShapes; ++i)
            {
                shapes[i].Print();
                Console.WriteLine();
            }

            for (int i = 0; i < 50; ++i)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            const int numOfShapes = 2;
            var shapes = new Shape[numOfShapes];
            shapes[0] = new Point(0, 0);
            shapes[1] = new Triangle(new Point(0, 0), new Point(50, 0), new Point(0, 40));

           
            PrintShapes(shapes, numOfShapes);
            
            Console.WriteLine("Move point");
            shapes[0].Move(10, -10);
                
            PrintShapes(shapes, numOfShapes);

            Console.WriteLine("Move triangle");
            shapes[1].Move(10, 10);
            
            PrintShapes(shapes, numOfShapes);

        }
    }
}