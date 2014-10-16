namespace Abilities
{
    using System;

    public class Balefrost : SpecialAbility
    {
        private const int BalefrostDamage = 7;

        private const int BalefrostHitChance = 8;

        private const int BalefrostCooldown = 3;

        private const string BalefrostHitMessage = "Huge ice spikes shatter the ground and hit the enemy!";

        private const string BalefrostMissMessage = "Balefrost has missed the target!";

        public Balefrost()
            : base(AbilityType.Battle, BalefrostHitChance,
            BalefrostCooldown, BalefrostHitMessage, BalefrostMissMessage)
        {
            this.Damage = BalefrostDamage;
        }

        public int Damage { get; private set; }
    }
}