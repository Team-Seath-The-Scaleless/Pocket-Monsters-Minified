namespace Pokemons
{
    using System.Collections.Generic;
    using Abilities;
    using Interfaces;

    public class Meowth : Pokemon
    {
        private const int NormalAttack = 6;
        private const int Health = 46;
        private IList<IAbility> abilities =
            new List<IAbility>()
            {
                new Thundershock(),
                new Frostbolt(),
                new Recharge(),
                new Flamestrike()
            };

        public Meowth() :
            base(Meowth.Health, Meowth.NormalAttack, PokemonType.Lightning)
        {
            base.Abilities = this.abilities;
        }
    }
}
