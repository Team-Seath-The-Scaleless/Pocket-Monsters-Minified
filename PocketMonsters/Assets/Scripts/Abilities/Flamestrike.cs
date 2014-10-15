namespace Abilities
{
    using System;

    public class Flamestrike : SpecialAbility
    {
        public const int FlamestrikeDamage = 6;

        public const int FlamestrikeHitChance = 7;

        public const int FlamestrikeCooldown = 2;

        public const string FlamestrikeHitMessage = "The enemy minion burst into flame!";

        public const string FlamestrikeMissMessage = "Flamestrike has missed the target!";

        protected Flamestrike()
            : base(AbilityType.Battle, FlamestrikeHitChance)
        {
            this.FlamestrikeHit = this.TargetIsHit();
        }

        public bool FlamestrikeHit { get; private set; }
    }
}