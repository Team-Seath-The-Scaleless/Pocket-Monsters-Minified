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
            this.Health = health;
            this.MaxHealth = health;
            this.Attack = attack;
            this.SpecialAttack = specialAttack;
            this.Type = type;
            this.IsAlive = true;
            this.Abilities = new List<IAbility> { new NormalAttack(this.Attack) };
            this.CurrentlyActive = false;
        }

        public int Health { get; protected set; }

        public int Attack { get; protected set; }

        public int SpecialAttack { get; protected set; }

        public bool IsAlive { get; protected set; }

        public PokemonType Type { get; protected set; }

        public IList<IAbility> Abilities { get; protected set; }

		public bool CurrentlyActive { get; set; }

        // Lol... Better Attack(target){}
        public void TakeDamage(int damage)
        {
            this.Health -= damage;
            if (this.Health <= 0)
            {
                this.Health = 0;
                this.IsAlive = false;
            }
        }

        public void Heal(int health)
        {
            this.Health += health;
            if (this.Health > this.MaxHealth)
            {
                this.Health = this.MaxHealth;
            }
        }

        public void LearnAbility(IAbility ability)
        {
            // should probably check for max number of abilities

            if (!this.Abilities.Contains(ability))
            {
                this.Abilities.Add(ability);
            }
        }

        public void ForgetAbility(IAbility ability)
        {
            // should probably add custom exception
            if (this.Abilities.Contains(ability) && this.Abilities.Count <= 1)
            {
                throw new InvalidOperationException();
            }

            this.Abilities.Remove(ability);
        }

        public int MaxHealth { get; set; }
    }
}
