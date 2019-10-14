using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter f1 = new Fighter(1);

            Console.WriteLine();

            Fighter f2 = new Fighter(2);

            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            Console.Clear();

            while (f1.IsAlive() && f2.IsAlive())
            {
                int dmg1 = f1.Attack();

                f2.Hurt(dmg1);

                int dmg2 = f2.Attack();

                f1.Hurt(dmg2);

                Console.WriteLine( f2.name + "'s hp is " + f2.GetHp());
                Console.WriteLine( f1.name + "'s hp is " + f1.GetHp());

                Console.WriteLine("Press any button to continue...");
                Console.ReadKey();

                Console.Clear();

                if (!f1.IsAlive())
                {
                    Console.WriteLine("Congratulations {0}!", f2.name);                    
                }
                else if (!f2.IsAlive())
                {
                    Console.WriteLine("Congratulations {0}!", f1.name);
                }
            }

            Console.ReadLine();
            
        }
    }
}
