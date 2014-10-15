namespace Abilities
{
    using System;

    public class Flamestrike : SpecialAbility
    {
        private const int FlamestrikeDamage = 6;

        private const int FlamestrikeHitChance = 7;

        private const int FlamestrikeCooldown = 2;

        private const string FlamestrikeHitMessage = "The enemy minion burst into flame!";

        private const string FlamestrikeMissMessage = "Flamestrike has missed the target!";

        protected Flamestrike()
            : base(AbilityType.Battle, FlamestrikeHitChance,
            FlamestrikeCooldown, FlamestrikeHitMessage, FlamestrikeMissMessage)
        {
            this.Damage = FlamestrikeDamage;
        }

        public int Damage { get; private set; }
    }
}