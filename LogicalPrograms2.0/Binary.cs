using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms2._0
{
    class Binary
    {
        public static void Binarynum()
        {
            DecToBinary.ToBinary();
        }

        public static void SwapNibbles()
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write((n & 0x0F) << 4 | (n & 0xF0) >> 4);
        }

    }
}
