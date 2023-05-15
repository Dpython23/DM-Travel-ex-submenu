using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DM_Assignment_8.Program;

namespace DM_Assignment_8
{
    public class UserViewClass
    {
        public static void User()
        {
            Console.Clear();
            Console.Write("Enter a name: ");
            Console.WriteLine();
            string? name = Console.ReadLine();
            Console.Clear();
            string filename = name + ".json";
            string path = @"C:\IT\TravExApp\" + filename;
            int TryAgain;
            int TravEx;
            int View;
            bool fin = false;
            //string destination;

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
                    Console.WriteLine("Type 1 and enter to try again");
                    Console.WriteLine("Type 2 and enter for Main menu");
                    Console.WriteLine("Type 3 and enter for edit");
                    Console.WriteLine();
                    TryAgain = Convert.ToInt16(Console.ReadLine());
                    StartControllerClass startController = new StartControllerClass();
                    StartViewClass startView = new StartViewClass();
                    int selection = StartViewClass.StartView();

                    switch (TryAgain)
                    {
                        case 1:
                            User();
                            break;
                        case 2:
                            startController.StartController(selection);
                            break;
                        case 3:
                            Console.WriteLine("You chose to edit" + name);
                            //EditClass.Edit(name); //write Edit class
                            break;
                    }
                }
                else
                {
                    //creates a new instance of user
                    UserClass? newUser = new UserClass(name);
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
                    Console.Clear();

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
