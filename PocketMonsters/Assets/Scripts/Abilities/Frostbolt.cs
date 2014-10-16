namespace Abilities
{
    using System;

    using Interfaces;

    public class Frostbolt : SpecialAbility, IDamageAbility
    {
        private const int FrostboltDamage = 5;

        private const int FrostboltHitChance = 9;

        private const int FrostboltCooldown = 1;

        private const string FrostboltHitMessage = "The target has been hit by a massive frostbolt!";

        private const string FrostboltMissMessage = "Frostbolt has missed the target!";

        public Frostbolt()
            : base(AbilityType.Frost, FrostboltHitChance,
            FrostboltCooldown, FrostboltHitMessage, FrostboltMissMessage)
        {
            this.Damage = FrostboltDamage;
        }

        public int Damage { get; private set; }
    }
}