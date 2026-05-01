// This program is a console application to take in user data for a daily report


using System;

namespace DailyReport

{
    class Program
    {
        static void Main()
        {
            // initialize variables we will use to store user data
            string userName = "";
            string courseName = "";
            int pageNumber = 0;
            bool needsHelp = false;
            string positiveExperience = "";
            string userFeedback = "";
            int hourseStudied = 0;

            // initial user greeting printed to console
            string techAcademyGreeting = "The Tech Academy.\nStudent Daily Report.";
            Console.WriteLine(techAcademyGreeting);

            // get user data for name and course name
            Console.WriteLine("What is your name? ");
            userName = Console.ReadLine();

            Console.WriteLine("What course are you on? ");
            courseName = Console.ReadLine();

            // get the user data for the page of the course
            string strPageNumber = "";
            while (true)
            {
                Console.WriteLine("What page number? ");
                strPageNumber = Console.ReadLine();
                // verify that the user actually gave an int value, or else they are stuck in a loop until they provide valid data
                if (int.TryParse(strPageNumber, out pageNumber))
                {
                    break;
                }
                Console.WriteLine("Page number must be a valid int");
            }

            // we assume they do not need help unless they explicity provide a "true"
            Console.WriteLine("Please answer 'true' if you need help with anything? ");
            string strNeedsHelp = Console.ReadLine().ToLower();

            if (strNeedsHelp == "true")
            {
                needsHelp = true;
            }
             
            // get user data on their experience today
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics. ");
            positiveExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific. ");
            userFeedback = Console.ReadLine();

            // same type of validation for an int as in the current page of the course the user is on. 
            string strHoursStudied = "";
            while(true)
            {
                Console.WriteLine("How many hours did you study today? ");
                strHoursStudied = Console.ReadLine();
                // ensure the user enters a valid int before proceeding 
                if (int.TryParse(strHoursStudied, out hourseStudied))
                {
                    break;
                }
            Console.WriteLine("Hours studied must be a valid int value. ");

            }
            // ending of program confirming the user completed the questions
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
