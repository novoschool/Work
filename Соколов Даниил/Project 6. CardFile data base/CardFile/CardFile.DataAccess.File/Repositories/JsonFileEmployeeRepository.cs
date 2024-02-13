using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.DataAccess.File.Repositories
{
    public class JsonFileEmployeeRepository : IEmployeeRepository
    {
        public string FileName {  get; set; }

        public IEnumerable<Employee> GetAll()
        {
            using(var sr = new StreamReader(FileName))
            {
                var serializer = new JsonSerializer();
                return (List<Employee>)serializer.Deserialize(sr, typeof(List<Employee>));
            }
        }

        public void Save(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Employee> employees)
        {
            using (var sw=new StreamWriter(FileName))
            {
                var serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(sw, employees);
            }
        }

        
    }
}
