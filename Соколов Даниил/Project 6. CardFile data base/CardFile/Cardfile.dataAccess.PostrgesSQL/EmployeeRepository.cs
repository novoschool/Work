using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    ""id"",
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

        public void Save(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Employee> employees)
        {
            throw new NotImplementedException();
        }
    }
}
