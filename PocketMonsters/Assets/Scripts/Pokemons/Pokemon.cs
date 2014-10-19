namespace Pokemons
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Interfaces;
    using Abilities;

    public abstract class Pokemon : IPokemon
    {
        protected Pokemon(int health, int attackDamage, int specialAttack, PokemonType type)
        {
            this.CurrentHealth = health;
            this.MaxHealth = health;
            this.AttackDamage = attackDamage;
            this.Type = type;
            this.IsAlive = true;
            //this.Abilities = new List<IAbility> { new NormalAttack(this.AttackDamage) };
            this.CurrentlyActive = false;
        }

        public int CurrentHealth { get;  set; }

        public int MaxHealth { get; protected set; }

        public int AttackDamage { get; protected set; }

        public bool IsAlive { get; set; }

        public PokemonType Type { get; protected set; }

        public IList<IAbility> Abilities { get; protected set; }

        public bool CurrentlyActive { get; set; }
        
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
