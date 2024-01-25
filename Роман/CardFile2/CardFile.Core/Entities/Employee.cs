﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Position { get; set; }

        public string Division { get; set; }

        public DateTime EmploymentDate { get; set; }
    }
}
