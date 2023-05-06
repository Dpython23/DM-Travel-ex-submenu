using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace DM_Assignment_8
{
    internal class Program
    {
        

       

        static void Main(string[] args)
        {
            //look up auto getset in vs

            //if edit read file and ask which one you want to edit
            //if new one create file, give an id number for jpirney, ask how many miles, and how much.
             static void CallUserDeets()
            {
                UserDeetsClass.UserDeets();
            }

            int selection = MainMenuClass.MainMenu();
            ChoiceClass.Choice(selection);
        }
    }
}
