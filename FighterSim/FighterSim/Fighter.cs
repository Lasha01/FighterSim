﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterSim
{
    class Fighter
    {
        protected int hp = 200;
        public string name;
        static Random rmd = new Random();

            
        public int Attack()
        {
            int Dmg;

            Dmg = rmd.Next(30, 71);
            Console.WriteLine(name + " dealt " + Dmg + " damage");

            return Dmg;
        }

        public void Hurt (int amount)
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




        public Fighter() //Får fram namnet på den som spelare, med restriktioner
        {

        }

        public Fighter(int fighter) //Får fram namnet på den som spelare, med restriktioner
        {
            GiveName(fighter);
        }

        void GiveName(int fighter)
        {
            Console.WriteLine("{0}. What's your fighters name?", fighter);

            bool success = true;


            while (success != false)
            {

                name = Console.ReadLine();
                name = name.Trim();
                success = int.TryParse(name, out int wrongname);

                if (success == true)
                {
                    Console.WriteLine("No numbers in your name please");
                }

                else if (name.Length < 3 || name.Length > 10)
                {
                    Console.WriteLine("Between 3 and 10 letters, please!");
                    success = true;

                }
                else
                {                    
                    Console.WriteLine("Your fighters name is " + name);

                }
            }
        }

    }
}
