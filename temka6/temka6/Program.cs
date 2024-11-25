using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temka6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parse
            DateTime date1 = DateTime.Parse("2024-11-26");
            Console.WriteLine($"Parse: {date1}");

            // ParseExact
            DateTime date2 = DateTime.ParseExact("26.11.2024", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine($"ParseExact: {date2}");

            // TryParse
            if (DateTime.TryParse("2024-11-26", out DateTime date3))
                Console.WriteLine($"TryParse: {date3}");
            else
                Console.WriteLine("TryParse: Некорректная дата");

            // TryParseExact
            if (DateTime.TryParseExact("26 ноября 2024", "dd MMMM yyyy", CultureInfo.CreateSpecificCulture("ru-RU"), DateTimeStyles.None, out DateTime date4))
                Console.WriteLine($"TryParseExact: {date4}");
            else
                Console.WriteLine("TryParseExact: Некорректная дата");
        }
    }
}
