using System;

namespace Acme.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public DateTime StarDate { get; set; }

        public override string ToString()
        {
            return $"{Id} {Firstname} {Surname}";
        }
    }
}
