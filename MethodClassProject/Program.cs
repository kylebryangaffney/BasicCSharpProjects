using MethodClassProject;
using System;
using System.Collections.Generic;


namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();

            int firstValue = 15;
            int secondValue = 16;

            // update firstValue to 16, and print out the second value
            helper.AddShow(ref firstValue, secondValue);

            // further update firstValue to 17, and then print out the second value again
            helper.AddShow(x: ref firstValue, y: secondValue);
   
        }

    }
}