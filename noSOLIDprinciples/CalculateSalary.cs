//We break the open close principle by needing to modify this class everytime we add a new employee type.
using System.Collections.Generic;

namespace noSOLIDprinciples
{
    public class CalculateSalary
    {
        public static void Calculate(List<Employee> employees) 
        {
            foreach (Employee emp in employees) 
            {
                if (emp is Employee)
                {
                    emp.Salary = 12.50M + (emp.Rank * 2);
                }
                else if (emp is Manager)
                {
                    emp.Salary = 19.75M + (emp.Rank * 4);
                }
                else if (emp is CEO) 
                {
                    emp.Salary = 150M * emp.Rank;
                }
            }
        }
    }
}
