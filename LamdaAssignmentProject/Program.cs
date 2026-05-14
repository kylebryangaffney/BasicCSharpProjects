using System;
using System.Collections.Generic;


namespace LamdaAssignmentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // build out a list of all employees 
            List<Employee> employeeList = new List<Employee>
            {
                new Employee(1,  "Joe",  "Pro"),
                new Employee(2,  "Jim",  "Pro"),
                new Employee(3,  "Jane", "Go"),
                new Employee(4,  "Jane", "Doe"),
                new Employee(5,  "Joe",  "Go"),
                new Employee(6,  "Joe",  "Slow"),
                new Employee(7,  "Jim",  "Fast"),
                new Employee(8,  "Jill", "Slow"),
                new Employee(9,  "Jill", "Pro"),
                new Employee(10, "Jane", "Slow"),
            };

            // make an empty list to store the joe's in
            List<Employee> joeList = new List<Employee>();

            // iterate through the big employee list with all of the people
            foreach (Employee emp in employeeList)
            {
                // check if the employee first name meets the requirement
                if (emp.FirstName == "Joe")
                {
                    // add the appropriate employees to the joe list.
                    joeList.Add(emp);
                }
            }

            // use the Where method and provide a lambda function that checks each element of the employeeList and then assign those selected elements to a new list and return that list to the joeList
            joeList = employeeList.Where(x => x.FirstName == "Joe").ToList();

            // build a list of employees whose ID is greater than 5 with lambda
            List<Employee> newEmployeeList = employeeList.Where(x => x.Id > 5).ToList();

            // print out the joe list 
            Console.WriteLine("Joe List");
            foreach (Employee emp in joeList)
            {
                Console.WriteLine(emp.Id + ": " + emp.FirstName + " " + emp.LastName);
            }

            // print out the New employee list 
            Console.WriteLine("Higher ID employees List");
            foreach (Employee emp in newEmployeeList)
            {
                Console.WriteLine(emp.Id + ": " + emp.FirstName + " " + emp.LastName);
            }

        }


    }
}
