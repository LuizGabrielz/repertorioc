// TimeZone

using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CLear();

            var dateTime = DateTime.UtcNow;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(dateTime);    

            Console.WriteLine(utcDate.ToLocaleTime());

            var timezoneAustralia =
            TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

            var horaAustralia = 
                TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);        
        }
    }
}  