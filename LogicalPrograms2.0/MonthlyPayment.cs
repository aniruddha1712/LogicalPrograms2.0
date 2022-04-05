using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms2._0
{
    class MonthlyPayment
    {
        public static void MonthlyPay()
        {
            Console.WriteLine("Enter Principal loan amount");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Interest Rate(value only)");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter time span in Years");
            double y = double.Parse(Console.ReadLine());

            double n = 12 * y;
            double r = R / 1200;

            double payment = (p * r) / (1 -Math.Pow((1+r),(-n)));

            Console.Write(Math.Round( payment,2)+" Rs. is the monthly payment.");
        }
    }
}
