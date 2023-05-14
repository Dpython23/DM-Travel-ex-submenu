using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DM_Assignment_8.Program;

namespace DM_Assignment_8
{
    public class SubMenuClass
    {
        public static int SubMenu()
        {
            int option;
            Console.Clear();
            Console.WriteLine("Type 1 and enter for user options");
            Console.WriteLine("Type 2 and enter for travel options");
            Console.WriteLine("Type 3 and enter for travel and expense optons");
            Console.WriteLine("Type 4 and enter for main menu");
            Console.WriteLine();
            option = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            //switch case to choose the rigt service
            return option;
        }
    }
}
