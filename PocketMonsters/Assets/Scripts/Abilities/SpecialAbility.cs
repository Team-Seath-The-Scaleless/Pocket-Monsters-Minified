namespace Abilities
{
    using System;

    public abstract class SpecialAbility : Ability
    {
        Random hitChanceCalculation = new Random();
        private int spellHitChance;

        protected SpecialAbility(AbilityType type, int spellHitChance)
            : base(type)
        {
        }
        
        protected bool targetHit()
        {
            int currentHitChance = hitChanceCalculation.Next(1, 11);
            if (spellHitChance >= currentHitChance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
