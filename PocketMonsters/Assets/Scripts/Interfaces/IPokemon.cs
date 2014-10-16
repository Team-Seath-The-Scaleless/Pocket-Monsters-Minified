namespace Interfaces
{
    using System.Collections.Generic;

    using Pokemons;

    public interface IPokemon
    {
        int CurrentHealth { get; }

        int MaxHealth { get; }

        bool IsAlive { get; }

        int Attack { get; }

        int SpecialAttack { get; }

        PokemonType Type { get; }

        IList<IAbility> Abilities { get; }

		bool CurrentlyActive { get; set; }
			
        void TakeDamage(int damage);

        void Heal(int health);

        void LearnAbility(IAbility ability);

        void ForgetAbility(IAbility ability);
    }
}
