using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Task1.Properties
{
    public class Triangle : Shape
    {
        private static int numOfVertices;
        public Point A { get; private set; }
        public Point B { get; private set; }
        public Point C { get; private set; }
        

        public Triangle(Point A, Point B, Point C)
            : base((A.x + B.x + C.x) / 3, (A.y + B.y + C.y) / 3)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public override void Print()
        {
            Console.Write("Triangle: ");
            A.Print();
            Console.Write(" ");
            B.Print();
            Console.Write(" ");
            C.Print();
        }

        public override void Move(int dx, int dy)
        {
            A.Move(dx, dy);
            B.Move(dx, dy);
            C.Move(dx, dy);
            base.Move(dx, dy);
        }
    }
}