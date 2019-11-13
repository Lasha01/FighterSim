using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterSim
{
    class Totodile : Pokemon
    {
        public override string SetName()
        {
            string name = "Totodile";
            return name;
        }
        public Totodile()
        {
            hp = 120;
            minDmg = 25;
            maxDmg = 90;
        }
    }
}
