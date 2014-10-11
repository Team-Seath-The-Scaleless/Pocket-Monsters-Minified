namespace Creatures
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using Interfaces;
    using Abilities;

    public abstract class Pokemon : IPokemon
    {
        protected Pokemon(int health, int attack, int defense, int specialAttack, int speed, int specialDefense, PokemonType type)
        {
            this.Health = health;
            this.MaxHealth = health;
            this.Speed = speed;
            this.Attack = attack;
            this.Defense = defense;
            this.SpecialAttack = specialAttack;
            this.SpecialDefense = specialDefense;
            this.Type = type;
            this.IsAlive = true;
            this.Abilities = new List<IAbility> { new NormalAttack(this.Attack) };
        }

        public int Health { get; protected set; }

        public int MaxHealth { get; protected set; }

        public bool IsAlive { get; protected set; }

        public int Speed { get; protected set; }

        public int Attack { get; protected set; }

        public int Defense { get; protected set; }

        public int SpecialAttack { get; protected set; }

        public int SpecialDefense { get; protected set; }

        public PokemonType Type { get; protected set; }

        public IList<IAbility> Abilities { get; protected set; }

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
            if (this.Abilities.Contains(ability) && this.Abilities.Count <= 1))
            {
                throw new InvalidOperationException();
            }

            this.Abilities.Remove(ability);
        }
    }
}
