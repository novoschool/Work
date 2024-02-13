using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.DataAccess.File.Repositories
{
    public class BinaryFileEmployeeRepository : IEmployeeRepository
    {
        public string FileName { get; set; }

        public void Delete(int employeeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            using (var br = new BinaryReader(System.IO.File.Open(FileName, FileMode.Open)))
            {
                var result = new List<Employee>();

                while (br.PeekChar() > -1)
                {
                    var id = br.ReadInt32();

                    //var firstName = br.ReadString();
                    var firstNameByteCount = br.ReadInt32();
                    var firstNameBytes = br.ReadBytes(firstNameByteCount);
                    var firstName = Encoding.UTF8.GetString(firstNameBytes);

                    var middleName = br.ReadString();
                    var lastName = br.ReadString();
                    var ticks = br.ReadInt64();
                    var birthDate = new DateTime(ticks);
                    var position = br.ReadInt32();
                    var division = br.ReadInt32();
                    ticks = br.ReadInt64();
                    var employmentDate = new DateTime(ticks);

                    result.Add(new Employee
                    {
                        Id = id,
                        FirstName = firstName,
                        MiddleName = middleName,
                        LastName = lastName,
                        BirthDate = birthDate,
                        Position = position,
                        Division = division,
                        EmploymentDate = employmentDate,
                    });
                }

                return result;
            }
        }

        public void Save(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Employee> employees)
        {
            using (var bw = new BinaryWriter(System.IO.File.Open(FileName, FileMode.Create)))
            {
                foreach (var employee in employees)
                {
                    bw.Write(employee.Id);

                    //bw.Write(employee.FirstName);
                    var firstNameBytes = Encoding.UTF8.GetBytes(employee.FirstName);
                    bw.Write(firstNameBytes.Length);
                    bw.Write(firstNameBytes);

                    bw.Write(employee.MiddleName);
                    bw.Write(employee.LastName);
                    bw.Write(employee.BirthDate.Ticks);
                    bw.Write(employee.Position);
                    bw.Write(employee.Division);
                    bw.Write(employee.EmploymentDate.Ticks);
                }
            }
        }

        int IEmployeeRepository.Save(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
