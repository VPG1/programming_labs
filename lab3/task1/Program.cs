using System;
//using MathClass;

namespace task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = InputNum("input x:");
            int y = InputNum("input y:");

            Console.Write("min(x, 2 * y + x) - min(7 * x + 2 * y, y) = ");
            Console.WriteLine(MathClass.min(x, 2 * y + x) - MathClass.min(7 * x + 2 * y, y));
        }

        public static int InputNum(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int res;
            while (!int.TryParse(input, out res))
            {
                Console.WriteLine("Incorrect input");
                Console.WriteLine(message);
                input = Console.ReadLine();
            }
            return res;
        }
    }
}
