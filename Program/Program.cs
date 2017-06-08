using System;
using System.Collections.Generic;

namespace UDS
{
    public class Weekends
    {
        public DateTime StartDate;
        public DateTime EndDate;
    }

    public class Program
    {
        public static DateTime EndD(DateTime startDay, int duration, List<Weekends> we)
        {
            DateTime endD = new DateTime();

            endD = startDay.AddDays(duration);

            for (int i = 0; i < we.Count; i++) endD = endD.Add(we[i].EndDate - we[i].StartDate).AddDays(1);

            return endD;
        }

        public static void Main()
        {
            var StartD = new DateTime(2017, 4, 21);

            int Duration = 5;

            List<Weekends> WE = new List<Weekends>
            {
              new Weekends { StartDate = new DateTime(2017, 4, 23), EndDate = new DateTime(2017, 4, 25) },
              //new Weekends { StartDate = new DateTime(2017, 4, 28), EndDate = new DateTime(2017, 4, 28) }
            };

            Console.WriteLine("Start date: " + StartD.ToString("dd/MM/yyyy") + "\n");

            Console.WriteLine("Duration:   " + Duration + "\n");

            Console.Write("Weekends:   ");

            WE.ForEach(
                item =>
                Console.WriteLine(item.StartDate.ToString("dd/MM/yyyy") + "  " + item.EndDate.ToString("dd/MM/yyyy"))
            );

            Console.WriteLine("\nEnd date:   " + EndD(StartD, Duration, WE).ToString("dd/MM/yyyy"));

            Console.ReadKey();

        }

    }
}