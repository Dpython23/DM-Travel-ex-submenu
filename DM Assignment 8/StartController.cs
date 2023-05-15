using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace DM_Assignment_8
{
    public class StartControllerClass
    {
        public void StartController(int selection)
        {
            
            switch (selection)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("You have chosen to enter details");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.Clear();
                    SubMenuViewClass subMenuView = new SubMenuViewClass();
                    int option = subMenuView.SubMenu();
                    SMControllerClass sMController = new SMControllerClass();
                    sMController.SMController(option);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Goodbye. Press any key to close");
                    Console.WriteLine();
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }

            
        }
    }
}
