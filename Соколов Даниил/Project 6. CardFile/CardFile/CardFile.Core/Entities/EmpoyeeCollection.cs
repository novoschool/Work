using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CardFile.Core.Entities
{
    [Serializable]
    [XmlRoot("EmployeeColection")]
    public class EmployeeCollection
    {
        [XmlArray("Empoyees")]
        [XmlArrayItem("Empoyee")]
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
