using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CardFile.Core.Entities;

namespace CardFile.Core
{
    [Serializable]
    [XmlRoot("EmployeeCollection")]
    public class EmployeeCollection
    {
        [XmlArray("Employees")]
        [XmlArrayItem("Employees")]

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
