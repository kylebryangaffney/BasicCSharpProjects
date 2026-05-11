using System;
using System.Collections.Generic;


namespace OperatorsSubmissionProject

{
    class Program
    {
        static void Main(string[] args)
        {
         
            // instantiate 2 employees to compare
            Employee johnColtrane = new Employee() { FirstName = "John", LastName = "Coltrane", Id = 1 };
            Employee dexterGordon = new Employee() { FirstName = "Dexter", LastName = "Gordon", Id = 1 };

            // compare the ID numbers
            CompareEmployeeId(dexterGordon, johnColtrane);

            // update one of the id numbers and compare again.
            dexterGordon.Id = 2;

            CompareEmployeeId(dexterGordon, johnColtrane);

        }

        // method to compare employees' ID numbers, use static so that we do not need to make a program instance
        static void CompareEmployeeId(Employee emp1,  Employee emp2)
        {
            emp1.PrintName();
            emp2.PrintName();
            if (emp1 == emp2)
            {

                Console.WriteLine("Both employees have the same employee Id Number");
            }
            else
            {
                Console.WriteLine("The employees have different Id Numbers");
            }
        }
    }
}