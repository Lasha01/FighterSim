using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

namespace FighterSim
{
    class Program
    {
        public List<Pokemon> pokemons = new List<Pokemon>();

        static void Start()
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");

            RestRequest request = new RestRequest("pokemon/magikarp/");
            IRestResponse response = client.Get(request);
            Pokemon magikarp = JsonConvert.DeserializeObject<Magikarp>(response.Content);
            //pokemons.Add(magikarp);

            client = new RestClient("https://pokeapi.co/api/v2/");
            request = new RestRequest("pokemon/squirtle/");
            response = client.Get(request);
            Pokemon squirtle = JsonConvert.DeserializeObject<Magikarp>(response.Content);
            squirtle.UpdateStats();
            //pokemons.Add(squirtle);

            client = new RestClient("https://pokeapi.co/api/v2/");
            request = new RestRequest("pokemon/psyduck/");
            response = client.Get(request);
            Pokemon psyduck = JsonConvert.DeserializeObject<Magikarp>(response.Content);
            //pokemons.Add(psyduck);

            client = new RestClient("https://pokeapi.co/api/v2/");
            request = new RestRequest("pokemon/charmander/");
            response = client.Get(request);
            Pokemon charmander = JsonConvert.DeserializeObject<Magikarp>(response.Content);
            //pokemons.Add(charmander);

            client = new RestClient("https://pokeapi.co/api/v2/");
            request = new RestRequest("pokemon/totodile/");     
            response = client.Get(request);
            Pokemon totodile = JsonConvert.DeserializeObject<Magikarp>(response.Content);

            Console.WriteLine(totodile.stats[0].Name);

            //pokemons.Add(totodile);
        }
        private static void Main(string[] args)
        {
            Start();


           /* while (f1.IsAlive() && f2.IsAlive())
            {
                int dmg1 = f1.Attack();

                f2.Hurt(dmg1);

                int dmg2 = f2.Attack();

                f1.Hurt(dmg2);

                Console.WriteLine(f2.name + "'s hp is " + f2.GetHp());
                Console.WriteLine(f1.name + "'s hp is " + f1.GetHp());

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
                } */
         

            Console.ReadLine();
        }
    }
}