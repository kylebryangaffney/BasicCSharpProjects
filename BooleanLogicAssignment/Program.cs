using System;


namespace BooleanLogicAssignment

{
    class Program
    {
        static void Main()
        {
            int userAge = 0;
            bool hasDUI = false;
            int userTrafficTickets = 0;
            bool isQualified = false;

            // welcome user
            Console.WriteLine("Car Insurance Approval");


            // loop to run while getting the user's age
            while (true)
            {
                Console.WriteLine("Please enter your age: ");
                string strUserAge = Console.ReadLine();
                // try catch block from the documentation on Convert.ToInt32
                try
                {
                    userAge = Convert.ToInt32(strUserAge);
                    // check if the user entered a negative number
                    if (userAge < 1)
                    {
                        Console.WriteLine("Age must be positive");
                        continue;
                    }
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Age must be an int value, {0} is outside the range of the Int32 type.", strUserAge);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Age must be an int value, the {0} value '{1}' is not in a recognizable format.",
                                      strUserAge.GetType().Name, strUserAge);
                }
            }

            
            // loop to get data on user's DUI convictions
            while (true)
            {
                Console.WriteLine("Have you ever been convicted of a DUI ('yes' or 'no'): ");
                string strHasDUI = Console.ReadLine().ToLower();
                if (strHasDUI == "yes")
                {
                    hasDUI = true;
                    break;
                }
                else if (strHasDUI == "no") 
                {
                    hasDUI= false;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter 'yes' or 'no' to the prompt. ");
                }
                    
            }


            // loop to get the amount of speeding ticket convictions from the user
            while (true)
            {
                Console.WriteLine("How many speeding tickets have you been convicted of? ");
                string strUserTickets = Console.ReadLine();
                try
                {
                    userTrafficTickets = Convert.ToInt32(strUserTickets);
                    // check if the user entered a negative number
                    if (userTrafficTickets < 1)
                    {
                        Console.WriteLine("Traffic ticket amount must be positive");
                        continue;
                    }
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Tickets must be an whole number , {0} is outside the range of the Int32 type.", strUserTickets);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Tickets must be an whole number, the {0} value '{1}' is not in a recognizable format.",
                                      strUserTickets.GetType().Name, strUserTickets);
                }
            }

            // determine if the user qualifies for car insurance
            if (userAge > 15 && !hasDUI && userTrafficTickets < 4)
            {
                isQualified = true;
            }
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);
        }
    }
}

