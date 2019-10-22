using RestSharp;
using Newtonsoft.Json;
using System;

namespace FighterSim
{
    class Magikarp : Pokemon
    {
       
       public Magikarp()
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
