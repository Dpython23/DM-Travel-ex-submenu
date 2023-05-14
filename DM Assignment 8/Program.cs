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

            int selection = StartClass.Start();
            ChoiceClass.Choice(selection);
            SMControllerClass.SMController(option);
        }
    }
}
