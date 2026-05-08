using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassProject
{
    // abstract class of Person blueprint
    public abstract class Person
    {
        // public attributes
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // abstract method that we will implimnet differently with other child classes
        public abstract void SayName();
    }
}
