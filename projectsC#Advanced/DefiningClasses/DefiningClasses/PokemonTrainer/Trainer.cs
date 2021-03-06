﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    class Trainer
    {
        public string Name { get; set; }

        public int Badges { get; set; } = 0;

        public List<Pokemon> pokemonList { get; set; }


        public Trainer(string name)
        {
            this.Name = name;

            this.Badges = 0;

            pokemonList = new List<Pokemon>();
        }
    }
}
