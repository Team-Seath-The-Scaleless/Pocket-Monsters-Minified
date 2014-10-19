namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class Sheldon : Pokemon
    {
        private const int NormalAttack = 3;
        private const int Health = 44;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new Aftershock(),
                new Lightning(),
                new Flamestrike(),
                new Firebreath()
            };

        public Sheldon() :
            base(Sheldon.Health, Sheldon.NormalAttack, PokemonType.Lightning)
        {
            base.Abilities = this.abilities;
        }
    }
}
