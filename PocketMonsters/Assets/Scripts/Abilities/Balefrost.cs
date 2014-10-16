namespace Abilities
{
    using System;

    using Interfaces;

    public class Balefrost : SpecialAbility, IDamageAbility
    {
        private const int BalefrostDamage = 8;

        private const int BalefrostHitChance = 8;

        private const int BalefrostCooldown = 2;

        private const string BalefrostHitMessage = "Huge ice spikes shatter the ground and hit the enemy!";

        private const string BalefrostMissMessage = "Balefrost has missed the target!";

        public Balefrost()
            : base(AbilityType.Frost, BalefrostHitChance,
            BalefrostCooldown, BalefrostHitMessage, BalefrostMissMessage)
        {
            this.Damage = BalefrostDamage;
        }

        public int Damage { get; private set; }
    }
}