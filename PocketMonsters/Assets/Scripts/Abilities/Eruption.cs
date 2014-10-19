namespace Abilities
{
    using System;
    using Interfaces;

    public class Eruption : DamageAbility
    {
        private const int EruptionDamage = 7;
        private const int EruptionHeal = 5;
        private const int EruptionHitChance = 5;
        private const int EruptionCooldown = 4;
        private const string EruptionHitMessage = "The lava waves damages the enemy and restore your health!";
        private const string EruptionMissMessage = "Eruption has missed the target!";

        public Eruption()
            : base(EruptionDamage, AbilityType.Earth, EruptionHitChance, EruptionCooldown,
            EruptionHitMessage, EruptionMissMessage)
        { }
    }
}