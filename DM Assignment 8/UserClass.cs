using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Assignment_8
{
    public  class UserClass
    {
        private string name;
        private int id;
        private static int previousId = 0;

        //Constructer
        public UserClass(string name)
        {
            this.name = name;
            id = ++previousId;
        }
        //getters and setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
        }
    }
}
