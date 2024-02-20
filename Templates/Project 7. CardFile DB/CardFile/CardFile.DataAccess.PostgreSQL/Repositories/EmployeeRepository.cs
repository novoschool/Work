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
            var query = @"
delete from ""Employees""
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

                    command.ExecuteNonQuery();
                }
            }
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
            var query = @"
insert into ""Employees""
(
    ""FirstName"",
    ""MiddleName"",
    ""LastName"",
    ""BirthDate"",
    ""Position"",
    ""Division"",
    ""EmploymentDate""
)
values
(
    @firstName,
    @middleName,
    @lastName,
    @birthDate,
    @position,
    @division,
    @employmentDate
)
returning ""Id""
";

            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.Parameters.AddWithValue("firstName", employee.FirstName);
                    command.Parameters.AddWithValue("middleName", employee.MiddleName);
                    command.Parameters.AddWithValue("lastName", employee.LastName);
                    command.Parameters.AddWithValue("birthDate", employee.BirthDate);
                    command.Parameters.AddWithValue("position", employee.Position);
                    command.Parameters.AddWithValue("division", employee.Division);
                    command.Parameters.AddWithValue("employmentDate", employee.EmploymentDate);

                    var result = command.ExecuteScalar();
                    return (int)result;
                }
            }
        }

        public void Update(Employee employee)
        {
            var query = @"
update ""Employees""
set
    ""FirstName"" = @firstName,
    ""MiddleName"" = @middleName,
    ""LastName"" = @lastName,
    ""BirthDate"" = @birthDate,
    ""Position"" = @position,
    ""Division"" = @division,
    ""EmploymentDate"" = @employmentDate
where
    ""Id"" = @employeeId
";

            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.Parameters.AddWithValue("employeeId", employee.Id);
                    command.Parameters.AddWithValue("firstName", employee.FirstName);
                    command.Parameters.AddWithValue("middleName", employee.MiddleName);
                    command.Parameters.AddWithValue("lastName", employee.LastName);
                    command.Parameters.AddWithValue("birthDate", employee.BirthDate);
                    command.Parameters.AddWithValue("position", employee.Position);
                    command.Parameters.AddWithValue("division", employee.Division);
                    command.Parameters.AddWithValue("employmentDate", employee.EmploymentDate);

                    var result = command.ExecuteNonQuery();
                }
            }
        }

        // CQRS
    }
}
