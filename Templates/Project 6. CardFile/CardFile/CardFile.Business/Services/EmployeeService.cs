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
                FirstName = "Андрей",
                MiddleName = "Григорьевич",
                LastName = "Захаров",
                BirthDate = new DateTime(1985, 11, 8),
                Position = "Руководитель проекта",
                Division = "Отдел разработки",
                EmploymentDate = new DateTime(2019, 7, 15),
            });
            _storage.Employees.Add(new Employee
            {
                Id = 2,
                FirstName = "Людмила",
                MiddleName = "Алексеевна",
                LastName = "Фролова",
                BirthDate = new DateTime(1978, 3, 11),
                Position = "Бизнес-аналитик",
                Division = "Отдел анализа",
                EmploymentDate = new DateTime(2020, 2, 3),
            });
            _storage.Employees.Add(new Employee
            {
                Id = 3,
                FirstName = "Вера",
                MiddleName = "Владимировна",
                LastName = "Тищенко",
                BirthDate = new DateTime(1989, 6, 10),
                Position = "Руководитель группы",
                Division = "Отдел тестирования",
                EmploymentDate = new DateTime(2021, 11, 18),
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
                existingEmployee.Position = employee.Position;
                existingEmployee.Division = employee.Division;
                existingEmployee.EmploymentDate = employee.EmploymentDate;
            }
        }
    }
}
