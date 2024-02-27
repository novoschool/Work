using CardFile.Business.Models;
using CardFile.Core.Entities;
using CardFile.DataAccess.File.Repositories;
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
                FirstName = "Олег",
                MiddleName = "Олегович",
                LastName = "Олегов",
                BirthDate = new DateTime(2004, 11, 8),
                Specialization = "ИСиП",
                Course = 4,
                DateOfReceipt = new DateTime(2021, 1, 1),
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

                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.MiddleName = employee.MiddleName;
                existingEmployee.BirthDate = employee.BirthDate;
                existingEmployee.Specialization = employee.Specialization;
                existingEmployee.Course = employee.Course;
                existingEmployee.DateOfReceipt = employee.DateOfReceipt;
            }
        }

        public void Delete(int employeeId)
        {
            var existingEmployee = _storage.Employees.FirstOrDefault(e => e.Id == employeeId);
            if (existingEmployee == null)
            {
                throw new IndexOutOfRangeException();
            }

            _storage.Employees.Remove(existingEmployee);
        }

        public void Save(string fileName)
        {
            var repository = new FileEmployeeRepositoryFactory().CreateRepository(fileName);
            if (repository == null)
            {
                return;
            }

            repository.SaveAll(_storage.Employees);
        }

        public void Open(string fileName)
        {
            var repository = new FileEmployeeRepositoryFactory().CreateRepository(fileName);
            if (repository == null)
            {
                return;
            }

            _storage.Employees.Clear();
            _storage.Employees.AddRange(repository.GetAll());
            EmployeeStorage.MaxId = _storage.Employees.Any() ? _storage.Employees.Max(e => e.Id) : 0;
        }
    }
}
