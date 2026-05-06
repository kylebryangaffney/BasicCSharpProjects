using System;


class Program
{
    static void Main()
    {
        try
        {
            // build out list of values to iterate through with the division cycle
            List<int> intList = new List<int>() { 10, 11, 35, 78, 16, 68, 87, 111, 147, 236 };
            Console.WriteLine("Please enter a number that will be used as a divisor for a series of values");
            // get the value from the user to use as the divisor
            int divisor = Convert.ToInt32(Console.ReadLine());

            // iterate through the list of ints, then divide and print results if possible
            foreach (int num in intList)
            {
                double result = num / divisor;
                Console.WriteLine(num + "/" + divisor + "=" + result);
            }
        }
        // catch when the user enters a value that cannot be turned into an int due to formatting
        catch (FormatException ex)
        {
            Console.WriteLine("There was a format exception issue with the value entered: " + ex.Message);
        }
        // catch when the user enters 0 and violates fundamental mathematical principles
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("We cannot divide something into zero parts: " + ex.Message);
        }
        // end of program
        Console.WriteLine("The program has emerged from the try/catch block and continued execution.");

    }
}