using System.Xml.Serialization;

namespace DM_Assignment_8
{
    internal class Program
    {
        static int MainMenu()
        {
            int selection;
            bool fin = false;
            do
            { 
                Console.WriteLine("---------- Main Menu ------------------");
                Console.WriteLine("-                                     -");
                Console.WriteLine("-  Welcome to the Travel Expences App -");
                Console.WriteLine("-                                     -");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Please make your selection");
                Console.WriteLine("1: Start ");
                Console.WriteLine("2: Exit App");

                selection = Convert.ToInt16(Console.ReadLine());

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
            }
            while (fin == true);
            return selection;
        }
        static void Choice(int selection)
        {
            switch (selection)
            {
                case 1:
                    TravelExpense();
                    break;
                case 2:
                    Console.WriteLine("Goodbye. Press any key to close");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
        }

        static void TravelExpense()
        {
            int travEx;

            Console.Clear();
            Console.WriteLine("Please make your selection");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("1: Travel amd expenses");
            Console.WriteLine("2: Travel only");

            travEx = Convert.ToInt16(Console.ReadLine());
        }

         public class User
        {
            private string;
            private int JourneyNumber { get; set; };
            private int JourneyMiles { get; set; };
            private int CostPerMile { get; set; };

            


        }

        static void Main(string[] args)
        {
            //ask whats your name, if name exist ask edit or new journey
            //user is a class
            //expense is a class has an id
            //journey is a classhas an id
            //save a file with the name of the user
            //look up auto getset in vs
            //look up gerating a new person from class 
            //after asking for name ask if you want to edit or create a new one
            //if edit read file and ask which one you want to edit
            //if new one create file, give an id number for jpirney, ask how many miles, and how much.


            int selection = MainMenu();
            Choice(selection);
        }
    }
}