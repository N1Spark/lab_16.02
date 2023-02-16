using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_16._02
{
    class Program
    {
        struct Birthday
        {
            int Year, Day, Month;
            public DateTime dt;
            public Birthday(int d, int m, int y)
            {
                dt = new DateTime(y, m, d);
                Year = y;
                Day = d;
                Month = m;
            }
            public void BirthWeek()
            {
                Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);
            }
            public void BirthWeekByYear(int y)
            {
                DateTime buf = new DateTime(y, Month, Day);
                Console.WriteLine("The day of the week for {0:d} is {1}.", buf, buf.DayOfWeek);
            }
            public void BirthTime()
            {
                var current = DateTime.Today;
                int year = 0;
                if (current.Month > Month || current.Month == Month && current.Day > Day)
                    year = current.Year + 1;
                else
                    year = current.Year;

                var days = (new DateTime(year, Month, Day) - current).TotalDays;
                Console.WriteLine("Birthday will be through " + days + " days");
            }
        }
        static void Main(string[] args)
        {
            Birthday birthday = new Birthday(22, 6, 2004);
            birthday.BirthWeek();
            birthday.BirthWeekByYear(2024);
            birthday.BirthTime();
        }
    }
}
