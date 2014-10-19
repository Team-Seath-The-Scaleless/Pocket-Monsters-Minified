﻿namespace Abilities
{
    using System;
    using Interfaces;

    public class Flamestrike : DamageAbility
    {
        private const int FlamestrikeDamage = 9;
        private const int FlamestrikeHitChance = 7;
        private const int FlamestrikeCooldown = 2;
        private const string FlamestrikeHitMessage = "The enemy minion burst into flame!";
        private const string FlamestrikeMissMessage = "Flamestrike has missed the target!";

        public Flamestrike()
            : base(FlamestrikeDamage, AbilityType.Fire, FlamestrikeHitChance, FlamestrikeCooldown,
            FlamestrikeHitMessage, FlamestrikeMissMessage)
        { }
    }
}