using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterSim
{
    class Squirtle : Pokemon
    {
        public override string SetName()
        {
            string name = "Squirtle";
            return name;
        }
        public Squirtle()
        {
            
            minDmg = 13;
            maxDmg = 30;
        }        
    }
}
