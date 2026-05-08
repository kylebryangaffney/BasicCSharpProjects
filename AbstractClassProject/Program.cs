using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassProject
{
    class Program
    {

        static void Main(string[] args)
        {
            // instantiate a person as the abstract class for science.
            // It seems like in a case like this using Employee would be more readable.
            // but if down the line we need a list of people objects, this might make more sense
            Person sampleStudent = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1 };
            // call the method to print out the Person's name and ID number
            sampleStudent.SayName();

        }
    }
}
