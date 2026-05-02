using System;


namespace AnonymousIncomeComparison

{
    class Program
    {
        static void Main()
        {
            // initialize variables for user data
            double person1Rate = 0.0;
            double person1Hours = 0.0;
            double person1WeeklyRate = 0.0;

            double person2Rate = 0.0;
            double person2Hours = 0.0;
            double person2WeeklyRate = 0.0;


            // welcome user to program
            Console.WriteLine("Anonymous Income Comparison Program");

            // First user's block to get data
            Console.WriteLine("Please give computer to User 1");


            // get the user's hourly rate
            string strPerson1Rate = "";
            while (true)
            {
                Console.WriteLine("Person 1, please enter your Hourly rate: ");
                strPerson1Rate = Console.ReadLine();
                // verify that the user actually gave a valid double value
                if (double.TryParse(strPerson1Rate, out person1Rate))
                {
                    break;
                }
                Console.WriteLine("Rate entered must be a valid decimal value for your rate");
            }

            // get the users hours worked per week
            string strPerson1Hours = "";
            while (true)
            {
                Console.WriteLine("Person 1, please enter how many hours you work per week: ");
                strPerson1Hours = Console.ReadLine();
                // verify that the user actually gave a double value
                if (double.TryParse(strPerson1Hours, out person1Hours))
                {
                    break;
                }
                Console.WriteLine("Hours entered must be a valid decimal value for your hours per week.");
            }

            // in an attempt to be more anonomous with the user 1 data, I would actually print the annual salary here instead of at the end. But the instructions are different

            // clear the console of person 1 data
            Console.Clear();

            // Second user's block
            Console.WriteLine("Please give computer to User 2");

            // get user 2 hourly rate
            string strPerson2Rate = "";
            while (true)
            {
                Console.WriteLine("Person 2, please enter your Hourly rate: ");
                strPerson2Rate = Console.ReadLine();
                // verify that the user actually gave a valid double value
                if (double.TryParse(strPerson2Rate, out person2Rate))
                {
                    break;
                }
                Console.WriteLine("Rate entered must be a valid decimal value for your rate");
            }


            // get user 2 hours worked per week
            string strPerson2Hours = "";
            while (true)
            {
                Console.WriteLine("Person 2, please enter how many hours you work per week: ");
                strPerson2Hours = Console.ReadLine();
                // verify that the user actually gave a valid double value
                if (double.TryParse(strPerson2Hours, out person2Hours))
                {
                    break;
                }
                Console.WriteLine("Hours entered must be a valid decimal value for your hours per week.");
            }

            // clear console
            Console.Clear();

            // calculate the weekly and annual totals for the users
            person1WeeklyRate = person1Hours * person1Rate;
            person2WeeklyRate = person2Hours * person2Rate;
            double person1Annual = 52 * person1WeeklyRate;
            double person2Annual = 52 * person2WeeklyRate;

            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(person1Annual.ToString("C"));
            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(person2Annual.ToString("C"));

            Console.WriteLine("Does Person 1 make more money than Person 2? ");

            Console.WriteLine(person1Annual > person2Annual);

        }
    }
}
