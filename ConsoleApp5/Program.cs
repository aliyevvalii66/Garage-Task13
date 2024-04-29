using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main()
        {
            int choice;
            CustomCollection<Employee> employees = new CustomCollection<Employee>();

            do
            {
                Console.Write("1-Person elave edin 2-Id ile person axtarin 3-Butun personlar 0-Exit  ---> ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Adiniz : ");
                        string name = Console.ReadLine();
                        Console.Write("Soyadiniz : ");
                        string surname = Console.ReadLine();
                        Console.Write("Yashiniz : ");
                        byte age = byte.Parse(Console.ReadLine());

                        Employee employee = new Employee();
                        employee.Name = name;
                        employee.Surname = surname;
                        employee.Age = age;
                        Console.Write("Maashiniz : ");
                        double salary = double.Parse(Console.ReadLine());
                        employee.Salary = salary;

                        employees.Add(employee);
                        break;
                    case 2:

                        Console.Write("Axtarish ucun id daxil edin : ");
                        int id = int.Parse(Console.ReadLine());

                        Employee emp = employees.FindById(id);
                        if(emp != null)
                        {
                            Console.WriteLine($@"Id : {emp.Id}
Name : {emp.Name}
Surname : {emp.Surname}
Age : {emp.Age}");
                        }
                        else
                        {
                            Console.WriteLine("not found");
                        }

                        break;
                    case 3:
                        employees.GetAll();
                        break;
                    case 0:
                        Console.WriteLine("Program dayanir..............");
                        break;
                }

            } while (choice != 0);

        }
    }
}
