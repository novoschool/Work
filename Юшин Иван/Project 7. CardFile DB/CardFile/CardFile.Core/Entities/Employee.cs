using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CardFile.Core.Entities
{
    [Serializable]
    public class Employee
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Surname")]
        public string Surname { get; set; }

        [XmlElement("Date")]
        public DateTime Date { get; set; }

        [XmlIgnore]
        public int BirthDate { get; set; }

        [XmlElement("VisitReason")]
        public string VisitReason { get; set; }

        [XmlElement("VisaNumber")]
        public string VisaNumber { get; set; }

        [XmlIgnore]
        public DateTime EmploymentDate { get; set; }

        //[XmlAttribute("EmploymentDate")]
        //[JsonIgnore]
        //public string EmploymentDateText
        //{
        //    get => EmploymentDate.ToString();
        //    set => EmploymentDate = DateTime.Parse(value);
        //}
    }
}
