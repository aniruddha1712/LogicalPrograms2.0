using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms2._0
{
    class VendingMachine
    {
        public static void NoteVending()
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            Console.WriteLine("Enter the amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            int minNote = 0;
            for (int i = 0; i < 8; i++)
            {
                if (amount >= notes[i])
                {
                    int tempNote = 0;
                    int rem = amount % notes[i];
                    int note = amount / notes[i];
                    tempNote += note;
                    amount = rem;
                    minNote += note;
                    Console.WriteLine("number of {0} rs. note: {1} ", notes[i], tempNote);
                }
                else
                    continue;
            }
            Console.WriteLine("Minimum note required to return the change: " +minNote);
        }
    }
}
