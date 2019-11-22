
using System;
using System.Collections.Generic;

namespace FighterSim
{
    abstract class Pokemon
    {

        protected int hp;
        
        private static Random rmd = new Random(); //skapar en random generator

        public Stat[] stats; //En lista med stats som används för API call
        protected int dmg;

        protected int minDmg;
        protected int maxDmg;

        public virtual string SetName() //metoden som används för att bestämma och returnera namnet på en specifik pokemon
        {
            string name = "";
            return name;
        }
        public int Attack() //En metod som slumpar ett tal beroende på vilken pokeomn och sedan returnerar talet som skada
        {
            dmg = rmd.Next(minDmg, maxDmg);
            Console.WriteLine(SetName() + " dealt " + dmg + " damage");

            return dmg;
        }

        public void Hurt(int amount) //Metod som tar emot skadan och drar av det från hp
        {
            hp -= amount;
        }

        public bool IsAlive() //metod som kollar ifall specific pokemon lever eler inte
        {
            return hp > 0;
        }

        public int GetHp() //Metod som hämtar hp från pokemonen
        {
            return hp;
        } 

        public void UpdateStats()  //Metod som hämtar ordet h från api:n och lägger in den stat som tillhör hp från api:n in i hp som används till pokemons        
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