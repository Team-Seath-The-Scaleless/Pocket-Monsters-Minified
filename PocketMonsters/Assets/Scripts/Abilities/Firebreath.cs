namespace Abilities
{
    using System;

    public class Firebreath : SpecialAbility
    {
        private const int FirebreathHeal = 2;

        private const int FirebreathDamage = 3;

        private const int FirebreathHitChance = 8;

        private const int FirebreathCooldown = 1;

        private const string FirebreathHitMessage = "The force of fire stole some hit points from your enemy!";

        private const string FirebreathMissMessage = "Firebreath has missed the target!";

        protected Firebreath()
            : base(AbilityType.Battle, FirebreathHitChance,
            FirebreathCooldown, FirebreathHitMessage, FirebreathMissMessage)
        {
            this.Heal = FirebreathHeal;
            this.Damage = FirebreathDamage;
        }

        public int Heal { get; private set; }

        public int Damage { get; private set; }
    }
}