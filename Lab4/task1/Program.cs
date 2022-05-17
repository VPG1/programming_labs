using System;
using System.IO;
using System.Threading;

namespace task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter address of ATE:");
            var address = Console.ReadLine();
            
            Console.WriteLine("Enter number of clients:");
            int numOfClients;
            while (!int.TryParse(Console.ReadLine(), out numOfClients))
            {
                Console.WriteLine("Incorrect input");
                Console.WriteLine("Enter number of clients:");
            }
            
            Console.WriteLine("Enter tariff:");
            decimal tariff;
            while (!decimal.TryParse(Console.ReadLine(), out tariff))
            {
                Console.WriteLine("Incorrect input");
                Console.WriteLine("Enter tariff:");
            }
            
            var ate = ATE.GetInstance(address, numOfClients, new Tariff(tariff));


            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Address:{ate.Address}\tNumber of clients:{ate.NumOfClients}\tTariff:{ate.Tariff.Value}");
                Console.WriteLine("1.Calculate pay");
                Console.WriteLine("2.Increase pay");
                Console.WriteLine("3.Decrease pay");
                Console.WriteLine("4.Exit");

                if (!int.TryParse(Console.ReadLine(), out var chose) || chose > 4 || chose <= 0)
                {
                    Console.WriteLine("Incorrect input");
                    Console.WriteLine("Press enter...");
                    Console.ReadLine();
                    continue;
                }

                Console.Clear();
                if (chose == 1)
                {
                    Console.WriteLine(ate.CalculatePay());
                    Console.WriteLine("Press enter...");
                    Console.ReadLine();
                }
                else if (chose == 2)
                {  
                    Console.WriteLine("Enter increase value:");
                    decimal increaseValue;
                    while (!decimal.TryParse(Console.ReadLine(), out increaseValue))
                    {
                        Console.WriteLine("Incorrect input");
                        Console.WriteLine("Enter increase value:");
                    }
                    ate.IncreaseTariff(increaseValue);
                }
                else if (chose == 3)
                {
                    Console.WriteLine("Enter decrease value:");
                    decimal increaseValue;
                    while (!decimal.TryParse(Console.ReadLine(), out increaseValue))
                    {
                        Console.WriteLine("Incorrect input");
                        Console.WriteLine("Enter decrease value:");
                    }
                    ate.DecreaseTariff(increaseValue);
                }
                else
                {
                    break;
                }
            }

        }
    }
}