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
            
            minDmg = 15;
            maxDmg = 30;
        }
    }
}
