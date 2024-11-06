using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesCS
{
    internal class Fruit
    {
        public string Name { get; set; } 

        public string Colour { get; set; }

        public Fruit(string name, string colour)
        {
            Name = name;
            Colour = colour; 
        }

        public string myColour()
        {
            return this.Colour;
        }



    }
}
