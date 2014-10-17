namespace Creatures
{
    using System.Collections.Generic;

    using Interfaces;
    using Pokemons;

    public class Tosho : EnemyNpc
    {
        private static readonly IList<IPokemon> ToshoPokemons =
            new List<IPokemon> { new Ginka(), new Grandfatty(), new Pesho(), new Gosho() };

        public Tosho()
            : base(ToshoPokemons, null)
        {
        }
    }
}
