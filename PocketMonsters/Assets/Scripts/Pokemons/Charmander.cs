namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class Charmander : Pokemon
    {
        private const int NormalAttack = 5;
        private const int Health = 40;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new Armageddon(),
                new Enflame(),
                new Firebreath(),
                new Flamestrike()
            };

        public Charmander() :
            base(Charmander.Health, Charmander.NormalAttack, PokemonType.Fire)
        {
            base.Abilities = this.abilities;
        }
    }
}
