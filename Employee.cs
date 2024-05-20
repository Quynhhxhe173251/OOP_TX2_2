using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_TX2_2
{
    public class Employee : Person
    {
        private int salary;

        public Employee() { }
        public Employee(string name, string address,int salary) : base(name, address) {  this.salary = salary; }

        public int Salary
        {
            get { return this.salary; }
            set { salary = value; }
        }

        public override void display()
        {
            base.display();
            Console.WriteLine(" salary: "+salary);
        }
    }
}
