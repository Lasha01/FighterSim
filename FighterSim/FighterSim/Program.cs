using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

namespace FighterSim
{
    class Program
    {
        public static List<Pokemon> pokemons = new List<Pokemon>();
        static Random rng = new Random();

        static void Start()
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");
            RestRequest request = new RestRequest("pokemon/magikarp/");
            IRestResponse response = client.Get(request);
            Magikarp magikarp = JsonConvert.DeserializeObject<Magikarp>(response.Content);
            magikarp.UpdateStats();
            pokemons.Add(magikarp);

            client = new RestClient("https://pokeapi.co/api/v2/");
            request = new RestRequest("pokemon/squirtle/");
            response = client.Get(request);
            Squirtle squirtle = JsonConvert.DeserializeObject<Squirtle>(response.Content);
            squirtle.UpdateStats();
            pokemons.Add(squirtle);

            client = new RestClient("https://pokeapi.co/api/v2/");
            request = new RestRequest("pokemon/psyduck/");
            response = client.Get(request);
            Psyduck psyduck = JsonConvert.DeserializeObject<Psyduck>(response.Content);
            psyduck.UpdateStats();
            pokemons.Add(psyduck);

            client = new RestClient("https://pokeapi.co/api/v2/");
            request = new RestRequest("pokemon/charmander/");
            response = client.Get(request);
            Charmander charmander = JsonConvert.DeserializeObject<Charmander>(response.Content);
            charmander.UpdateStats();
            pokemons.Add(charmander);

            client = new RestClient("https://pokeapi.co/api/v2/");
            request = new RestRequest("pokemon/totodile/");
            response = client.Get(request);
            Totodile totodile = JsonConvert.DeserializeObject<Totodile>(response.Content);
            totodile.UpdateStats();
            pokemons.Add(totodile);
        }

        private static void Main(string[] args)
        {
            Start();
            Console.WriteLine("PokeKombat Simulator 4");
            int randomPokemon = rng.Next(pokemons.Count);
            int nextPokemon = rng.Next(pokemons.Count);

            Console.CursorVisible = false;

            int pokemon1 = ChoosePokemon("Who do you want to play as? \nChoose between: ");
            Pokemon p1 = pokemons[pokemon1];
            Console.Clear();

            int pokemon2 = ChoosePokemon("Who do you want to play against? \nChoose between: ");
            while (true)
            {

                if (pokemon2 == pokemon1)
                {
                    Console.WriteLine("Choose again!\nPress 'any key'!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {

                    break;
                }
            }
            Pokemon p2 = pokemons[pokemon2];

            Console.CursorVisible = true;
            int y = 0;


            while (p1.IsAlive() && p2.IsAlive())
            {

                Console.WriteLine(y);
                
                p2.Hurt(p1.Attack());
                p1.Hurt(p2.Attack());

                Console.WriteLine(p1.SetName() + "'s hp is " + p1.GetHp());
                Console.WriteLine(p2.SetName() + "'s hp is " + p2.GetHp());

                if (!p1.IsAlive() && !p2.IsAlive())
                {
                    Console.WriteLine("Congratulations till båda!");
                }
                else if (!p1.IsAlive())
                {
                    Console.WriteLine("Congratulations {0}!", p2.SetName());
                }
                else if (!p2.IsAlive())
                {
                    Console.WriteLine("Congratulations {0}!", p1.SetName());
                }

                Console.WriteLine("Press any button to continue...");
                Console.ReadKey();
                Console.Clear();
            }

            int ChoosePokemon(string message)
            {
                int choice = 1;
                while (true)
                {
                    Console.WriteLine(message);
                    for (int i = 0; i < pokemons.Count; i++) //Körs så många gånger som pokemons finns
                    {
                        Console.WriteLine(" " + pokemons[i].SetName()); //Skriver ut listorna
                    }
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (choice == (1 + i))
                        {
                            Console.SetCursorPosition(0, i + 2); //Sätter ut pilen 
                        }
                    }
                    Console.Write(">");
                    Console.SetCursorPosition(0, 14);
                    ConsoleKeyInfo keyInfo = Console.ReadKey(); ;
                    if (keyInfo.Key == ConsoleKey.W || keyInfo.Key == ConsoleKey.UpArrow) { choice--; } //Rör pilen upp och ned
                    if (keyInfo.Key == ConsoleKey.S || keyInfo.Key == ConsoleKey.DownArrow) { choice++; }
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        for (int i = 0; i < pokemons.Count; i++) //Man väljer karaktär med pilen
                        {
                            if (choice == 1 + i)
                            {
                                return choice - 1;
                            }
                        }
                    }

                    if (choice < 1) { choice = pokemons.Count; } // Gör så att man kan bläddra mella karaktären från olika håll, både uppifrån och nedifrån
                    if (choice > pokemons.Count) { choice = 1; }
                    Console.Clear();
                }
            }
        }
    }
}



