using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.ViewModels
{
    public class AnimalViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Name { get; set; }

        public string personality { get; set; }

        public DateTime Check_in_date { get; set; }
        public DateTime BirthDate { get; set; } = new DateTime(2000, 1, 1);

        public string BirthDateText => BirthDate.ToShortDateString();

    }
}
