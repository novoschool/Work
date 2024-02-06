using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CardFile.Core.Entities
{
    [Serializable]
    [XmlRoot("EmployeeCollection")]
    public class EmployeeCollection
    {
        [XmlArray("Employees")]
        [XmlArrayItem("Employee")]
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
