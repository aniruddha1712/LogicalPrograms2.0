using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms2._0
{
    class Sqrt
    {
        public static void SquareRoot()
        {
            Console.Write("Enter a number:");
            double c = double.Parse(Console.ReadLine());
            double t = c;
            double root=t;
            int count = 0;
            double l = 0.000000000000001*root;

            while (true)
            {
                count++;
                root = 0.5 * (t + (c / t));
                if (Math.Abs(root - t) < l)
                    break;

                t = root;
            }
            Console.WriteLine("Square root of number: " + root);
        }
    }
}
