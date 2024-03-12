using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using CardFile.DataAccess.PostreSQL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void SaveEmployee(Employee employee)
        {
            _employeeRepository.Save(employee);
        }

        public void Delete(int employeeId)
        {
            _employeeRepository.Delete(employeeId);
        }
    }
}
