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
        public static void SubMenu()
        {
            int option;
            Console.Clear();
            Console.WriteLine("Type 1 and enter for user options");
            Console.Write("Type 2 and enter for travel options");
            Console.Write("Type 3 and enter for travel and expense optons");
            Console.Write("Type 4 and enter for main menu");
            Console.WriteLine();
            option = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
        }
    }
}
