using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DM_Assignment_8
{
    public class TravClass
    {
        public string? destination;
        
       

        public double Trav(double miles,double cost)
        {


            double travel = miles * cost;
            return travel;
        }
        
    }
}
