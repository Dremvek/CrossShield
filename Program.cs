using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossShield
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DIVISIBLEBYTWO = "Cross";
            const string DIVISIBLEBYSEVEN = "Shield";
            int min = 1;
            int max = 100;
            bool shownumber = true;

            for (int x = min; x <= max; x++)
            {
                if (x % 2 == 0)
                {
                    Console.Write(DIVISIBLEBYTWO);
                    shownumber = false;
                }

                if (x % 7 == 0)
                {
                    Console.Write(DIVISIBLEBYSEVEN);
                    shownumber = false;
                }

                if (shownumber)
                {
                    Console.Write(x);
                }

                Console.Write("\n");
                shownumber = true;


            }
            Console.ReadKey();
        }
    }
}
