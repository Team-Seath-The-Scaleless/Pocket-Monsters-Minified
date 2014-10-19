namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class Rattata : Pokemon
    {
        private const int NormalAttack = 4;
        private const int Health = 41;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new Firebreath(),
                new Cataclysm(),
                new Frostbolt(),
                new IceBlade()
            };

        public Rattata() :
            base(Rattata.Health, Rattata.NormalAttack, PokemonType.Earth)
        {
            base.Abilities = this.abilities;
        }
    }
}
