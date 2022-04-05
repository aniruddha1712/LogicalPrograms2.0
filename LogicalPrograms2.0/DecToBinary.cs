using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms2._0
{
    class DecToBinary
    {
        public static void ToBinary()
        {
            int n, i;
            int[] arr = new int[100];
            Console.Write("Enter the number to convert: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                arr[i] = n % 2;
                n /= 2;
            }
            Console.Write("Binary of the given number= ");
            for (i -=1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
