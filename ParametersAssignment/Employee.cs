using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    // define employee class with different type for the things list
    internal class Employee<T>
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int ID { get; set; }

        // using generic to define the data type a particular instance of an employee can use in their list
        public List<T> Things;
        // constructor for instantiating an object
        public Employee(string firstName, string lastName, int id) 
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id; 
        }
        // method to iterate through the list of things, and print them out to the console
        public void PrintThings()
        {
            Console.WriteLine("All of the things possessed by " + FirstName + " " + LastName + " include: ");
            foreach (T t in Things)
            {
                Console.WriteLine(t);
            }  
            Console.WriteLine("\n");
        }
        
    }
}
