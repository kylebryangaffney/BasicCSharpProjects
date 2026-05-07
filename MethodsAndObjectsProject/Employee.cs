using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsProject
{
    // child class inheriting from Person class with specific addition of 'int id'
    public class Employee : Person
    {
        public int Id { get; set; }
        public void PrintId()
        {
            Console.WriteLine("ID: " + Id);
        }
    }
}
