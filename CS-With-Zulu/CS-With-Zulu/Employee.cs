using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_With_Zulu
{
    public abstract class Employee : IPay

    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"\t{Id} - {FirstName} {LastName}, \n"+
                   $"\tBirth: {BirthDate} \n" +
                   $"\tHiring: {HiringDate} \n" +
                   $"\tIs active: {IsActive} ";
        }
    }
}
