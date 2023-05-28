using System;

namespace DM_Assignment_8
{

	public class UserChoiceClass
	{
		public static void UserOpp()
		{
			int UOption = UserViewClass.User();
			UserChoiceClass.UserChoice(UOption);
		}

		public static void  UserChoice(int UOption)
		{
            UserNewClass userNew = new UserNewClass();

            switch (UOption)
			{
				case 1:
					Console.Clear();
					Console.WriteLine("You have chosen new user");
					Console.WriteLine();
					Console.WriteLine("Press enter to continue");
					Console.ReadLine();
					Console.Clear();
					string name = userNew.UserNew();
					UserFileClass.UserFile(name);

					break;
				case 2:
					Console.Clear();
					Console.WriteLine("You have chosen view users");
					Console.WriteLine();
					Console.WriteLine("Press enter to continue");
					Console.ReadLine();
                    userNew.UserView();
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
				default:
					Console.WriteLine("Nah mate");
					Console.ReadLine();
					break;
			}
		}
	}
}
