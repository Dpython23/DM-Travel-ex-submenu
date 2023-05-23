using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Assignment_8
{
    public  class ExpensesClass
    {
        private string item;
        private double itemCost;
        private int id;
        private static int previousId = 0;

        //Constructer
        public  ExpensesClass(string item, double itemCost)
        {
            this.item = item;
            this.itemCost = 0;
            id = ++previousId;
        }
        //getters and setters
        public string Item
        {
            get { return item; }
            set { item = value; }
        }
        public double ItemCost
        {
            get { return itemCost; }
            set { itemCost = value; }
        }
        public int Id
        {
            get { return id; }
        }


    }
}
