namespace Abilities
{
    using System;

    using Interfaces;

    public class Firebreath : DamageAbility
    {
        private const int FirebreathHeal = 4;

        private const int FirebreathDamage = 4;

        private const int FirebreathHitChance = 8;

        private const int FirebreathCooldown = 2;

        private const string FirebreathHitMessage = "The force of fire stole some hit points from your enemy!";

        private const string FirebreathMissMessage = "Firebreath has missed the target!";

        public Firebreath()
            : base(AbilityType.Fire, FirebreathHitChance,
            FirebreathCooldown, FirebreathHitMessage, FirebreathMissMessage,FirebreathDamage)
        {          
        }
    }
}