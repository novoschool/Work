using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using CardFile.DataAccess.PostgreSql.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.DataAccess.PostgreSql.EF.Repositories
{
    public class EmployeeRepository : IEmployeeDbRepository
    {
        public void Delete(int employeeId)
        {
            using (var ctx = new CardFileDbContext())
            {
                var emp = ctx.Employees.FirstOrDefault(e => e.Id == employeeId);
                if (emp == null)
                {
                    return;
                }

                ctx.Employees.Remove(emp);
                ctx.SaveChanges();
            }
        }

        public Employee Get(int employeeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            using (var ctx = new CardFileDbContext())
            {
                return ctx.Employees.ToList();
            }
        }

        public int Insert(Employee employee)
        {
            using (var ctx = new CardFileDbContext())
            {
                ctx.Employees.Add(employee);
                ctx.SaveChanges();
                return employee.Id;
            }
        }

        public void Update(Employee employee)
        {
            using (var ctx = new CardFileDbContext())
            {
                var emp = ctx.Employees.FirstOrDefault(e => e.Id == employee.Id);
                if (emp == null)
                {
                    return;
                }

                emp.Name = employee.Name;
                emp.Surname = employee.Surname;
                emp.Date = employee.Date;
                emp.VisitReason = employee.VisitReason;
                emp.VisaNumber = employee.VisaNumber;
                ctx.SaveChanges();
            }
        }
    }
}
