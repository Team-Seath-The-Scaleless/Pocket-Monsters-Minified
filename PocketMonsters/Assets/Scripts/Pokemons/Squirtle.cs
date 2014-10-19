namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class Squirtle : Pokemon
    {
        private const int NormalAttack = 3;
        private const int Health = 43;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new Balefrost(),
                new Frostbolt(),
                new GlacialStorm(),
                new Eruption()
            };

        public Squirtle() :
            base(Squirtle.Health, Squirtle.NormalAttack, PokemonType.Water)
        {
            base.Abilities = this.abilities;
        }
    }
}
