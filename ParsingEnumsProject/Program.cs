using System;
using System.Collections.Generic;
using System.Globalization;

namespace ParsingEnumsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user input for a day of the week
            Console.WriteLine("Please enter the current day of the week:");
            string userDay = Console.ReadLine();
            // normalize user string to title case.
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            userDay = textInfo.ToTitleCase(userDay);

            try
            {
                // attempt to parse the string into a DayOfTheWeek enum value 
                DayOfTheWeek currentDay = (DayOfTheWeek) Enum.Parse(typeof(DayOfTheWeek), userDay);
                Console.WriteLine("You entered: " + userDay);
            }
            catch (Exception ex)
            {
                // if the user provides a string that cannot become a day of the week, tell them
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
        }

        // enum for days of the week in title case
        public enum DayOfTheWeek
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
    }
}