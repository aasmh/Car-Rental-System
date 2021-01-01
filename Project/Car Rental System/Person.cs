using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    public abstract class Person
    {
        string name;
        int age;
        static int id;
        int myId;
        string address;

            public Person() { }

        public Person(string name, int age, string address)
        {
            this.name=name;
            this.age = age;
            this.address = address;
            Person.id++;
            this.myId = Person.id;

        }

        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            if (name != "")
                this.name = name;
        }
        public int getAge()
        {
            return this.age;
        }

        public void setAge(int age)
        {
            if (age > 0)
                this.age = age;
        }

        public int getId()
        {
            return this.myId;
        }

        public string getAddress()
        {
            return this.address;
        }

        public void setAddress(string address)
        {
            if (address != "")
                this.address = address;
        }

    }
}
