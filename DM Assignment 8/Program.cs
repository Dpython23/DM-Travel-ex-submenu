using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DM_Assignment_8
{
//################# Methods Start ##########################
    internal class Program
    {
        //int selection;

       
        static int MainMenu()
        {
            bool fin;
            int selection;
            do
            {
                Console.WriteLine("---------- Main Menu ------------------");
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

                selection = Convert.ToInt16(Console.ReadLine());

                 fin = OneTwo(selection);
            }
            while(fin == true);
            return selection;
        }
        
        static void Choice(int selection)
        {
            switch (selection)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("You have chosen to enter details");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    UserDeets();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Goodbye. Press any key to close");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
        }

        static void UserDeets()
        {
            Console.Clear();
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            Console.Clear();
            string filename = name + ".txt";
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

                    TryAgain = Convert.ToInt16(Console.ReadLine());

                    switch (TryAgain)
                    {
                        case 1:
                            UserDeets();
                            break;
                        case 2:
                            MainMenu();
                            break;
                        case 3:
                            Console.WriteLine("You chose to edit" + name);
                            Edit(name);
                            break;
                    }
                }

                else
                {
                    //creates a new instance of user
                    UserC newUser = new UserC(name);
                    // Creates a new file with the name entered by the user
                    Console.WriteLine("A new user has been created");
                    Console.WriteLine();
                    Console.WriteLine($"Name: {newUser.Name}");
                    Console.WriteLine($"Id: {newUser.Id}");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();


                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("This is a new file created by the program.");
                    }

                    Console.WriteLine($"File {filename} created successfully at {path}!");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Do you want to view users?");
                    Console.WriteLine();
                    Console.WriteLine("Type 1 for yes");
                    Console.WriteLine("Type 2 for no");
                    View = Convert.ToInt16(Console.ReadLine());

                    switch (View)
                    {
                        case 1:
                            Console.WriteLine("You chose to view the existing users");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            ViewUsers(newUser);
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
                    TravEx = Convert.ToInt16(Console.ReadLine());

                    switch (TravEx)
                    {
                        case 1:
                            Console.WriteLine("You chose to enter a new travel record");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Trav(name);
                            break;

                        case 2:
                            Console.WriteLine("You chose to enter a new travel and expense record");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Expense(name);
                            break;

                        case 3:
                            Console.WriteLine("You chose to go to the Main Menu");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                            MainMenu();
                            Edit(name);
                            break;

                        case 4:
                            Console.WriteLine("You chose to edit " + name);
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                            Edit(name);
                            break;
                    }
                }
            }
            while (fin == true);
        }

        static void Edit(string name)
        {

        }

        static void name(string name)
        {
            //class where the name is born
        }

        static void Trav(string name)
        {
            //Method that calculates travel
        }

        static void Expense(string name)
        {
            //class where the name is born
        }
        static bool OneTwo(int selection)
        {
            bool fin = false;

            if (selection > 2 || selection < 1)
            {
                Console.Clear();
                Console.WriteLine("Please choose 1 or 2");
                Console.WriteLine(" Press enter to continue");
                Console.ReadLine();
                Console.Clear();
                fin = true;
            }
            else
            {
                fin = false;
            }
            return fin;
        }
        // didsplay all users
       static void ViewUsers(UserC newUser)
        {

            Console.WriteLine("List of users:");
            Console.WriteLine();
            string path = @"C:\IT\TravExApp";
            string[] fileEntries = Directory.GetFiles(path);

            foreach (string fileName in fileEntries)
            {
                string[] parts = fileName.Split('\\');
                string name = parts[parts.Length - 1].Replace(".txt", "");
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();

        }
        //##################### Methods End ####################################

        //##################### Classes Start ##################################
        public class UserC
        {
            private string name;
            private int id;
            private static int previousId = 0;

            //Constructer
            public UserC(string name)
            {
                this.name = name;
                id = ++previousId;
            }
            //getters and setters
            public string Name
            { 
                get { return name; }
                set { name = value; }   
            }
            public int Id
            {
                get { return id; }
            }
        }

        public class TravelC
        {
            private string destination;
            private double cost;
            private double miles;
            private int id;
            private static int previousId = 0;

            //Constructer
            public TravelC(string destination, double cost, double miles)
            {
                this.destination = destination;
                this.cost = 0;
                id = ++previousId;
                this.miles = 0;
            }
            //getters and setters
            public string Destination
            {
                get { return destination; }
                set { destination = value; }
            }
            public int Id
            {
                get { return id; }
            }
            public double Miles
            {
                get { return miles; }
                set { miles = value; }
            }
            public double Cost
            {
                get { return cost; }
                set { cost = value; }
            }
        }

        public class ExpensesC 
        {
            private string item;
            private double itemCost;
            private int id;
            private static int previousId = 0;

            //Constructer
            public ExpensesC(string item, double itemCost)
            {
                this.item = item;
                this.itemCost = 0;
                id = ++previousId;
            }
            //getters and setters
            public string Item
            {
                get { return item; }
                set { item = value; }
            }
            public double ItemCost
            {
                get { return itemCost; }
                set { itemCost = value; }
            }
            public int Id
            {
                get { return id; }
            }
        }
//################## Classes End ###################################
        
//################## Main Start  ###################################
        static void Main(string[] args)
        {
            //look up auto getset in vs
            
            //if edit read file and ask which one you want to edit
            //if new one create file, give an id number for jpirney, ask how many miles, and how much.

            int selection = MainMenu();
            Choice(selection);
        }
    }
}
//################## Main End  ###################################