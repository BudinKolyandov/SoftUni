using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class PokemonTrainer
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] trainerInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = trainerInfo[0];
                string pokemonName = trainerInfo[1];
                string pokemonElement = trainerInfo[2];
                int pokemonHealth = int.Parse(trainerInfo[3]);
                                
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer(trainerName);
                }
                trainers[trainerName].pokemonList
                    .Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));


            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers.Values)
                {
                    if (trainer.pokemonList.Any(x=>x.Element == command))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.pokemonList)
                        {
                            pokemon.Health -= 10;
                            
                        }
                    }
                    for (int i = 0; i < trainer.pokemonList.Count; i++)
                    {
                        if (trainer.pokemonList[i].Health <=0)
                        {
                            trainer.pokemonList.Remove(trainer.pokemonList[i]);
                        }
                    }
                }
            }

            foreach (var trainer in trainers.Values.OrderByDescending(x=>x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.pokemonList.Count}");
            }

        }
    }
}
