namespace Abilities
{
    using System;

    public class Thundershock : SpecialAbility
    {
        private const int ThundershockDamage = 5;

        private const int ThundershockHitChance = 8;

        private const int ThundershockCooldown = 1;

        private const string ThundershockHitMessage = "The target has been thudnershocked!";

        private const string ThundershockMissMessage = "Thundershock has missed the target!";

        protected Thundershock()
            : base(AbilityType.Battle, ThundershockHitChance,
            ThundershockCooldown, ThundershockHitMessage, ThundershockMissMessage)
        {
            this.Damage = ThundershockDamage;
        }

        public int Damage { get; private set; }
    }
}
