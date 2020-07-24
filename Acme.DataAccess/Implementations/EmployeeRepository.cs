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
