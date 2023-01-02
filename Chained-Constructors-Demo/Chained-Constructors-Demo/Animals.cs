using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chained_Constructors_Demo
{
    // create class with properties
    public class Animals
    {
        public string Species { get; set; }
        public string Sex { get; set; }
        public string Color { get; set; }

        // create default constructor - if no parameters are entered, property values default to these
        public Animals()
        {
            Species = "Unknown";
            Sex = "Unknown";
            Color = "Unknown";
        }

        // chained constructor - allows for property values to be specified upon construction
        public Animals(string species, string sex, string color) : this()
        {
            Species = species;
            Sex = sex;
            Color = color;
        }
        

    }
}
