using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Assignment_8
{
    public class StartViewClass
    {
        public static int Start()
        {
            bool fin;
            int selection;
            do
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("-                                     -");
                Console.WriteLine("-  Welcome to the Travel Expences App -");
                Console.WriteLine("-                                     -");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("         Press Enter to contiue        ");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Please make your selection");
                Console.WriteLine();
                Console.WriteLine("Type 1 for Start ");
                Console.WriteLine("Type 2 for Exit App");
                Console.WriteLine();

                selection = Convert.ToInt16(Console.ReadLine());

                fin = OneTwoClass.OneTwo(selection);

                // sort out error  hadling for non numerals
            }
            while (fin == true);
            return selection;
        }
    }
}
