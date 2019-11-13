using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterSim
{
    class Charmander : Pokemon
    {
        public override string SetName()
        {
            string name = "Charmander";
            return name;
        }
        public Charmander()
        {
            hp = 120;
            minDmg = 40;
            maxDmg = 80;
        }
    }
}
