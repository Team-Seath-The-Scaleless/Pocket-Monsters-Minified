namespace Abilities
{
    using System;
    using Interfaces;

    public class SandStorm : DamageAbility
    {
        private const int SandStormDamage = 11;
        private const int SandStormHitChance = 6;
        private const int SandStormCooldown = 3;
        private const string SandStormHitMessage = "A massive sandstorm initialize and hit the enemy!";
        private const string SandStormMissMessage = "Sandstorm failed to start!";

        public SandStorm()
            : base(SandStormDamage, AbilityType.Earth, SandStormHitChance, SandStormCooldown,
            SandStormHitMessage, SandStormMissMessage)
        { }
    }
}