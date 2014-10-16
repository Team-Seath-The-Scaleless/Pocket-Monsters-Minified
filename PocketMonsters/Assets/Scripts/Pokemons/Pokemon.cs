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
        protected Pokemon(int health, int attack, int specialAttack, PokemonType type)
        {
            this.CurrentHealth = health;
            this.MaxHealth = health;
            this.Attack = attack;
            this.SpecialAttack = specialAttack;
            this.Type = type;
            this.IsAlive = true;
            this.Abilities = new List<IAbility> { new NormalAttack(this.Attack) };
            this.CurrentlyActive = false;
        }

        public int CurrentHealth { get;  set; }

        public int MaxHealth { get; protected set; }

        public int Attack { get; protected set; }

        public int SpecialAttack { get; protected set; }

        public bool IsAlive { get; set; }

        public PokemonType Type { get; protected set; }

        public IList<IAbility> Abilities { get; protected set; }

		public bool CurrentlyActive { get; set; }

        // Lol... Better Attack(target){}
        public void TakeDamage(int attack)
        {
            this.CurrentHealth -= attack;
            if (this.CurrentHealth <= 0)
            {
                this.CurrentHealth = 0;
                this.IsAlive = false;
            }
        }

        public void Heal(int health)
        {
            this.CurrentHealth += health;
            if (this.CurrentHealth > this.MaxHealth)
            {
                this.CurrentHealth = this.MaxHealth;
            }
        }

        public void LearnAbility(IAbility ability)
        {
            if (!this.Abilities.Contains(ability))
            {
                this.Abilities.Add(ability);
            }
        }

        public void ForgetAbility(IAbility ability)
        {
            if (this.Abilities.Contains(ability) && this.Abilities.Count <= 1)
            {
                throw new InvalidOperationException();
            }

            this.Abilities.Remove(ability);
        }
    }
}
