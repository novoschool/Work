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

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; } = new DateTime(2000, 1, 1);

        public string BirthDateText => BirthDate.ToShortDateString();

        public string Specialization { get; set; }

        public int Course { get; set; }

        public DateTime DateOfReceipt { get; set; } = new DateTime(2020, 1, 1);

        public string DateOfReceiptText => DateOfReceipt.ToShortDateString();
    }
}
