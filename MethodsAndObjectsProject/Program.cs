
using System;
using System.Collections.Generic;


namespace MethodsAndObjectsProject
{
    class Program
    {

        static void Main(string[] args)
        {
            // create an employee instance
            Employee sampleStudent = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1 };
            // call methods to display information about the object
            sampleStudent.SayName();
            sampleStudent.PrintId();
        }
    }
}