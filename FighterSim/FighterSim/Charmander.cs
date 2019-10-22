using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterSim
{
    class Charmander : Pokemon
    {
        public Charmander()
        {
            minDmg = 20;
            maxDmg = 70;
        }

        public override int Attack()
        {
            return dmg;
        }
    }
}
