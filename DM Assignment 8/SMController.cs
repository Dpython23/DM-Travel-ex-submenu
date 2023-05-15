using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DM_Assignment_8
{

	public class SMControllerClass
	{
        StartViewClass startView = new StartViewClass();
        int selection = StartViewClass.StartView();

        StartControllerClass startController = new StartControllerClass();
        startController.StartController(selection);
		public  void SMController(int option)
		{
            switch (option)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("You have chosen user options");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    UserViewClass.User();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("You have chosen travel optons");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    TravelViewClass.TravelView();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("You have chosen travel and expense optons");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    ExpenseViewClass.ExpenseView();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("You have chosen the main menu");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Console.Clear();
                    StartViewClass.StartView();
                    break;
            }
        }

        }
	}
