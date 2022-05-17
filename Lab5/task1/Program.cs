using System;
using System.Collections.Generic;
using System.Linq;

namespace task1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number of tariffs:");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num) || num < 1)
            {
                Console.WriteLine("Incorrect input");
                Console.WriteLine("Enter number of tariffs:");
            }

            List<Tariff> tariffs = new List<Tariff>();
            int n = num;
            while (num != 0)
            {
                Console.Clear();
                Console.WriteLine($"Tariff {n - num + 1}");
                Console.WriteLine("Enter tariff type:");
                var tariffType = Console.ReadLine();

                var tariffExist = false;
                foreach (var tariff in tariffs)
                {
                    if (tariff.TariffType == tariffType)
                    {
                        Console.WriteLine("This tariff already exist");
                        tariffExist = true;
                        break;
                    }
                }

                if (tariffExist)
                {
                    continue;
                }
                
                
                Console.WriteLine("Enter tariff coast:");
                decimal coast;
                while (!decimal.TryParse(Console.ReadLine(), out coast) || coast < 0)
                {
                    Console.WriteLine("Incorrect input");
                    Console.WriteLine("Enter tariff coast:");
                }
                
                tariffs.Add(new Tariff(tariffType, coast));
                
                --num;
            }

            
            Ate ate = new Ate(tariffs);
            
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1. Log in");
                Console.WriteLine("2. Add tariff");
                Console.WriteLine("3. User list");
                Console.WriteLine("4. Price of all user calls");
                Console.WriteLine("5. Price of all calls");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Chose number of variant:");
                int selectionNumber;
                while (!int.TryParse(Console.ReadLine(), out selectionNumber) ||
                       selectionNumber <= 0 ||
                       selectionNumber > 6)
                {
                    Console.WriteLine("Incorrect input");
                    Console.WriteLine("Chose number of variant:");
                }

                Console.Clear();
                if (selectionNumber == 1)
                {
                    Console.WriteLine("Enter name:");

                    var name = Console.ReadLine();
                    while (name == "")
                    {
                        Console.WriteLine("Incorrect input");
                        Console.WriteLine("Enter name:");
                        name = Console.ReadLine();
                    }
                    
                    ate.LogIn(name);
                    
                    
                    Console.Clear();
                    
    
                    
                    var tariff = ate.GetTariffs()[0];
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Tariff type: " + tariff.TariffType);
                        Console.WriteLine("1. Call");
                        Console.WriteLine("2. Change tariff");
                        Console.WriteLine("3. Log out");

                        Console.WriteLine("Chose number of variant:");
                        int selectionNumber2;
                        while (!int.TryParse(Console.ReadLine(), out selectionNumber2) ||
                               selectionNumber2 <= 0 ||
                               selectionNumber2 > 3)
                        {
                            Console.WriteLine("Incorrect input");
                            Console.WriteLine("Chose number of variant:");
                        }

                        Console.Clear();
                        if (selectionNumber2 == 1)
                        {
                            var state = ate.Call(tariff.TariffType);

                            if (state == Ate.State.NotSuccessfully)
                            {
                                Console.WriteLine("woops");
                                return;
                            }
                            
                            Console.WriteLine("Success");
                            Console.WriteLine("Press enter...");
                            Console.ReadLine();
                        }
                        else if (selectionNumber2 == 2)
                        {
                            var i = 1;
                            foreach (var el in ate.GetTariffs())
                            {
                                Console.WriteLine(i + ". " + el.TariffType + "\tcoast: " + el.Coast);
                                ++i;
                            }

                            Console.WriteLine("Chose number of variant:");
                            int selectionNumber3;
                            while (!int.TryParse(Console.ReadLine(), out selectionNumber3) ||
                                   selectionNumber3 <= 1 ||
                                   selectionNumber3 > ate.GetTariffs().Count)
                            {
                                Console.WriteLine("Incorrect input");
                                Console.WriteLine("Chose number of variant:");
                            }

                            tariff = ate.GetTariffs()[selectionNumber3 - 1];
                        }
                        else
                        {
                            ate.LogOut();
                            
                            break;
                        }

                    }
                }
                else if (selectionNumber == 2)
                {
                    var i = 1;
                    foreach (var el in ate.GetTariffs())
                    {
                        Console.WriteLine(i + ". " + el.TariffType + "\tcoast: " + el.Coast);
                        ++i;
                    }

                    Console.WriteLine();
                    
                    Console.WriteLine("Enter name of new tariff:");
                    var newTariff = Console.ReadLine();
                    
                    Console.WriteLine("Enter coast:");
                    decimal newTariffCoast;
                    while (!decimal.TryParse(Console.ReadLine(), out newTariffCoast) || newTariffCoast < 0)
                    {
                        Console.WriteLine("Incorrect input");
                        Console.WriteLine("Enter coast:");
                    }

                    var state = ate.AddTariff(newTariff, newTariffCoast);
                    
                    Console.WriteLine(state == Ate.State.NotSuccessfully ? "This tariff already exist" : "Success");

                    Console.WriteLine("Press enter...");
                    Console.ReadLine();
                }
                else if (selectionNumber == 3)
                {
                    foreach (var el in ate.GetUsers())
                    {
                        Console.WriteLine(el.Name);
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine("Press enter...");
                    Console.ReadLine();
                }
                else if (selectionNumber == 4)
                {
                    Console.WriteLine("Enter name:");

                    var name = Console.ReadLine();
                    while (name == "")
                    {
                        Console.WriteLine("Incorrect input");
                        Console.WriteLine("Enter name:");
                        name = Console.ReadLine();
                    }

                    var value = ate.Find(name);
                    Console.WriteLine((value >= 0) ? ("Price:" + value) : "Not found");
                    Console.WriteLine("Press enter...");
                    Console.ReadLine();
                }
                else if (selectionNumber == 5)
                {
                    Console.WriteLine("Price of calls: " + ate.CallsCoast());
                    Console.WriteLine("Press enter...");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            
            
        }
    }
}