namespace Creatures
{
    using System.Collections.Generic;

    using Interfaces;
    using Pokemons;

    public class Nakov : EnemyNpc
    {
        private static readonly IList<IPokemon> NakovPokemons =
            new List<IPokemon> { new Pesho(), new Gosho(), new Drunkemon(), new Separatist() }; 

        public Nakov()
            : base(NakovPokemons, null)
        {
        }
    }
}
