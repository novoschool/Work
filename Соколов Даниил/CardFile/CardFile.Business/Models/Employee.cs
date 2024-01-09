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

        public string Name { get; set; }

        public string ManufacturedProduction { get; set; }

        public int ValueOutputProduction { get; set; }

        public string LastName { get; set; }

        public DateTime CreationDate { get; set; }

        public int RenovationNeed { get; set; }

        public int EmployeesNumber { get; set; }

        public DateTime LastRenovationDate { get; set; }


    }
}
