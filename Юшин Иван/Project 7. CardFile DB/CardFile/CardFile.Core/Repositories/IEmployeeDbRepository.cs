using CardFile.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.Core.Repositories
{
    public interface IEmployeeDbRepository
    {
        IEnumerable<Employee> GetAll();

        Employee Get(int employeeId);

        int Insert(Employee employee);

        void Update(Employee employee);

        void Delete(int employeeId);
    }
}
