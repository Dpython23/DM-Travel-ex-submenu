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

           

            int selection = MainMenuClass.MainMenu();
            ChoiceClass.Choice(selection);
        }
    }
}
