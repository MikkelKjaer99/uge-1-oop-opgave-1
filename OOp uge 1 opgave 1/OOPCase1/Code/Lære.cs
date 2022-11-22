using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace OOPUge1.Code
{
    public class Lære
    {
        public string Department { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public int Age { get; set; }

     
        public Lære(string department, string firstname, string lastname, DateOnly dateofbirth)
        {
            Department = department;

            FirstName = firstname;

            LastName = lastname;

            DateOfBirth = dateofbirth;

            Age = GetAge(dateofbirth);
        }
        public static int GetAge(DateOnly DateOfBirth)
        {
            DateTime today = DateTime.Today;

            var Age = today.Year - DateOfBirth.Year;

            return Age;

        }
    }
}
