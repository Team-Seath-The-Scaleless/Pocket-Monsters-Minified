namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class Grandfatty : Pokemon
    {
        private const int NormalAttack = 6;
        private const int Health = 45;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new Eruption(),
                new Recharge(),
                new Firebreath(),
                new Cataclysm()
            };

        public Grandfatty() :
            base(Grandfatty.Health, Grandfatty.NormalAttack, PokemonType.Frost)
        {
            base.Abilities = this.abilities;
        }
    }
}
