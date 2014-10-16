namespace Abilities
{
    using System;

    using Interfaces;

    public class Supernova : SpecialAbility, IDamageAbility
    {
        private const int SupernovaDamage = 16;

        private const int SupernovaHitChance = 5;

        private const int SupernovaCooldown = 4;

        private const string SupernovaHitMessage = "The Supernova released the ultimate force!";

        private const string SupernovaMissMessage = "Supernova has missed the target!";

        public Supernova()
            : base(AbilityType.Lightning, SupernovaHitChance,
            SupernovaCooldown, SupernovaHitMessage, SupernovaMissMessage)
        {
            this.Damage = SupernovaDamage;
        }

        public int Damage { get; private set; }
    }
}