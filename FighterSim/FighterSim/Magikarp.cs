using RestSharp;
using Newtonsoft.Json;
using System;

namespace FighterSim
{
    class Magikarp : Pokemon
    {
        public override string SetName()
        {
            string name = "Magikarp";
            return name;
        }
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
