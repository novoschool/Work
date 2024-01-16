using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ManufacturedProduction { get; set; }

        public decimal ValueOutputProduction { get; set; }

        public string LastName { get; set; }

        public DateTime CreationDate { get; set; } = new DateTime(2000, 1, 1);

        public string BirthDateText => CreationDate.ToShortDateString();

        public int RenovationNeed { get; set; }

        public int EmployeesNumber { get; set; }

        public DateTime LastRenovationDate { get; set; } = new DateTime(2020, 1, 1);

        public string EmploymentDateText => LastRenovationDate.ToShortDateString();
    }
}
