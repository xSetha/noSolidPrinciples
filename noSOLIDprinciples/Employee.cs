using System;
using System.Collections.Generic;
using System.Text;

namespace noSOLIDprinciples
{
    public class Employee : IEmployee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal Salary { get; set; }
        public Employee Manager { get; set; } = null;
        public int Rank { get; set; }

        public virtual void AssingManager(Manager manager)
        {
            Manager = manager;
        }

        //interface segregation principle is violated because we use a big interface for all the classes that dont need this kind of implementation
        public virtual void GeneratePerformanceReview()
        {
            Console.WriteLine("We cant give performance review");
        }

        public virtual void FireSomeone()
        {
            Console.WriteLine("We cant fire anyone");
        }
    }
}
