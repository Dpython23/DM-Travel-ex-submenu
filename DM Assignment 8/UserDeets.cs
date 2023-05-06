using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DM_Assignment_8.Program;

namespace DM_Assignment_8
{
    public class UserDeetsClass
    {
        public static void UserDeets()
        {
            Console.Clear();
            Console.Write("Enter a name: ");
            Console.WriteLine();
            string name = Console.ReadLine();
            Console.Clear();
            string filename = name + ".json";
            string path = @"C:\IT\TravExApp\" + filename;
            int TryAgain;
            int TravEx;
            int View;
            bool fin = false;

            do
            {
                //if the folder doesnt exist, create it.
                if (!Directory.Exists(@"C:\IT\TravExApp"))
                {
                    Directory.CreateDirectory(@"C:\IT\TravExApp");
                }
                // Check if the file already exists
                if (File.Exists(path))
                {
                    Console.Clear();
                    Console.WriteLine($"A file with the name {filename} already exists!\n\n");
                    Console.WriteLine("Type 1 to try again");
                    Console.WriteLine("Type 2 to Main menu");
                    Console.WriteLine("Type 3 to edit");
                    Console.WriteLine();
                    TryAgain = Convert.ToInt16(Console.ReadLine());

                    switch (TryAgain)
                    {
                        case 1:
                            UserDeets();
                            break;
                        case 2:
                            MainMenuClass.MainMenu();
                            break;
                        case 3:
                            Console.WriteLine("You chose to edit" + name);
                            EditClass.Edit(name);
                            break;
                    }
                }
                else
                {
                    //creates a new instance of user
                    UserClass newUser = new UserClass(name);
                    // Creates a new file with the name entered by the user
                    Console.WriteLine("A new user has been created");
                    Console.WriteLine();
                    Console.WriteLine($"Name: {newUser.Name}");
                    Console.WriteLine($"Id: {newUser.Id}");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();


                    string jsonString = JsonConvert.SerializeObject(newUser, Formatting.Indented);

                    File.WriteAllText(path, jsonString);


                    Console.WriteLine($"File {filename} created successfully at {path}!");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Do you want to view users?");
                    Console.WriteLine();
                    Console.WriteLine("Type 1 for yes");
                    Console.WriteLine("Type 2 for no");
                    Console.WriteLine();
                    View = Convert.ToInt16(Console.ReadLine());

                    switch (View)
                    {
                        case 1:
                            Console.WriteLine("You chose to view the existing users");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            ViewUsersClass.ViewUsers(newUser);
                            break;

                        case 2:
                            Console.WriteLine("You chose not to view users");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                    }


                    Console.WriteLine("Type 1 for Travel");
                    Console.WriteLine("Type 2 for Travel and Expense");
                    Console.WriteLine("Type 3 for the Main Menu");
                    Console.WriteLine("Type 4 to edit " + name);
                    Console.WriteLine();
                    TravEx = Convert.ToInt16(Console.ReadLine());

                    switch (TravEx)
                    {
                        case 1:
                            Console.WriteLine("You chose to enter a new travel record");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            TravClass.Trav(name);
                            break;

                        case 2:
                            Console.WriteLine("You chose to enter a new travel and expense record");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            ExpenseClass.Expense(name);
                            break;

                        case 3:
                            Console.WriteLine("You chose to go to the Main Menu");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                            ChoiceClass.Choice(MainMenuClass.MainMenu());
                            break;

                        case 4:
                            Console.WriteLine("You chose to edit " + name);
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                            EditClass.Edit(name);
                            break;
                    }
                }
            }
            while (fin == true);
        }
    }
}
