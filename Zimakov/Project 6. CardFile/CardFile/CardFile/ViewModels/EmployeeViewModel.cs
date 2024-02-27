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

        public string Stamp { get; set; }

        public string CarModel { get; set; }

        public string GosNumber { get; set; }

        public DateTime BirthDate { get; set; } = new DateTime(2000, 1, 1);

        public string BirthDateText => BirthDate.ToShortDateString();

        public double Mileage { get; set; }

        public string MileageText => Price.ToString() + " км.";

        public decimal Price { get; set; }

        public string PriceText => Price.ToString() + " руб.";

        public DateTime DateOfLastUse { get; set; } = new DateTime(2020, 1, 1);

        public string EmploymentDateText => DateOfLastUse.ToShortDateString();
    }
}
