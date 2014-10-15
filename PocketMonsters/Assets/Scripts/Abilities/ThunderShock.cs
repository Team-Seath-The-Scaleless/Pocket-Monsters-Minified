namespace Abilities
{
    using System;

    public class Thundershock : SpecialAbility
    {
        public const int ThundershockDamage = 5; 

        public const int ThundershockHitChance = 8;

        public const int ThundershockCooldown = 1;

        public const string ThundershockHitMessage = "The target has been thudnershocked!";

        public const string ThundershockMissMessage = "Thundershock has missed the target!";

        protected Thundershock()
            : base(AbilityType.Battle, ThundershockHitChance)
        {
            this.ThundershockHit = this.TargetIsHit();
        }

        public bool ThundershockHit { get; private set; }
    }
}
