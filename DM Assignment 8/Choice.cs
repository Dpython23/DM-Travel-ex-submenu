using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DM_Assignment_8
{
    public class ChoiceClass
    {
        public static void Choice(int selection)
        {
            switch (selection)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("You have chosen to enter details");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.Clear();
                    SubMenuClass.SubMenu();
                   // UserDeetsClass.UserDeets();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Goodbye. Press any key to close");
                    Console.WriteLine();
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
