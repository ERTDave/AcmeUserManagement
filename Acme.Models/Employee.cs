using System;

namespace Acme.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public string WorkEmail { get; set; }

        public string PersonalEmail { get; set; }

        public DateTime StartDate { get; set; }

        public override string ToString()
        {
            return $"{Id} {Firstname} {Surname}";
        }
    }
}
