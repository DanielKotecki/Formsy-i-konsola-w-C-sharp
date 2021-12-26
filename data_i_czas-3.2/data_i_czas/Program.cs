using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_i_czas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.UtcNow.ToLocalTime();
            DateTime day = DateTime.UtcNow.AddDays(-100);
            DateTime day2 = new DateTime(2019, 1, 1);
            DateTime hour2 = DateTime.UtcNow.AddMinutes(175);
            bool przestepny = DateTime.IsLeapYear(2010);
            DateTime birthday = new DateTime(1998, 02, 09);
            TimeSpan birthdayDay = DateTime.Today - birthday;
            int days = DateTime.DaysInMonth(2018, 11);

            Console.WriteLine("\n\na) " + data.ToString("d MMM yy"));
            Console.WriteLine("b) " + data.ToString("hh:mm"));
            Console.WriteLine("c) " + day.ToString("dddd"));
            Console.WriteLine("d) " + day2.ToString("dddd"));
            Console.WriteLine("e) " + hour2.ToString("HH:mm"));
            Console.WriteLine("f) " + przestepny.ToString());
            Console.WriteLine("g) " + days.ToString());
            Console.WriteLine("h) " + birthdayDay.ToString("dd"));
            Console.ReadKey();


        }
    }
}
