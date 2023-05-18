using System;

public class TravelViewClass
{
	public static void TravelView()
	{

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
                Console.WriteLine("You chose to edit a travel record");
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

           
        }
    }
}
}
