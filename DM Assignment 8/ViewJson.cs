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
        public class ViewJsonClass
        {
            public static void ViewJson(string path)
            {
                try
                {
                    // Read the JSON file content
                    string jsonContent = File.ReadAllText(path);

                    // Deserialize the JSON content into a UserC object
                    UserClass? user = JsonConvert.DeserializeObject<UserClass>(jsonContent);

                    // Display the user details
                    Console.WriteLine($"Name: {user.Name}");
                    Console.WriteLine($"Id: {user.Id}");
                }
                catch (JsonReaderException ex)
                {
                    Console.WriteLine($"Error in file: {path}");
                    Console.WriteLine($"Error message: {ex.Message}");
                }

                catch (IOException ex)
                {
                    Console.WriteLine($"Error in reading file: {path}");
                    Console.WriteLine($"Error message: {ex.Message}");
                }
                catch (SystemException ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }
        }
    }


       