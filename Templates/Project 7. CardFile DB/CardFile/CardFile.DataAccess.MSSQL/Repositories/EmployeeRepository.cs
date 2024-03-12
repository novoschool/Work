using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.DataAccess.MSSQL.Repositories
{
    public class EmployeeRepository : IEmployeeDbRepository
    {
        private const string ConnectionString = @"Server=localhost;Database=CardFile;Integrated Security=True;TrustServerCertificate=true;";

        public void Delete(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int employeeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            var query = @"
select
    Id,
    FirstName,
    MiddleName,
    LastName,
    BirthDate,
    Position,
    Division,
    EmploymentDate
from
    Employees
";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(query, connection))
                {
                    command.CommandType = System.Data.CommandType.Text;

                    var result = new List<Employee>();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var employee = new Employee();
                        employee.Id = (int)reader["Id"];
                        employee.FirstName = (string)reader["FirstName"];
                        employee.MiddleName = (string)reader["MiddleName"];
                        employee.LastName = (string)reader["LastName"];
                        employee.BirthDate = (DateTime)reader["BirthDate"];
                        employee.Position = (string)reader["Position"];
                        employee.Division = (string)reader["Division"];
                        employee.EmploymentDate = (DateTime)reader["EmploymentDate"];

                        result.Add(employee);
                    }

                    return result;
                }
            }
        }

        public int Insert(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
