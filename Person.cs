using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TX2_2
{
    public class Person
    {
        private string name;
        private string address;

        public Person() { }
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public virtual void display()
        {
            Console.WriteLine( "name :" + name + " address: " + address);
        }
    }
}
