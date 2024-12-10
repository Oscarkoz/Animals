using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public bool IsVaccinated { get; set; }

        public Gender Gender { get; set; }
        public int Legs { get; set; }
    }
}
