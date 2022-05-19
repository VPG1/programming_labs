using System;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter date(mm.dd.yyyy)");
            var dateString = Console.ReadLine();
            DateTime inputDate;
            while (!DateTime.TryParse(dateString, out inputDate))
            {
                Console.WriteLine("Incorrect input.");
                Console.WriteLine("Enter date(mm.dd.yyyy)");
                dateString = Console.ReadLine();
            }

            Console.WriteLine(DateTime.Today);
            Console.WriteLine(inputDate);



            Console.Write("Day of week: ");
            Console.WriteLine(DataService.GetDay(inputDate.ToString()));
            Console.Write("Span: ");
            Console.WriteLine(DataService.GetDaySpan(inputDate.Day, inputDate.Month, inputDate.Year));
        }
    }
}
