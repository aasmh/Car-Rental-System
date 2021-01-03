using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    class Vehicle
    {
        int pri_passengers; // number of passengers    
        int pri_fuelcap;    // fuel capacity in Liters   
        int pri_Kml;        // fuel consumption in Km per Liters   

        public Vehicle() 
        {
        
        }
        public Vehicle(int p, int f, int m)
        {
            passengers = p;
            fuelcap = f;
            mpg = m;
        }

        // Return the range.   
        public int range()
        {
            return mpg * fuelcap;
        }

        // Compute fuel needed for a given distance.  
        public double fuelneeded(int miles)
        {
            return (double)miles / mpg;
        }

        // Properties 
        public int passengers
        {
            get { return pri_passengers; }
            set { pri_passengers = value; }
        }

        public int fuelcap
        {
            get { return pri_fuelcap; }
            set { pri_fuelcap = value; }
        }

        public int mpg
        {
            get { return pri_Kml; }
            set { pri_Kml = value; }
        }
    }
}

