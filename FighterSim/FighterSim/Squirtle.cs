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
            hp = 120;
            minDmg = 30;
            maxDmg = 80;
        }        
    }
}
