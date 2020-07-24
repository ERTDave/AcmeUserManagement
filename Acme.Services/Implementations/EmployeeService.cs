using System;
using System.Collections.Generic;
using System.Linq;
using Acme.DataAccess.Implementations;
using Acme.Models;

namespace Acme.Services.Implementations
{
    public class EmployeeService
    {
        public IEnumerable<Employee> GetEmployees()
        {
            var employeeRepository = new EmployeeRepository();

            return employeeRepository.GetEmployees();
        }

        public void SeedEmployeesData()
        {
            var employeeRepository = new EmployeeRepository();

            if (employeeRepository.GetEmployees().Any())
            {
                return;
            }

            employeeRepository.Add(new Employee { Firstname = "Dave", Surname = "Smith", Email = "dave.smith@ert.com", StarDate = DateTime.Today });
            employeeRepository.Add(new Employee { Firstname = "Fred", Surname = "Browen", Email = "fred.browen@ert.com", StarDate = DateTime.Today });
            employeeRepository.Add(new Employee { Firstname = "Sarah", Surname = "Pinnock", Email = "sarah.pinnock@ert.com", StarDate = DateTime.Today });
            employeeRepository.Add(new Employee { Firstname = "Louise", Surname = "Greene", Email = "louise.greene@ert.com", StarDate = DateTime.Today });
            employeeRepository.Add(new Employee { Firstname = "Dave", Surname = "Wibble", Email = "dave.wibble@ert.com", StarDate = DateTime.Today });
        }
    }
}
