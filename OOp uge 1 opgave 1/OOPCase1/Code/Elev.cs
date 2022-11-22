using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUge1.Code
{
    public class Elev
    {
        public int ElevId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public int Age { get; set; }

  

        public Elev(int Elevid, string firstname, string lastname, DateOnly dateofbirth)
        {

            ElevId = Elevid;

            FirstName = firstname;

            LastName = lastname;

            Age = GetAge(dateofbirth);

            DateOfBirth = dateofbirth;
            
        }
        public static int GetAge(DateOnly DateOfBirth)
        {
            DateTime today = DateTime.Today;

            var age = today.Year - DateOfBirth.Year;

            return age;
        }

    }
}
