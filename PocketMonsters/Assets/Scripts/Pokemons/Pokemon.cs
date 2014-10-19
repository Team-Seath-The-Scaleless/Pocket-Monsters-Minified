namespace Pokemons
{
    using System;
    using System.Collections.Generic;

    using Interfaces;
    using Abilities;

    public abstract class Pokemon : IPokemon
    {
        protected Pokemon(int health, int attackDamage, PokemonType type)
        {
            this.CurrentHealth = health;
            this.MaxHealth = health;
            this.AttackDamage = attackDamage;
            this.IsAlive = true;
            this.CurrentlyActive = false;
            this.Type = type;
        }

        public int CurrentHealth { get;  set; }

        public int MaxHealth { get; protected set; }

        public int AttackDamage { get; protected set; }

        public bool IsAlive { get; set; }

        public bool CurrentlyActive { get; set; }

        public PokemonType Type { get; protected set; }

        public IList<IAbility> Abilities { get; protected set; }
                
        public void LearnAbility(IAbility ability)
        {
            if (!this.Abilities.Contains(ability))
            {
                this.Abilities.Add(ability);
            }
        }

        public void ForgetAbility(IAbility ability)
        {
            this.Abilities.Remove(ability);
        }
    }
}
