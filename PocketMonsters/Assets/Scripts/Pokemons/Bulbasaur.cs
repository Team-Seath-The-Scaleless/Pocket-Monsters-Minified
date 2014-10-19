namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class Bulbasaur : Pokemon
    {
        private const int Health = 38;
        private const int NormalAttack = 5;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new Eruption(),
                new Cataclysm(),
                new SandStorm(),
                new Aftershock()
            };

        public Bulbasaur() :
            base(Bulbasaur.Health, Bulbasaur.NormalAttack, PokemonType.Grass)
        {
            base.Abilities = this.abilities;
        }
    }
}
