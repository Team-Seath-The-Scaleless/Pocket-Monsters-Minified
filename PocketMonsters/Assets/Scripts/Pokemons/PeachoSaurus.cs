namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class PeachoSaurus : Pokemon
    {
        private const int NormalAttack = 5;
        private const int Health = 40;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new SuperNova(),
                new Thundershock(),
                new Firebreath(),
                new Armageddon()
            };

        public PeachoSaurus() :
            base(PeachoSaurus.Health, PeachoSaurus.NormalAttack, PokemonType.Fire)
        {
            base.Abilities = this.abilities;
        }
    }
}
