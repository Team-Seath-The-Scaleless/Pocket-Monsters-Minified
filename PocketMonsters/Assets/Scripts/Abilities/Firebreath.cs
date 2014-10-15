namespace Abilities
{
    using System;

    public class Firebreath : SpecialAbility
    {
        public const int FirebreathHeal = 2;

        public const int FirebreathDamage = 3; 

        public const int FirebreathHitChance = 8;

        public const int FirebreathCooldown = 1;

        public const string FirebreathHitMessage = "The force of fire stole some hit points from your enemy!";

        public const string FirebreathMissMessage = "Firebreath has missed the target!";

        protected Firebreath()
            : base(AbilityType.Battle, FirebreathHitChance)
        {
            this.FirebreathHit = this.TargetIsHit();
        }

        public bool FirebreathHit { get; private set; }
    }
}