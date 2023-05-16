using System;

public class UserFileClass
{
    string filename = name + ".json";
    string path = @"C:\IT\TravExApp\" + filename;


    public UserFile()
	{
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
                Console.WriteLine("Type 1 and enter to try again");
                Console.WriteLine("Type 2 and enter for Main menu");
                Console.WriteLine("Type 3 and enter for edit");
                Console.WriteLine();
                TryAgain = Convert.ToInt16(Console.ReadLine());
                StartControllerClass startController = new StartControllerClass();
                StartViewClass startView = new StartViewClass();
                int selection = StartViewClass.StartView();

                switch (TryAgain)
                {
                    case 1:
                        User();
                        break;
                    case 2:
                        startController.StartController(selection);
                        break;
                    case 3:
                        Console.WriteLine("You chose to edit" + name);
                        //EditClass.Edit(name); //write Edit class
                        break;
                }
            }
            else
            {
                string jsonString = JsonConvert.SerializeObject(newUser, Formatting.Indented);
                File.WriteAllText(path, jsonString);

                Console.WriteLine($"File {filename} created successfully at {path}!");
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();


            }
}
