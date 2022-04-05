using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms2._0
{
    class TemperatureConversion
    {
        public static void TempConversion()
        {
            Console.WriteLine("Choose option\n1:Celsius to Fahrenheit \n2:Fahrenheit to Celsius");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter Temperature in Celsius");
                    double temp1 =double.Parse(Console.ReadLine());
                    Console.WriteLine((temp1 * 9 / 5) + 32 +"degF");
                    break;
                case 2:
                    Console.WriteLine("Enter Temperature in Fahrenheit");
                    double temp2 =double.Parse(Console.ReadLine());
                    Console.WriteLine((temp2 - 32) * 5 / 9 +"degC");
                    break;
            }        
        }
    }
}
