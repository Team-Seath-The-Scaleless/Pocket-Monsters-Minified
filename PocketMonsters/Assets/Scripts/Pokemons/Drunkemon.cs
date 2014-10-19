namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class Drunkemon : Pokemon
    {
        private const int NormalAttack = 5;
        private const int Health = 39;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new Balefrost(),
                new GlacialStorm(),
                new Lightning(),
                new Recharge()
            };

        public Drunkemon() :
            base(Drunkemon.Health, Drunkemon.NormalAttack, PokemonType.Fire)
        {
            base.Abilities = this.abilities;
        }
    }
}
