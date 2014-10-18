namespace Abilities
{
    using System;

    using Interfaces;

    public class Aftershock : DamageAbility
    {
        private const int AftershockDamage = 9;

        private const int AftershockHitChance = 7;

        private const int AftershockCooldown = 2;

        private const string AftershockHitMessage = "The ground starts splashing sonic waves and hits the enemy!";

        private const string AftershockMissMessage = "Aftershock has missed the target!";

        public Aftershock()
            : base(AbilityType.Earth, AftershockHitChance,
            AftershockCooldown, AftershockHitMessage, AftershockMissMessage, AftershockDamage)
        {
        }
    }
}