using System;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var z = InputNum("Input z:");
            var m = new services.MathClass();
            var res = m.Calc(z);

            Console.Write("Number of branch: ");
            Console.WriteLine(m.numOfBranch);
            Console.Write("Result: ");
            Console.WriteLine(res);
        }

        public static double InputNum(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            double res;
            while (!double.TryParse(input, out res))
            {
                Console.WriteLine("Incorrect input");
                Console.WriteLine(message);
                input = Console.ReadLine();
            }
            return res;
        }
    }
}
