using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cardfile.dataAccess.PostrgesSQL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private const string ConnectionString = "host=localhost; port=5433; database=CardFile; user id=postgres; password=Qwerty123; sslmode=prefer;";

        public IEnumerable<Employee> GetAll()
        {
            var query = @"
                select 
                    ""Id"",
                    ""Rocket"",
                    ""TypeWH"",
                    ""Basing"",
                    ""DeadZone"",
                    ""Range"",
                    ""PuttingOnDuty"",
                    ""RepairDate""
                from 
                    public.""BimBimBamBams""
                ";

            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (var cmd=new NpgsqlCommand(query ,connection))
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
                        employee.Division = reader.GetInt32(4);
                        employee.Position = reader.GetInt32(5);
                        employee.BirthDate = reader.GetDateTime(6);
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
insert into public.""BimBimBamBams""
(
""Rocket"",
""TypeWH"",
""Basing"",
""DeadZone"",
""Range"",
""PuttingOnDuty"",
""RepairDate""
)
values
(
@firstName,
@middleName,
@lastName,
@division,
@position,
@birthDate,
@employmentDate
)
returning ""Id""
";
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
            
                connection.Open();
                using (var cmd =new NpgsqlCommand(query,connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text; 
                    cmd.Parameters.AddWithValue("firstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("middlename", employee.MiddleName);    
                    cmd.Parameters.AddWithValue("lastName",employee.LastName);
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
update public.""BimBimBamBams""
set 
    ""Rocket"" = @firstName,
    ""TypeWH"" = @middleName,
    ""Basing"" = @lastName,
    ""DeadZone"" = @division,
    ""Range"" = @position,
    ""PuttingOnDuty"" = @birthDate,
    ""RepairDate"" =@employmentDate
where
    ""Id"" = @id
";

            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                using(var cmd = new NpgsqlCommand(query,connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("id", employee.Id);
                    cmd.Parameters.AddWithValue("firstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("middlename", employee.MiddleName);
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
delete from public.""BimBimBamBams""
where
        ""Id"" = @id
";

            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using(var cmd = new NpgsqlCommand(query,connection))
                {
                    cmd.CommandType= System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("id", employeeId);
                    cmd.ExecuteNonQuery ();
                }
            }
                
        }
    }
}