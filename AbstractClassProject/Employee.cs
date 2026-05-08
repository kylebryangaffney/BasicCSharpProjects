using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassProject
{
    public class Employee : Person
    {
        // adding on an Id attribute for an employee class
        public int Id { get; set; }

        // overriding the abstract method with employee specific implimentation of SayName
        public override void SayName()
        {
            Console.WriteLine("ID: " + Id +"\nName: " + FirstName + " " + LastName + "\n");  
        }
    }
}
