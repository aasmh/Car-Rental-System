using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    class Renter: Person
    {

        private double yield; 

        public Renter()
        {

        }
        public Renter(string name, int age, string address, int yield):base(name,age, address)
        {
            this.yield = yield;
        }
        public double getYield()
        {
            return this.yield;
        }
        public void setYield(double yield)
        {
            this.yield = yield;
        }

        public double calcProfit()
        {
            return this.yield * 0.7;
        }
    }
}


