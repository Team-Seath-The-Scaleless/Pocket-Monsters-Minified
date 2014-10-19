namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class Roggenrola : Pokemon
    {
        private const int NormalAttack = 4;
        private const int Health = 40;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new Flamestrike(),
                new Eruption(),
                new Lightning(),
                new Enflame()
            };

        public Roggenrola() :
            base(Roggenrola.Health, Roggenrola.NormalAttack, PokemonType.Frost)
        {
            base.Abilities = this.abilities;
        }
    }
}
