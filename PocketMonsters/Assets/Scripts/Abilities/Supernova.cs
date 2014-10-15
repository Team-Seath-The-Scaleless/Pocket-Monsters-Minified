namespace Abilities
{
    using System;

    public class Supernova : SpecialAbility
    {
        public const int SupernovaDamage = 10;

        public const int SupernovaHitChance = 5;

        public const int SupernovaCooldown = 3;

        public const string SupernovaHitMessage = "The Supernova released the ultimate force!";

        public const string SupernovaMissMessage = "Supernova has missed the target!";

        protected Supernova()
            : base(AbilityType.Battle, SupernovaHitChance)
        {
            this.SupernovaHit = this.TargetIsHit();
        }

        public bool SupernovaHit { get; private set; }
    }
}