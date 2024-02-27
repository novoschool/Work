using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardFile.Core.Entities;
using CardFile.Core;
using System.Xml.Serialization;
using CardFile.Core.Repositories;
using Newtonsoft.Json;

namespace CardFile.DataAccess.File.Repositories
{
    public class JsonFileEmployeeRepository : IEmployeeRepository
    {
        public string FileName { get; set; }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Employee> employees)
        {
            using (var sw = new StreamWriter(FileName))
            {
                var serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(sw, employees);
            }
        }
    }
}
