namespace Abilities
{
    using System;

    using Interfaces;

    public class Sandstorm : DamageAbility
    {
        private const int SandstormDamage = 11;

        private const int SandstormHitChance = 6;

        private const int SandstormCooldown = 3;

        private const string SandstormHitMessage = "A massive sandstorm initialize and hit the enemy!";

        private const string SandstormMissMessage = "Sandstorm failed to start!";

        public Sandstorm()
            : base(AbilityType.Earth, SandstormHitChance,
            SandstormCooldown, SandstormHitMessage, SandstormMissMessage, SandstormDamage)
        {

        }
    }
}