using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LogicalPrograms 2.0");

            Console.WriteLine("1:VendingMachine\n2:DayofWeek\n3:TemperatureConversion\n" +
                "4:MonthlyPayment\n5:SquareRoot\n6:ToBinary\n7:Swapnibble");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    VendingMachine.NoteVending();
                    break;
                case 2:
                    FindDayOfWeek.DayOfWeek();
                    break;
                case 3:
                    TemperatureConversion.TempConversion();
                    break;
                case 4:
                    MonthlyPayment.MonthlyPay();
                    break;
                case 5:
                    Sqrt.SquareRoot();
                    break;
                case 6:
                    DecToBinary.ToBinary();
                    break;
                case 7:
                    Binary.Binarynum();
                    Binary.SwapNibbles();
                    break;
            }
            Console.ReadLine();
        }
    }
}
