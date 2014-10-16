namespace Abilities
{
    using System;

    public class Frostbolt : SpecialAbility
    {
        private const int FrostboltDamage = 4;

        private const int FrostboltHitChance = 9;

        private const int FrostboltCooldown = 1;

        private const string FrostboltHitMessage = "The target has been hit by a massive frostbolt!";

        private const string FrostboltMissMessage = "Frostbolt has missed the target!";

        public Frostbolt()
            : base(AbilityType.Battle, FrostboltHitChance,
            FrostboltCooldown, FrostboltHitMessage, FrostboltMissMessage)
        {
            this.Damage = FrostboltDamage;
        }

        public int Damage { get; private set; }
    }
}