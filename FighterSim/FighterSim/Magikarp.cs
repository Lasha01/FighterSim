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
            hp = 100;
            minDmg = 20;
            maxDmg = 100;
        }

        public override int Attack()
        {
            return dmg;
        }
    }
}
