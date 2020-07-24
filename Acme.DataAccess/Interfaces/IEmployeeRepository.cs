using System.Collections.Generic;
using Acme.Models;

namespace Acme.DataAccess.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        void Add(Employee employee);
    }
}