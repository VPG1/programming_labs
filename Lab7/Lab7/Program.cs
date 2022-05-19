using System;
using System.Runtime.ConstrainedExecution;

namespace Lab7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var a = new Complex(10, 5);
            var b = new Complex(0, 0);
            var c = new Complex(-5, 7);
            
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            
            Console.WriteLine();
            
            Console.WriteLine("implicit convert to double");
            Console.WriteLine("a: " + (double)a);
            Console.WriteLine("b: " + (double)b);
            Console.WriteLine("c: " + (double)c);
            
            Console.WriteLine();
            
            Console.WriteLine("arithmetic  operations");
            Console.WriteLine("a + c = " + (a + c));
            Console.WriteLine("a - c = " + (a - c));
            Console.WriteLine("a * c = " + (a * c));
            Console.WriteLine("a / c = " + (a / c));
            Console.WriteLine("a + 2 = " + (a + 2));
            
            Console.WriteLine();
            
            Console.WriteLine("convert to bool");
            Console.WriteLine("a: " + (a ? "true" : "false"));
            Console.WriteLine("b: " + (b ? "true" : "false"));
            Console.WriteLine("c: " + (c ? "true" : "false"));
            
            Console.WriteLine();
            
            Console.WriteLine("a > c: " + (a > c));
            Console.WriteLine("a < b: " + (a < b));
        }
    }
}