using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterSim
{
    class Psyduck : Pokemon
    {
        public override string SetName()
        {
            string name = "Psyduck";
            return name;
        }
        public Psyduck()
        {
            hp = 110;
            minDmg = 25;
            maxDmg = 75;
        }
    }
}
