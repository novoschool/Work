using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.Business.Models
{
    public class AnimalsStorage
    {
        public static int MaxId { get; set; }

        public List<Animal> Animals { get; } = new List<Animal>();
    }
}
