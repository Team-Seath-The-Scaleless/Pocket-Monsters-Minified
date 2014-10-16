namespace Abilities
{
    using System;

    using Interfaces;

    public class Flamestrike : SpecialAbility, IDamageAbility
    {
        private const int FlamestrikeDamage = 9;

        private const int FlamestrikeHitChance = 7;

        private const int FlamestrikeCooldown = 2;

        private const string FlamestrikeHitMessage = "The enemy minion burst into flame!";

        private const string FlamestrikeMissMessage = "Flamestrike has missed the target!";

        public Flamestrike()
            : base(AbilityType.Fire, FlamestrikeHitChance,
            FlamestrikeCooldown, FlamestrikeHitMessage, FlamestrikeMissMessage)
        {
            this.Damage = FlamestrikeDamage;
        }

        public int Damage { get; private set; }
    }
}