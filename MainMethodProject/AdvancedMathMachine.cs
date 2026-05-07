using System;
using System.Collections.Generic;

// basic class to add 5 to different data types. all of which return an int value
namespace MainMethodProject
{
    public class AdvancedMathMachine
    {
        public int AddFive(int x)
        {
            return x + 5;
        }

        public int AddFive(double x)
        {
            int y = Convert.ToInt32(x + 5);
            return y;
        }
        public int AddFive(string x)
        {
            int y = Convert.ToInt32(x);
            return y + 5;
        }


    }
}
