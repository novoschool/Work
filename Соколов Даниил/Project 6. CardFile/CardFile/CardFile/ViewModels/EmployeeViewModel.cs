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

        public string Rocket { get; set; }

        public string TypeWH { get; set; }

        public string Basing { get; set; }

        public DateTime PuttingOnDuty { get; set; } = new DateTime(2000, 1, 1);

        public string PuttingOnDutyText => PuttingOnDuty.ToShortDateString();

        public int DeadZone { get; set; }

        public int Range { get; set; }

        public DateTime RepairDate { get; set; } = new DateTime(2020, 1, 1);

        public string RepairDateText => RepairDate.ToShortDateString();
    }
}
