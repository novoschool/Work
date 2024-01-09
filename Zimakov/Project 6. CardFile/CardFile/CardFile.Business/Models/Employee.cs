using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.Business.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Stamp { get; set; }

        public string CarModel { get; set; }

        public string GosNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime DateOfLastUse { get; set; }

        public double Mileage { get; set; }

        public decimal Price { get; set; }
    }
}
