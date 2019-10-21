using System;
using System.Collections.Generic;

namespace FighterSim
{
    abstract class Pokemon
    {
        List<Pokemon> pokemons = new List<Pokemon>();

        void AddPokemons()
        {


            pokemons.Add();
        }

        protected int hp = 200;
        public string name;
        private static Random rmd = new Random();

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


        
        public Pokemon() { }

       
           
       
    }
}