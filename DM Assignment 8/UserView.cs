using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static DM_Assignment_8.Program;

namespace DM_Assignment_8
{
    public class UserViewClass
    {
        public void User()
        {
            bool fin;
            int UOption;
            do
            {
                Console.Clear();
                Console.WriteLine("Type 1 and enter for new User");
                Console.WriteLine("Type 2 and enter for view user");
                Console.WriteLine("Type 3 and enter for edit user");
                Console.WriteLine("Type 4 and enter for main menu");
                Console.WriteLine();
                UOption = Convert.ToInt16(Console.ReadLine());
                Console.Clear();

                if (selection == 1 || selection == 2 || selection == 3 || selection == 4)
                {
                    fin = false;
                }
                else
                {
                    Console.WriteLine("Please type 1 to 4 with enter only");
                    Console.ReadLine();
                    fin = true;
                }
            }
            while (fin == true);

            return UOption;
            Console.Clear();
        }



    }

}
