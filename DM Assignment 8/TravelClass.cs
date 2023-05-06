using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Assignment_8
{
    public class TravelClass
    {
        private string destination;
        private double cost;
        private double miles;
        private int id;
        private static int previousId = 0;

        //Constructer
        public TravelClass(string destination, double cost, double miles)
        {
            this.destination = destination;
            this.cost = 0;
            id = ++previousId;
            this.miles = 0;
        }
        //getters and setters
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public int Id
        {
            get { return id; }
        }
        public double Miles
        {
            get { return miles; }
            set { miles = value; }
        }
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}
