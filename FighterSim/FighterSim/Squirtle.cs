using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterSim
{
    class Squirtle : Pokemon
    {
        public Squirtle()
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
