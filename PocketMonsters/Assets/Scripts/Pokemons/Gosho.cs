namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class Gosho : Pokemon
    {
        private const int NormalAttack = 5;
        private const int Health = 38;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new Thundershock(),
                new Firebreath(),
                new Aftershock(),
                new Frostbolt()
            };

        public Gosho() :
            base(Gosho.Health, Gosho.NormalAttack, PokemonType.Grass)
        {
            base.Abilities = this.abilities;
        }
    }
}
