using System;
using System.Collections.Generic;

//we break the single responsible principle by having a lot of logic in main and using few classes that have more than one responsability
namespace noSOLIDprinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            //We break the dependency inversion by instantiating low level objects directly in the main
            //Then when we need to instantiate new objects we will have to instantiate them all over the place creating lots of dependecies
            Employee manager1 = new Manager { FirstName = "Cristutiu", LastName = "Madalin", Rank = 4, Salary = 19.57M };
            Employee emp1 = new Employee { FirstName = "Tira", LastName = "Marius", Rank = 2, Salary = 12.50M, Manager = manager1 };
            Employee CEO = new CEO { FirstName = "Ilies", LastName = "Sebastian", Rank = 4, Salary = 150M };

            List<Employee> employees = new List<Employee>();
            employees.Add(manager1);
            employees.Add(emp1);
            employees.Add(CEO);

            foreach (Employee emp in employees) 
            {
                Console.WriteLine("Here is a list of employees: ");
                Console.WriteLine($"Last Name: {emp.LastName}, First Name: {emp.FirstName}");
            }

            CalculateSalary.Calculate(employees);

            foreach (Employee emp in employees)
            {
                Console.WriteLine("Here is a list of employees and their salaries: ");
                Console.WriteLine($"Last Name: {emp.LastName}, First Name: {emp.FirstName}, and the salary is {emp.Salary}");
            }
        }
    }
}
