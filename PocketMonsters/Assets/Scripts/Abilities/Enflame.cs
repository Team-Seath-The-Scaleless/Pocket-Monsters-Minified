namespace Abilities
{
    using System;

    using Interfaces;

    public class Enflame : SpecialAbility, IDamageAbility
    {
        private const int EnflameDamage = 13;

        private const int EnflameHitChance = 5;

        private const int EnflameCooldown = 3;

        private const string EnflameHitMessage = "The whole body of your enemy starts burning!";

        private const string EnflameMissMessage = "Enflame missed!";

        public Enflame()
            : base(AbilityType.Fire, EnflameHitChance,
            EnflameCooldown, EnflameHitMessage, EnflameMissMessage)
        {
            this.Damage = EnflameDamage;
        }

        public int Damage { get; private set; }
    }
}