namespace Interfaces
{
    using System.Collections.Generic;

    using Pokemons;

    public interface IPokemon
    {
        int Health { get; }

        int MaxHealth { get; }

        bool IsAlive { get; }

        int Speed { get; }

        int Attack { get; }

        int Defense { get; }

        int SpecialAttack { get; }

        int SpecialDefense { get; }

        PokemonType Type { get; }

        IList<IAbility> Abilities { get; }

        int currentlyActive { get; }

        void TakeDamage(int damage);

        void Heal(int health);

        void LearnAbility(IAbility ability);

        void ForgetAbility(IAbility ability);
    }
}
