
using System;


namespace ConstructorSubmissionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // const variable name
            const string planetName = "Terra";
            // var variable type.
            // In this exact instance i would use double, but if I was unsure of what data type it was because i was using a lambda or an unknown class or something, I woud use var
            var planetMass = 5.9722;
            // make a planet like earth
            Planet thirdRock = new Planet(planetName, planetMass, "Terrestrial");
            thirdRock.PrintAttributes();

            // planet object with only the string as the name of the planet
            Planet notEarth = new Planet("Jupiter");
            notEarth.PrintAttributes();
            
        }
    }


    // class with Constructor chain
    class Planet
    {
        public Planet(string planetName) : this(planetName, 0.0, "Gas Giant")
        {
        }
        public Planet(string planetName, double planetSize) : this(planetName, planetSize, "Gas Giant")
        {
        }

        public Planet(string planetName, double planetMass, string planetType)
        {
            Name = planetName;
            Mass = planetMass;
            Type = planetType;
        }

        // function to print out the planet information to the console
        public void PrintAttributes()
        {
            
            Console.WriteLine("Latin Planet Name: {0}", Name);
            Console.WriteLine("Estimated Planet Mass: {0} sextillion kilograms", Mass);
            Console.WriteLine("Planet Type: {0}", Type);
            Console.WriteLine();
        }

        public string Name { get; set; }
        public double Mass { get; set; }
        public string Type { get; set; }
    }
}
