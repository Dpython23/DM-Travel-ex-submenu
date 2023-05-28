using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DM_Assignment_8
{

    public class UserNewClass
    {

        public string UserNew()
        {
            Console.Write("Enter a name: ");
            Console.WriteLine();
            string? name = Console.ReadLine();
            Console.Clear();
            UserClass? newUser = new UserClass(name);
            //if the name does exist
            if (name != null)
            {
                Console.WriteLine("Name already exist try again");
                Console.ReadLine();
                Console.Clear();
                UserNew();
            }
            // Check if the file already exists
            if (name == null)
            {
                Console.WriteLine("A new user has been created");
                Console.WriteLine();
                Console.WriteLine($"Name: {newUser.Name}");
                Console.WriteLine($"Id: {newUser.Id}");
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            
               
                return name;
        }

        public void UserView()
        {
            Console.WriteLine("List of users:");
            Console.WriteLine();
            string path = @"C:\IT\TravExApp";
            string[] fileEntries = Directory.GetFiles(path);

            foreach (string fileName in fileEntries)
            {
                string[] parts = fileName.Split('\\');
                string name = parts[parts.Length - 1].Replace(".json", "");
                Console.WriteLine(name);
                ViewJsonClass.ViewJson(fileName);
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();

        }
    }
}