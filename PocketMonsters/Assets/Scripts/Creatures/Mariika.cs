namespace Creatures
{
    using System.Collections.Generic;

    using Interfaces;
    using Pokemons;

    public class Mariika : EnemyNpc
    {
        private static readonly IList<IPokemon> MariikaPokemons =
            new List<IPokemon> { new Sheldon(), new PeachoSaurus(), new Roggenrola(), new Meowth() };

        public Mariika()
            : base(MariikaPokemons, null)
        {
        }
    }
}
