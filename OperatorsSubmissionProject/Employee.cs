using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionProject
{
    internal class Employee
    {
        // basic information for employee
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        // simple method to print out the attributes of an employee
        public void PrintName()
        {
            Console.WriteLine("Employee: " + Id);
            Console.WriteLine(LastName + ", " + FirstName);
        }

        // override the equality operator to check if the employee's ID numbers are equal.
        // Must return bool because equality comparison operator returns bool
        public static bool operator == (Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {

            return emp1.Id == emp2.Id;
        }
    }
}
