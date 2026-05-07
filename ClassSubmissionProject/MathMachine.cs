using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionProject
{
    public static class MathMachine
    {
        // user instructions
        public static string GetDescription()
        {
            string message = "This program divides an input by 2. \nThe user must provide first a whole number and then a decimal number, and both must be digits.";
            return message;
        }
        // divide user input by 2 when user provides an int
        public static void DivideByTwo(int value, out int result)
        {
            result = Convert.ToInt32(value / 2);
        }
        // divide user input by 2 when user provides a double
        public static void DivideByTwo(double value, out double result)
        {
            result = Convert.ToDouble(value / 2.0);
        }
    }
}
