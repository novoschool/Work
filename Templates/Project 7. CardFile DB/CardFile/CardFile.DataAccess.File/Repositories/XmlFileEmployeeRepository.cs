using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CardFile.DataAccess.File.Repositories
{
    public class XmlFileEmployeeRepository : IEmployeeRepository
    {
        public string FileName { get; set; }

        public IEnumerable<Employee> GetAll()
        {
            using (var sr = new StreamReader(FileName))
            {
                var serializer = new XmlSerializer(typeof(EmployeeCollection));
                var employees = (EmployeeCollection)serializer.Deserialize(sr);
                return employees.Employees;
            }
        }

        public void SaveAll(IEnumerable<Employee> employees)
        {
            using (var sw = new StreamWriter(FileName))
            {
                var serializer = new XmlSerializer(typeof(EmployeeCollection));
                var collection = new EmployeeCollection { Employees = employees.ToList() };
                serializer.Serialize(sw, collection);
            }
        }
    }
}
