namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class Sentinel : Pokemon
    {
        private const int NormalAttack = 3;
        private const int Health = 45;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new Frostbolt(),
                new Balefrost(),
                new GlacialStorm(),
                new Recharge()
            };

        public Sentinel() :
            base(Sentinel.Health, Sentinel.NormalAttack, PokemonType.Lightning)
        {
            base.Abilities = this.abilities;
        }
    }
}
