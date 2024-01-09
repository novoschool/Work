using CardFile.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.Business.Services
{
    public class EmployeeService
    {
        private readonly EmployeeStorage _storage = new EmployeeStorage();

        public EmployeeService() 
        {
            InitializeStorage();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _storage.Employees;
        }

        private void InitializeStorage()
        {
            _storage.Employees.Add(new Employee
            {
                Id = 1,
                Stamp = "Nissan",
                CarModel = "X-trail",
                GosNumber = "A435AC",
                BirthDate = new DateTime(2005, 11, 11),
                Mileage = 240000,
                Price = 500000,
                DateOfLastUse = new DateTime(2019, 7, 15),
            });

            EmployeeStorage.MaxId = _storage.Employees.Max(e => e.Id);
        }

        public void SaveEmployee(Employee employee)
        {
            if (employee.Id == 0)
            {
                EmployeeStorage.MaxId++;
                employee.Id = EmployeeStorage.MaxId;
                _storage.Employees.Add(employee);
            }
            else
            {
                var existingEmployee = _storage.Employees.FirstOrDefault(e => e.Id == employee.Id);
                if (existingEmployee == null)
                {
                    throw new IndexOutOfRangeException();
                }

                existingEmployee.Stamp = employee.Stamp;
                existingEmployee.GosNumber = employee.GosNumber;
                existingEmployee.CarModel = employee.CarModel;
                existingEmployee.BirthDate = employee.BirthDate;
                existingEmployee.Mileage = employee.Mileage;
                existingEmployee.Price = employee.Price;
                existingEmployee.DateOfLastUse = employee.DateOfLastUse;
            }
        }
    }
}
