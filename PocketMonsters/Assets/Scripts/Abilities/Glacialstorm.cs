namespace Abilities
{
    using System;

    using Interfaces;

    public class Glacialstorm : SpecialAbility, IDamageAbility
    {
        private const int GlacialstormDamage = 12;

        private const int GlacialstormHitChance = 9;

        private const int GlacialstormCooldown = 4;

        private const string GlacialstormHitMessage = "The Glacial Storm freezes your enemy blood!";

        private const string GlacialstormMissMessage = "Glacial Storm failed to hit!";

        public Glacialstorm()
            : base(AbilityType.Frost, GlacialstormHitChance,
            GlacialstormCooldown, GlacialstormHitMessage, GlacialstormMissMessage)
        {
            this.Damage = GlacialstormDamage;
        }

        public int Damage { get; private set; }
    }
}