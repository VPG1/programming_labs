using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Permissions;

namespace Task1
{
    public sealed class Point : Shape
    {
        public Point(int x, int y) 
            : base(x, y){}

        public override void Print()
        {
            Console.Write($"Point: ({x}, {y})");
        }
    }
}