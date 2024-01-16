using CardFile.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.Business.Models
{
    public class EmployeeStorage
    {
        public static int MaxId { get; set; }

        public List<Employee> Employees { get; } = new List<Employee>();
    }
}
