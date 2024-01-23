using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CardFile.Business.Models
{
    [Serializable]
    public class Employee
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }

        [XmlElement()]
        public string FirstName { get; set; }

        [XmlElement()]
        public string MiddleName { get; set; }

        [XmlElement()]
        public string LastName { get; set; }

        [XmlElement()]
        public DateTime BirthDate { get; set; }

        [XmlElement()]
        public string Position { get; set; }

        [XmlElement()]
        public string Division { get; set; }

        [XmlElement()]
        public DateTime EmploymentDate { get; set; }

        [XmlElement()]
        public DateTime StrongName { get; set; }
    }
}
