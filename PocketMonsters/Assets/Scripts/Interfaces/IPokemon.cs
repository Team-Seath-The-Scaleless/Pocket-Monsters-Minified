namespace Interfaces
{
    using System.Collections.Generic;

    using Pokemons;

    public interface IPokemon
    {



        int CurrentHealth { get; set; }


        int MaxHealth { get; }

		bool IsAlive { get; set; }

        int Attack { get; }

        int SpecialAttack { get; }

        PokemonType Type { get; }

        IList<IAbility> Abilities { get; }

		bool CurrentlyActive { get; set; }

        void TakeDamage(int attack);

        void Heal(int health);

        void LearnAbility(IAbility ability);

        void ForgetAbility(IAbility ability);
    }
}
