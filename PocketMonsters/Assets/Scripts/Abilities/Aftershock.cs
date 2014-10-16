namespace Abilities
{
    using System;

    public class Aftershock : SpecialAbility
    {
        private const int AftershockDamage = 8;

        private const int AftershockHitChance = 7;

        private const int AftershockCooldown = 2;

        private const string AftershockHitMessage = "The ground starts splashing sonic waves and hits the enemy!";

        private const string AftershockMissMessage = "Aftershock has missed the target!";

        public Aftershock()
            : base(AbilityType.Battle, AftershockHitChance,
            AftershockCooldown, AftershockHitMessage, AftershockMissMessage)
        {
            this.Damage = AftershockDamage;
        }

        public int Damage { get; private set; }
    }
}