using System;

namespace DM_Assignment_8
{

    public class UserInfoClass
    {
        public static int UserInfo()

        {

            Console.Clear();
            Console.WriteLine("Do you want to view users?");
            Console.WriteLine();
            Console.WriteLine("Type 1 for yes");
            Console.WriteLine("Type 2 for no");
            Console.WriteLine();
            int View = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            switch (View)
            {
                case 1:
                    Console.WriteLine("You chose to view the existing users");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    UserNewClass userNewClass = new UserNewClass();
                   // userNewClass.UserView();
                    break;

                case 2:
                    Console.WriteLine("You chose not to view users");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    break;


            }
            return View;
        }
    }
}