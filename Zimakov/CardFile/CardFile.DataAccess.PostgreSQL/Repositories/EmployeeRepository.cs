using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using Npgsql;

namespace CardFile.DataAccess.PostgreSQL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private const string ConnectionString = "host=localhost; port=5432; database=CardFile; user id=postgres; password=Qwerty123; sslmode=prefer;";

        public IEnumerable<Employee> GetAll()
        {
            var query = @"
                   SELECT
                        ""Id"",
                        ""FirstName"",
                        ""MiddleName"",
                        ""LastName"",
                        ""BirthDate"",
                        ""Specialization"",
                        ""Course"",
                        ""DateOfReceipt""
                   FROM 
                        ""Students""
                ";
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand(query, connection))
                {

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
                        employee.Specialization = reader.GetString(5);
                        employee.Course = reader.GetInt32(6);
                        employee.DateOfReceipt = reader.GetDateTime(7);

                        result.Add(employee);
                    }

                    return result;
                }
            }
        }

        public int Save(Employee employee)
        {
            if(employee.Id == 0)
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

                insert into public. ""Students""
                (
                ""FirstName"",
                ""MiddleName"",
                ""LastName"",
                ""BirthDate"",
                ""Specialization"",
                ""Course"",
                ""DateOfReceipt""
                )
                values
                (
                @firstName,
                @middleName,
                @lastName,
                @birthDate,
                @specialization,
                @course,
                @dateOfReceipt
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
                    cmd.Parameters.AddWithValue("specialization", employee.Specialization);
                    cmd.Parameters.AddWithValue("course", employee.Course);
                    cmd.Parameters.AddWithValue("dateOfReceipt", employee.DateOfReceipt);
                    var result = (int)cmd.ExecuteScalar();
                    return result;
                }
            }
        }

        private int Update(Employee employee)
        {
            var query = @"
                update public. ""Students""
                set
                    ""FirstName"" = @firstName,
                    ""MiddleName"" = @middleName,
                    ""LastName"" = @lastName,
                    ""BirthDate"" = @birthDate,
                    ""Specialization"" = @specialization,
                    ""Course"" = @course,
                    ""DateOfReceipt"" = @dateOfReceipt
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
                    cmd.Parameters.AddWithValue("specialization", employee.Specialization);
                    cmd.Parameters.AddWithValue("course", employee.Course);
                    cmd.Parameters.AddWithValue("dateOfReceipt", employee.DateOfReceipt);
                    cmd.ExecuteScalar();
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
            delete from public. ""Students""
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
                    cmd.ExecuteScalar();
                }
            }
        }
    }
}
