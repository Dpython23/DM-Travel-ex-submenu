﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DM_Assignment_8.Program;

namespace DM_Assignment_8
{
    public class ViewUsersClass
    {
        public static void ViewUsers(UserClass newUser)
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
