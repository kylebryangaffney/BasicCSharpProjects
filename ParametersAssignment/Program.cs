
using System;
using System.Collections.Generic;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // making a string based employee and setting the list of elements in the Things list
            Employee<string> stringEmployee = new Employee<string>("John", "Coltrane", 1)
            {
                Things = new List<string> { "saxophone", "sheet music", "body", "and soul" }
            };

            // instantiating an int employee and setting the list of int elements in the things list
            Employee<int> intEmployee = new Employee<int>("Dexter", "Gordon", 2)
            {
                Things = new List<int> { 6, 12, 18, 24 }
            };

            // call employee method to display Things list from both employee
            stringEmployee.PrintThings();
            intEmployee.PrintThings();
        }

    }
}
