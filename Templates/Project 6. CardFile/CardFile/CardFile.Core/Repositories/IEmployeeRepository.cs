using CardFile.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.Core.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        void SaveAll(IEnumerable<Employee> employees);
    }
}
