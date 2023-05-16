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
        public static void User()
        { bool fin;
            int UOption;
            do
            {
                Console.Clear();
                Console.WriteLine("Type 1 and enter for new User);
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



          
           

                   
                    Console.Clear();
                    Console.WriteLine("Do you want to view users?");
                    Console.WriteLine();
                    Console.WriteLine("Type 1 for yes");
                    Console.WriteLine("Type 2 for no");
                    Console.WriteLine();
                    View = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();

                    switch (View)
                    {
                        case 1:
                            Console.WriteLine("You chose to view the existing users");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            UserNewClass.UserNewView();
                            break;

                        case 2:
                            Console.WriteLine("You chose not to view users");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }

                    Console.WriteLine("Do you want to enter travel or travel and expenses?");
                    Console.WriteLine();
                    Console.WriteLine("Type 1 for Travel");
                    Console.WriteLine("Type 2 for Travel and Expense");
                    Console.WriteLine("Type 3 for the Main Menu");
                    Console.WriteLine("Type 4 to edit " + name);
                    Console.WriteLine();
                    TravEx = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();

                    switch (TravEx)
                    {
                        case 1:
                            Console.WriteLine("You chose to enter a new travel record");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Were did you go?");
                            Console.WriteLine();
                            //destination = Convert.ToInt16(Console.ReadLine());
                            //TravClass.Trav(name);
                            break;

                        case 2:
                            Console.WriteLine("You chose to enter a new travel and expense record");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                           // ExpenseClass.Expense(name);
                            break;

                        case 3:
                            Console.WriteLine("You chose to go to the Main Menu");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                            StartViewClass.StartView();
                            break;

                        case 4:
                            Console.WriteLine("You chose to edit " + name);
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                           // EditClass.Edit(name);
                            break;
                    }
                }
            }
            while (fin == true);
        }
    }
}
