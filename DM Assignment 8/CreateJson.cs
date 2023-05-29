using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace DM_Assignment_8
{
    public class CreateJsonClass
    {
        public static void CreateJson()
        {
            string filename;
            string path;
            filename = "Users" + ".json";
            path = @"C:\IT\TravExApp\" + filename;
           
            //creating an empty object
            JObject jsonObject = new JObject();
            // convert object to string
            string jsonString = jsonObject.ToString();

            Console.WriteLine(jsonString);

        }
    }
}
