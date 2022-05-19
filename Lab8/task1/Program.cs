using System;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;

namespace task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Ate ate = new Ate();
            ate.AddAbsDiscountTariff("tariff1", 3200, 200);
            ate.AddNoDiscountTariff("tariff2", 1200);
            Console.WriteLine(ate.GetAveragePrice());
        }
    }
}