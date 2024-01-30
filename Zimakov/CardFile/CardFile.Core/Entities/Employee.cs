using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace CardFile.Core.Entities
{
    [Serializable]
    public class Employee
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlElement("FirstName")]
        public string FirstName { get; set; }

        [XmlElement("MiddleName")]
        public string MiddleName { get; set; }

        [XmlElement("LastName")]
        public string LastName { get; set; }

        [XmlIgnore]
        public DateTime BirthDate { get; set; }

        [XmlAttribute("BirthDate")]
        [JsonIgnore]
        public string BirthDateText
        {
            get => BirthDate.ToString();
            set => BirthDate = DateTime.Parse(value);
        }

        [XmlElement("Position")]
        public string Specialization { get; set; }

        [XmlElement("Division")]
        public int Course { get; set; }

        [XmlIgnore]
        public DateTime DateOfReceipt { get; set; }

        [XmlAttribute("EmploymentDate")]
        [JsonIgnore]
        public string DateOfReceiptText
        {
            get => DateOfReceipt.ToString();
            set => DateOfReceipt = DateTime.Parse(value);
        }
    }
}
