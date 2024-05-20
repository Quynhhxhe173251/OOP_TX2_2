using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_TX2_2
{
    public class Customer : Person
    {
        private int balance;

        public Customer() { }
        public Customer(string name, string addess,int balance) : base(name,addess) 
        {
            this.balance = balance;
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public override void display()
        {
            base.display();
            Console.WriteLine(" balance: "+balance);
        }
    }
}
