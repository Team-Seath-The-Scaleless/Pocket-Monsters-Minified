namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class Pesho : Pokemon
    {
        private const int NormalAttack = 6;
        private const int Health = 48;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new SandStorm(),
                new GlacialStorm(),
                new Eruption(),
                new Balefrost()
            };

        public Pesho() :
            base(Pesho.Health, Pesho.NormalAttack, PokemonType.Frost)
        {
            base.Abilities = this.abilities;
        }
    }
}
