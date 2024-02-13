using Cardfile.dataAccess.PostrgesSQL;
using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using System.Collections.Generic;

namespace CardFile.Business.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService() 
        {
            _employeeRepository = new EmployeeRepository();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }



        private void InitializeStorage()
        {
            //_storage.Employees.Add(new Employee
            //{
            //    Id = 1,
            //    FirstName = "Сармат",
            //    MiddleName = "РБЧ",
            //    LastName = "Шахтное",
            //    BirthDate = new DateTime(2019, 11, 8),
            //    Position = 1320,
            //    Division = 9465,
            //    EmploymentDate = new DateTime(2035, 7, 15),
            //});
            //_storage.Employees.Add(new Employee
            //{
            //    Id = 2,
            //    FirstName = "Тополь-М",
            //    MiddleName = "РБЧ",
            //    LastName = "Мобильное",
            //    BirthDate = new DateTime(1997, 3, 11),
            //    Position = 2424,
            //    Division = 10843,
            //    EmploymentDate = new DateTime(2027, 2, 3),
            //});
            ////_storage.Employees.Add(new Employee
            ////{
            ////    Id = 3,
            ////    FirstName = "Вера",
            ////    MiddleName = "Владимировна",
            ////    LastName = "Тищенко",
            ////    BirthDate = new DateTime(1989, 6, 10),
            ////    Position = "Руководитель группы",
            ////    Division = "Отдел тестирования",
            ////    EmploymentDate = new DateTime(2021, 11, 18),
            ////});

            //EmployeeStorage.MaxId = _storage.Employees.Max(e => e.Id);
        }

        public int Save (Employee employee)
        {
            //айди = айди;
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
