namespace Interfaces
{
    using System.Collections.Generic;

    using Pokemons;

    public interface IPokemon
    {

		int Health { get; set;}

        int CurrentHealth { get; }


        int MaxHealth { get; }

		bool IsAlive { get; set; }

        int Attack { get; }

        int SpecialAttack { get; }

        PokemonType Type { get; }

        IList<IAbility> Abilities { get; }

		bool CurrentlyActive { get; set; }
			
        void TakeDamage(IPokemon target);

        void Heal(int health);

        void LearnAbility(IAbility ability);

        void ForgetAbility(IAbility ability);
    }
}
