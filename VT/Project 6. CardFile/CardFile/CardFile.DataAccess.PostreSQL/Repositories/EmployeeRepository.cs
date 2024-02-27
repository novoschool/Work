using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.DataAccess.PostreSQL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private const string ConnectionString =
            "host=localhost; port=5432; database=CardFile; user id=postgres; password=Qwerty123; sslmode=prefer;";
            //"Server=PostgreSQL 16;Port=5432;User Id=postgresql;Password=Qwerty123;Database=CardFile;";

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
    public.""Employee""
";
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    var result = new List<Employee>();

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

        public int Save(Employee employee)
        {
            if (employee.Id == 0)
            {
                return Insert(employee);
            }
            else
            {
                return Update(employee);
            }
        }

        private int Insert(Employee employee)
        {
            var query = @"
insert into public.""Employee""
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

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("firstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("middleName", employee.MiddleName);
                    cmd.Parameters.AddWithValue("lastName", employee.LastName);
                    cmd.Parameters.AddWithValue("birthDate", employee.BirthDate);
                    cmd.Parameters.AddWithValue("position", employee.Position);
                    cmd.Parameters.AddWithValue("division", employee.Division);
                    cmd.Parameters.AddWithValue("employmentDate", employee.EmploymentDate);
                    var result = (int)cmd.ExecuteScalar();
                    return result;
                }
            }
        }

        private int Update(Employee employee)
        {
            var query = @"
update public.""Employee""
set
    ""FirstName"" = @firstName,
    ""MiddleName"" = @middleName,
    ""LastName"" = @lastName,
    ""BirthDate"" = @birthDate,
    ""Position"" = @position,
    ""Division"" = @division,
    ""EmploymentDate"" = @employmentDate
where
    ""Id"" = @id
";
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("id", employee.Id);
                    cmd.Parameters.AddWithValue("firstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("middleName", employee.MiddleName);
                    cmd.Parameters.AddWithValue("lastName", employee.LastName);
                    cmd.Parameters.AddWithValue("birthDate", employee.BirthDate);
                    cmd.Parameters.AddWithValue("position", employee.Position);
                    cmd.Parameters.AddWithValue("division", employee.Division);
                    cmd.Parameters.AddWithValue("employmentDate", employee.EmploymentDate);

                    cmd.ExecuteNonQuery();
                    return employee.Id;
                }
            }
        }

        public void SaveAll(IEnumerable<Employee> employees)
        {
            throw new NotImplementedException();
        }

        public void Delete(int employeeId)
        {
            var query = @"
delete from public.""Employee""
where
    ""Id"" = @id
";
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("id", employeeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
