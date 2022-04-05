using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms2._0
{
    class FindDayOfWeek
    {
        public static void DayOfWeek()
        {
            Console.WriteLine("Enter date:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year:");
            int y = Convert.ToInt32(Console.ReadLine());

            int y0 = y - (14-m)/12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14-m)/12) - 2;
            int d0 = (d + x + (30 * m0)/12) % 7;

            Console.WriteLine(d0);
        }
    }   
}
