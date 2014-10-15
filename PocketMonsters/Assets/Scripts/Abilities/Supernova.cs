namespace Abilities
{
    using System;

    public class Supernova : SpecialAbility
    {
        private const int SupernovaDamage = 10;

        private const int SupernovaHitChance = 5;

        private const int SupernovaCooldown = 3;

        private const string SupernovaHitMessage = "The Supernova released the ultimate force!";

        private const string SupernovaMissMessage = "Supernova has missed the target!";

        protected Supernova()
            : base(AbilityType.Battle, SupernovaHitChance,
            SupernovaCooldown, SupernovaHitMessage, SupernovaMissMessage)
        {
            this.Damage = SupernovaDamage;
        }

        public int Damage { get; private set; }
    }
}