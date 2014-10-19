namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class Ginka : Pokemon
    {
        private const int NormalAttack = 3;
        private const int Health = 43;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new SuperNova(),
                new IceBlade(),
                new Eruption(),
                new GlacialStorm()
            };

        public Ginka() :
            base(Ginka.Health, Ginka.NormalAttack, PokemonType.Water)
        {
            base.Abilities = this.abilities;
        }
    }
}
