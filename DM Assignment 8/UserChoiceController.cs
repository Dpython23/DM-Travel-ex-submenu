﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DM_Assignment_8
{

	public class UserChoiceClass
	{
		public static void UserOpp()
		{

		int UOption = UserViewClass.User();
		int selection;


			/*public static UserChoiceClass()
			{
				StartControllerClass.StartController(selection);
			}*/
		}

		public static void  UserChoice(int UOption)
		{
			switch (UOption)
			{
				case 1:
					Console.Clear();
					Console.WriteLine("You have chosen new user");
					Console.WriteLine();
					Console.WriteLine("Press enter to continue");
					Console.ReadLine();
					Console.Clear();

					UserNewClass userNew = new UserNewClass();
					userNew.UserNew();
					UserFileClass.UserFile();

					break;
				case 2:
					Console.Clear();
					Console.WriteLine("You have chosen view users");
					Console.WriteLine();
					Console.WriteLine("Press enter to continue");
					Console.ReadLine();
					//userNew.UserView();
					break;
				case 3:
					Console.Clear();
					Console.WriteLine("You have chosen to edit user");
					Console.WriteLine();
					Console.WriteLine("Press enter to continue");
					Console.ReadLine();
					//UserEditClass userEdit = new UserEditClass();
					//userEdit.UserEdit();
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
