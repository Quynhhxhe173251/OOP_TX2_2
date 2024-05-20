using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TX2_2
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listE = new List<Employee>();
            List<Customer> listC = new List<Customer>();

            int choice;

            do {
                Console.WriteLine("1.add employee");
                Console.WriteLine("2.add customer");
                Console.WriteLine("3.find max salary");
                Console.WriteLine("4.find min balance");
                Console.WriteLine("5.find employee by name");
                Console.WriteLine("6.exits!");
                Console.Write("enter your choice: ");
                

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter name: ");
                        string names = Console.ReadLine();
                        Console.WriteLine("enter address: ");
                        string address = Console.ReadLine();
                        Console.WriteLine("enter salaey: ");
                        string num = Console.ReadLine();

                        try 
                        { 
                            if (int.TryParse(num, out int salary))
                            {
                                if (salary > 0 && !string.IsNullOrWhiteSpace(names) && !string.IsNullOrWhiteSpace(address))
                                {
                                    listE.Add(new Employee(names,address,salary) );
                                    Console.WriteLine("add success!");
                                }
                                else
                                {
                                    Console.WriteLine("salary must greater than zero, name and address not null!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("must input number!");
                            }
                        } catch(Exception e) { Console.WriteLine(e.ToString()); }
                        Console.WriteLine();
                        break;
                    case 2:

                        Console.WriteLine("enter name: ");
                        names = Console.ReadLine();
                        Console.WriteLine("enter address: ");
                        address = Console.ReadLine();
                        Console.WriteLine("enter balance: ");
                        num = Console.ReadLine();

                        try
                        {
                            if (int.TryParse(num, out int balance))
                            {
                                if (balance > 0 && !string.IsNullOrWhiteSpace(names) && !string.IsNullOrWhiteSpace(address))
                                {
                                    listC.Add(new Customer(names, address, balance));
                                    Console.WriteLine("add success!");
                                }
                                else
                                {
                                    Console.WriteLine("balance must greater than zero, name and address not null!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("must input number!");
                            }
                        }
                        catch (Exception e) { Console.WriteLine(e.ToString()); }
                        Console.WriteLine();
                        break;
                    case 3:
                        int sala = 0;
                        string name = "";
                        foreach(Employee e in listE)
                        {
                            if (e.Salary >= sala) 
                            { 
                                sala = e.Salary;
                                name = e.Name;
                            }
                        }
                        Console.WriteLine($"max salary is {sala} of {name}");
                        Console.WriteLine();
                        break;
                    case 4:
                        int bala=100;
                        name = "";
                        foreach (Customer e in listC)
                        {
                            
                            if (e.Balance <= bala)
                            {
                                bala = e.Balance;
                                name = e.Name;
                            }
                        }
                        Console.WriteLine($"min balace is {bala} of{name} ");
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("enter your name: ");
                        name =Console.ReadLine();
                        Employee em = listE.Find(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                        if (em != null)
                        {
                            Console.WriteLine($"found employee {name}");
                        }
                        else
                        {
                            Console.WriteLine($"not found employee {name}");
                        }
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("exiting program...");
                        break;
                    default:
                        Console.WriteLine("enter choice from 1 to 6");
                        break ;
                }

            } while (choice!=6);

        }
    }
}