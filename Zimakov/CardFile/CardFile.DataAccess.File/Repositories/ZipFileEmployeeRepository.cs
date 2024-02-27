using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using CardFile.Core;
using System.Xml.Serialization;

namespace CardFile.DataAccess.File.Repositories
{
    public class ZipFileEmployeeRepository : IEmployeeRepository
    {
        public string FileName { get; set; }

        public IEnumerable<Employee> GetAll()
        {
            var input = System.IO.File.ReadAllText(FileName);
            using (var sr = new StringReader(input))
            {
                var serializer = new XmlSerializer(typeof(EmployeeCollection));
                var employees = (EmployeeCollection)serializer.Deserialize(sr);
                return employees.Employees;
            }
        }

        public int Save(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Employee> employees)
        {
            using (var sw = new MemoryStream())
            {
                var serializer = new XmlSerializer(typeof(EmployeeCollection));
                var collection = new EmployeeCollection { Employees = employees.ToList() };
                serializer.Serialize(sw, collection);
                sw.Seek(0, SeekOrigin.Begin);

                using (var fs = new FileStream(FileName, FileMode.Create))
                {
                    using (var zs = new GZipStream(fs, CompressionLevel.Optimal))
                    {
                        sw.CopyTo(zs);
                    }
                }
            }
        }
    }
}
