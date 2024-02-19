using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.DataAccess.PostgreSQL.Repositories
{
    public class EmployeeRepository : IEmployeeDbRepository
    {
        private const string ConnectionString = @"Server=localhost;Port=5432;Database=CardFile;User Id=postgres;Password=Qwerty123;";

        public void Delete(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int employeeId)
        {
            var query = @"
select
    ""Id"",
    ""FirstName"",
    ""MiddleName"",
    ""LastName"",
    ""BirthDate"",
    ""Position"",
    ""Division"",
    ""EmploymentDate""
from
    ""Employees""
where
    ""Id"" = @employeeId
";

            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.Parameters.AddWithValue("employeeId", employeeId);

                    var reader = command.ExecuteReader();
                    if (!reader.Read())
                    {
                        return null;
                    }

                    var employee = new Employee();
                    employee.Id = reader.GetInt32(0);
                    employee.FirstName = reader.GetString(1);
                    employee.MiddleName = reader.GetString(2);
                    employee.LastName = reader.GetString(3);
                    employee.BirthDate = reader.GetDateTime(4);
                    employee.Position = reader.GetString(5);
                    employee.Division = reader.GetString(6);
                    employee.EmploymentDate = reader.GetDateTime(7);

                    return employee;
                }
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            var query = @"
select
    ""Id"",
    ""FirstName"",
    ""MiddleName"",
    ""LastName"",
    ""BirthDate"",
    ""Position"",
    ""Division"",
    ""EmploymentDate""
from
    ""Employees""
";

            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.CommandType = System.Data.CommandType.Text;

                    var result = new List<Employee>();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var employee = new Employee();
                        employee.Id = reader.GetInt32(0);
                        employee.FirstName = reader.GetString(1);
                        employee.MiddleName = reader.GetString(2);
                        employee.LastName = reader.GetString(3);
                        employee.BirthDate = reader.GetDateTime(4);
                        employee.Position = reader.GetString(5);
                        employee.Division = reader.GetString(6);
                        employee.EmploymentDate = reader.GetDateTime(7);

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
