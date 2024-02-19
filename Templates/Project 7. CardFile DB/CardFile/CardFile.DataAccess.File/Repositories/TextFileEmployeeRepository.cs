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
    public class TextFileEmployeeRepository : IEmployeeRepository
    {
        public string FileName { get; set; }

        public IEnumerable<Employee> GetAll()
        {
            using (var sr = new StreamReader(FileName))
            {
                var result = new List<Employee>();

                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    int id;
                    if (!int.TryParse(line, out id))
                    {
                        break;
                    }

                    var firstName = sr.ReadLine();
                    var middleName = sr.ReadLine();
                    var lastName = sr.ReadLine();

                    line = sr.ReadLine();
                    DateTime birthDate;
                    if (!DateTime.TryParse(line, out birthDate))
                    {
                        break;
                    }

                    var position = sr.ReadLine();
                    var division = sr.ReadLine();

                    line = sr.ReadLine();
                    DateTime employmentDate;
                    if (!DateTime.TryParse(line, out employmentDate))
                    {
                        break;
                    }

                    result.Add(new Employee
                    {
                        Id = id,
                        FirstName = firstName,
                        LastName = lastName,
                        MiddleName = middleName,
                        BirthDate = birthDate,
                        Position = position,
                        Division = division,
                        EmploymentDate = employmentDate,
                    });
                }

                return result;
            }
        }

        public void SaveAll(IEnumerable<Employee> employees)
        {
            using (var sw = new StreamWriter(FileName))
            {
                foreach (var employee in employees)
                {
                    sw.WriteLine(employee.Id);
                    sw.WriteLine(employee.FirstName);
                    sw.WriteLine(employee.MiddleName);
                    sw.WriteLine(employee.LastName);
                    sw.WriteLine(employee.BirthDate);
                    sw.WriteLine(employee.Position);
                    sw.WriteLine(employee.Division);
                    sw.WriteLine(employee.EmploymentDate);
                }
            }
        }
    }
}
