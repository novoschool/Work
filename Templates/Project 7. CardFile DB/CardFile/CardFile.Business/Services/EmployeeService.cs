using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using CardFile.DataAccess.PostgreSQL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.Business.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeDbRepository _employeeRepository;

        public EmployeeService() 
        {
            _employeeRepository = new EmployeeRepository();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public void SaveEmployee(Employee employee)
        {
            //if (employee.Id == 0)
            //{
            //    EmployeeStorage.MaxId++;
            //    employee.Id = EmployeeStorage.MaxId;
            //    _storage.Employees.Add(employee);
            //}
            //else
            //{
            //    var existingEmployee = _storage.Employees.FirstOrDefault(e => e.Id == employee.Id);
            //    if (existingEmployee == null)
            //    {
            //        throw new IndexOutOfRangeException();
            //    }

            //    existingEmployee.FirstName = employee.FirstName;
            //    existingEmployee.LastName = employee.LastName;
            //    existingEmployee.MiddleName = employee.MiddleName;
            //    existingEmployee.BirthDate = employee.BirthDate;
            //    existingEmployee.Position = employee.Position;
            //    existingEmployee.Division = employee.Division;
            //    existingEmployee.EmploymentDate = employee.EmploymentDate;
            //}
        }

        public void Delete(int employeeId)
        {
            //var existingEmployee = _storage.Employees.FirstOrDefault(e => e.Id == employeeId);
            //if (existingEmployee == null)
            //{
            //    throw new IndexOutOfRangeException();
            //}

            //_storage.Employees.Remove(existingEmployee);
        }
    }
}
