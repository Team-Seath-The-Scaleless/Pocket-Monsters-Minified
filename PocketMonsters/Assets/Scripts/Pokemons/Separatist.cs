namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class Separatist : Pokemon
    {
        private const int NormalAttack = 4;
        private const int Health = 42;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new SuperNova(),
                new Armageddon(),
                new GlacialStorm(),
                new Cataclysm()
            };

        public Separatist() :
            base(Separatist.Health, Separatist.NormalAttack, PokemonType.Earth)
        {
            base.Abilities = this.abilities;
        }
    }
}
