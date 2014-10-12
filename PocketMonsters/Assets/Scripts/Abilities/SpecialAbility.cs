namespace Abilities
{
    using System;

    public abstract class SpecialAbility : Ability
    {
        private readonly Random hitChanceCalculator = new Random();

        protected SpecialAbility(AbilityType type, int spellHitChance)
            : base(type)
        {
        }

        public int SpellHitChance { get; protected set; }
        
        protected bool TargetIsHit()
        {
            int currentHitChance = this.hitChanceCalculator.Next(1, 11);

            return this.SpellHitChance >= currentHitChance;
        }
    }
}
