using System;
namespace task3
{
    public class DataService
    {
        public DataService()
        {
        }

        public static string GetDay(string date)
        {
            var dateTime = DateTime.Parse(date);
            var dayOfWeek = dateTime.DayOfWeek;
            return dayOfWeek.ToString();
        }

        public static int GetDaySpan(int day, int month, int year)
        {
            var dateTime = new DateTime(year, month, day);
            var dateSpan = dateTime - DateTime.Today;
            return Math.Abs(dateSpan.Days);
        }
    }
}
