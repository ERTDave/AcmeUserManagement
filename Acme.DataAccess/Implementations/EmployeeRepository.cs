using System.Collections.Generic;
using System.Linq;
using Acme.DataAccess.Interfaces;
using Acme.Models;

namespace Acme.DataAccess.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetEmployees()
        {
            using (var context = new AcmeDbContext())
            {
                return context.Employees.ToList();
            }
        }

        public IEnumerable<Employee> GetEmployees(string searchText)
        {
            using (var context = new AcmeDbContext())
            {
                return context.Employees
                    .Where(e => e.Firstname.Contains(searchText) || e.Surname.Contains(searchText) || e.WorkEmail.Contains(searchText) || e.PersonalEmail.Contains(searchText))
                    .ToList();
            }
        }

        public void Add(Employee employee)
        {
            using (var context = new AcmeDbContext())
            {
                context.Employees.Add(employee);

                context.SaveChanges();
            }
        }
    }
}
