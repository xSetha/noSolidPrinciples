using System;
using System.Collections.Generic;
using System.Text;

namespace noSOLIDprinciples
{
    public class CEO : Employee, IEmployee
    {
        // Here we break the liskov substitution principle cause the CEO does not have a manager
        // Through inheritance we inherit the Manager property but it is not needed
        public override void AssingManager(Manager manager)
        {
            Console.WriteLine("A CEO does not have a Manager");
        }

        public override void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm giving a review");
        }

        public override void FireSomeone() 
        {
            Console.WriteLine("You are fired.");
        }
    }
}
