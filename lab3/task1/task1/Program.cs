using System;

namespace task1
{
    class A
    {
        public int a;
        public int b;
        public int c;

        public A(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
    
    
    internal class Program
    {
        static void Foo(ref A a)
        {
            a = new A(12, 13, 15);
        }
        
        public static void Main(string[] args)
        {
            var a = new A(15, 15, 15);
            Foo(ref a);
            Console.WriteLine ($"x:{a.a}\ty:{a.b}\tz:{a.c}");
        }
    }
}