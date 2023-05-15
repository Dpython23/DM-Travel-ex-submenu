using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Assignment_8
{
    public class StartViewClass
    {
        public  int  StartView()
        {
            bool fin;
            int selection;
            Console.Clear();
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

                if (selection == 1 || selection == 2)
                {
                    fin = false;
                }
                else
                {
                    Console.WriteLine("Please type 1 or 2 with enter nly");
                    Console.ReadLine();
                    fin = true;
                }
                // sort out error  hadling for non numerals
            }
            while (fin == true);



            return selection;
            
        }
    }
}
