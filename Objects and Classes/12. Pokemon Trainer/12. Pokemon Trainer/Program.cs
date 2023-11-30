using System;
using System.Collections.Generic;
using System.Linq;

class Trainer
{
    public string Name { get; }
    public int Badges { get; private set; }
    public List<Pokemon> PokemonCollection { get; }

    public Trainer(string name)
    {
        Name = name;
        Badges = 0;
        PokemonCollection = new List<Pokemon>();
    }

    public void AddPokemon(Pokemon pokemon)
    {
        PokemonCollection.Add(pokemon);
    }

    public void CheckElement(string element)
    {
        if (PokemonCollection.Any(p => p.Element == element))
        {
            Badges++;
        }
        else
        {
            foreach (var pokemon in PokemonCollection)
            {
                pokemon.Health -= 10;
            }

            PokemonCollection.RemoveAll(p => p.Health <= 0);
        }
    }
}

class Pokemon
{
    public string Name { get; }
    public string Element { get; }
    public int Health { get; set; }

    public Pokemon(string name, string element, int health)
    {
        Name = name;
        Element = element;
        Health = health;
    }
}

class Program
{
    static void Main()
    {
        Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

        string input;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            string[] inputInfo = input.Split();
            string trainerName = inputInfo[0];
            string pokemonName = inputInfo[1];
            string pokemonElement = inputInfo[2];
            int pokemonHealth = int.Parse(inputInfo[3]);

            Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

            if (!trainers.ContainsKey(trainerName))
            {
                Trainer trainer = new Trainer(trainerName);
                trainers.Add(trainerName, trainer);
            }

            trainers[trainerName].AddPokemon(pokemon);
        }

        while ((input = Console.ReadLine()) != "End")
        {
            string element = input;

            foreach (var trainer in trainers.Values)
            {
                trainer.CheckElement(element);
            }
        }

        foreach (var trainer in trainers.OrderByDescending(t => t.Value.Badges))
        {
            Console.WriteLine($"{trainer.Value.Name} {trainer.Value.Badges} {trainer.Value.PokemonCollection.Count}");
        }
    }
}

