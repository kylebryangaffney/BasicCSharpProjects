using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassProject
{
    public class Employee : Person, IQuittable
    {
        // adding on an Id attribute for an employee class
        public int Id { get; set; }

        // overriding the abstract method with employee specific implimentation of SayName
        public override void SayName()
        {
            Console.WriteLine("ID: " + Id +"\nName: " + FirstName + " " + LastName);  
        }

        // implelment the IQuittable interface method
        public void Quit()
        {
            // print off the employee's information then tell the world they quit
            Console.WriteLine("Effective immediately");
            SayName();
            Console.WriteLine("Officially quits their job");
        }
    }
}
