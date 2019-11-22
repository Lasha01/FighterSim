using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterSim
{
    class Totodile : Pokemon   //Totodile är ärv av Pokeomón
    {
        public override string SetName() //bestämmer namnet på pokemonen
        {
            string name = "Totodile";
            return name;
        }
        public Totodile() //Bestämmer vilken skada pokemonen ska göra
        {
            
            minDmg = 14;
            maxDmg = 30;
           
        }
    }
}
