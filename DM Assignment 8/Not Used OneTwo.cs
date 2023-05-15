using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Assignment_8
{
    public class OneTwoClass
    {
        public static bool OneTwo(int selection)
        {
            bool fin = false;

            if (selection > 2 || selection < 1)
            {
                Console.Clear();
                Console.WriteLine("Please choose 1 or 2");
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
                fin = true;
            }
            else
            {
                fin = false;
            }
            return fin;
        }
    }
}
