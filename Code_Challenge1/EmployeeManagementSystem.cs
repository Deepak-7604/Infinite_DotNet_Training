using System;
using System.Collections.Generic;

namespace Code_Challenge1
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public string Department;
        public double Salary;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            int choice = 0;

            while (choice != 6)
            {
                Console.WriteLine("\n======= Employee Menu =======");
                Console.WriteLine("1 Add New Employee");
                Console.WriteLine("2 View all Employee");
                Console.WriteLine("3 Search Employee By ID");
                Console.WriteLine("4 Update Employee By details");
                Console.WriteLine("5 Delete Employee By ID");
                Console.WriteLine("6 Exit");
                Console.WriteLine("=============================");
                Console.Write("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Employee e = new Employee();

                    Console.Write("Enter Employee Id: ");
                    e.Id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Employee Name: ");
                    e.Name = Console.ReadLine();

                    Console.Write("Enter Dept: ");
                    e.Department = Console.ReadLine();

                    Console.Write("Enter Salary: ");
                    e.Salary = Convert.ToDouble(Console.ReadLine());

                    empList.Add(e);
                    Console.WriteLine("Added Succesfully");
                }
                else if (choice == 2)
                {
                    if (empList.Count == 0)
                    {
                        Console.WriteLine("No data found");
                    }
                    else
                    {
                        for (int i = 0; i < empList.Count; i++)
                        {
                            Console.WriteLine(empList[i].Id + " " +
                                              empList[i].Name + " " +
                                              empList[i].Department + " " +
                                              empList[i].Salary);
                        }
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("Enter Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    bool found = false;

                    for (int i = 0; i < empList.Count; i++)
                    {
                        if (empList[i].Id == id)
                        {
                            Console.WriteLine(empList[i].Id + " " +
                                              empList[i].Name + " " +
                                              empList[i].Department + " " +
                                              empList[i].Salary);
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Not found");
                    }
                }
                else if (choice == 4)
                {
                    Console.Write("Enter Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    bool found = false;

                    for (int i = 0; i < empList.Count; i++)
                    {
                        if (empList[i].Id == id)
                        {
                            Console.Write("New Name: ");
                            empList[i].Name = Console.ReadLine();

                            Console.Write("New Dept: ");
                            empList[i].Department = Console.ReadLine();

                            Console.Write("New Salary: ");
                            empList[i].Salary = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Updated Succesfully");
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Not found");
                    }
                }
                else if (choice == 5)
                {
                    Console.Write("Enter Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    bool found = false;

                    for (int i = 0; i < empList.Count; i++)
                    {
                        if (empList[i].Id == id)
                        {
                            empList.RemoveAt(i);
                            Console.WriteLine("Deleted sucessfully");
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Not found");
                    }
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Thanks for visiting Our Employes management System");
                }
                else
                {
                    Console.WriteLine("Wrong choice");
                }
            }
        }
    }
}