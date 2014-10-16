﻿namespace Abilities
{
    using System;

    using Interfaces;

    public class Armageddon : SpecialAbility, IDamageAbility
    {
        private const int ArmageddonDamage = 15;

        private const int ArmageddonHitChance = 3;

        private const int ArmageddonCooldown = 4;

        private const string ArmageddonHitMessage = "The unstopable flames burn everything around!";

        private const string ArmageddonMissMessage = "Summoning Armageddon failed!";

        public Armageddon()
            : base(AbilityType.Battle, ArmageddonHitChance,
            ArmageddonCooldown, ArmageddonHitMessage, ArmageddonMissMessage)
        {
            this.Damage = ArmageddonDamage;
        }

        public int Damage { get; private set; }
    }
}