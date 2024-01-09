using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.Business.Models
{
    public class StudentsStorage
    {
        public static int MaxId { get; set; }

        public List<Students> Students { get; } = new List<Students>();
    }
}
