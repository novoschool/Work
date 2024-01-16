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
                Name = "Новосибирский Приборостроительный",
                ManufacturedProduction = "Компасы",
                ValueOutputProduction = 10,
                //LastName = "Захаров",
                CreationDate = new DateTime(1985, 11, 8),
                RenovationNeed = 20,
                EmployeesNumber = 1057,
                LastRenovationDate = new DateTime(2019, 7, 15),
            });
            _storage.Employees.Add(new Employee
            {
                Id = 2,
                Name = "Новосибирский Приборостроительный",
                ManufacturedProduction = "Компасы",
                ValueOutputProduction = 20,
                //LastName = "Захаров",
                CreationDate = new DateTime(1985, 11, 8),
                RenovationNeed = 20,
                EmployeesNumber = 1057,
                LastRenovationDate = new DateTime(2019, 7, 15),
            });
            _storage.Employees.Add(new Employee
            {
                Id = 3,
                Name = "Новосибирский Приборостроительный",
                ManufacturedProduction = "Компасы",
                ValueOutputProduction = 30,
                //LastName = "Захаров",
                CreationDate = new DateTime(1985, 11, 8),
                RenovationNeed = 20,
                EmployeesNumber = 1057,
                LastRenovationDate = new DateTime(2019, 7, 15),
            });
            _storage.Employees.Add(new Employee
            {
                Id = 4,
                Name = "Новосибирский Приборостроительный",
                ManufacturedProduction = "Компасы",
                ValueOutputProduction = 40,
                //LastName = "Захаров",
                CreationDate = new DateTime(1985, 11, 8),
                RenovationNeed = 20,
                EmployeesNumber = 1057,
                LastRenovationDate = new DateTime(2019, 7, 15),
            });
            _storage.Employees.Add(new Employee
            {
                Id = 5,
                Name = "Новосибирский Приборостроительный",
                ManufacturedProduction = "Компасы",
                ValueOutputProduction = 50,
                //LastName = "Захаров",
                CreationDate = new DateTime(1985, 11, 8),
                RenovationNeed = 20,
                EmployeesNumber = 1057,
                LastRenovationDate = new DateTime(2019, 7, 15),
            });



            EmployeeStorage.MaxId = _storage.Employees.Max(e => e.Id);
        }

        public void Delete(Employee employee)
        {
            for (int i = 0; i < _storage.Employees.Count; i++)
            {
                if (_storage.Employees[i].Id == employee.Id)
                {
                    _storage.Employees.RemoveAt(i);
                }
            }
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

                existingEmployee.Name = employee.Name;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.ManufacturedProduction = employee.ManufacturedProduction;
                existingEmployee.ValueOutputProduction = employee.ValueOutputProduction;
                existingEmployee.CreationDate = employee.CreationDate;
                existingEmployee.RenovationNeed = employee.RenovationNeed;
                existingEmployee.EmployeesNumber = employee.EmployeesNumber;
                existingEmployee.LastRenovationDate = employee.LastRenovationDate;
            }
        }
    }
}
