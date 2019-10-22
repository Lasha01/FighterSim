
using System;
using System.Collections.Generic;

namespace FighterSim
{
    abstract class Pokemon
    {

        protected int hp;
        public string name;
        private static Random rmd = new Random();

        public Stat[] stats;
        protected int dmg = 0;

        protected int minDmg;
        protected int maxDmg;

        public virtual int Attack()
        {
            int dmg = rmd.Next(minDmg, maxDmg);
            Console.WriteLine(name + " dealt " + dmg + " damage");

            return dmg;
        }

        public void Hurt(int amount)
        {
            hp -= amount;
        }

        public bool IsAlive()
        {
            return hp > 0;
        }

        public int GetHp()
        {
            return hp;
        } 

        public void UpdateStats()
        {
            for (int i = 0; i < stats.Length; i++)
            {
                if (stats[i].Name == "hp")
                {
                    hp = stats[i].base_stat;
                }
            }
        }
    }
}