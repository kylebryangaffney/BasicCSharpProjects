using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaAssignmentProject
{
    public class Employee
    {
        // constructor to simplify instantiating objects
        public Employee(int userId, string userFirst, string userLast)
        {
            Id = userId;
            FirstName = userFirst;
            LastName = userLast;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
