using System;
using System.Collections.Generic;
using System.Text;

namespace noSOLIDprinciples
{
    public class Manager : Employee, IEmployee
    {

        public override void GeneratePerformanceReview() 
        {
            Console.WriteLine("Performance reported simulation.");
        }

        public override void FireSomeone()
        {
            Console.WriteLine("You are fired.");
        }
    }
}
