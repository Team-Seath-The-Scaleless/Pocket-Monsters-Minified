﻿namespace Abilities
{
    using System;

    public class Supernova : SpecialAbility
    {
        public const int SupernovaDamage = 10; // if pokemon max health = ~20/30.
        public const AbilityType SupernovaSpellType = AbilityType.Battle;
        public const int SupernovaHitChance = 5;
        bool SupernovaHit;

        protected Supernova(int SupernovaDamage)
            : base(SupernovaSpellType, SupernovaHitChance)
        {
            SupernovaHit = targetHit();
        }
        // do dmg method , enemyCurrentHP - SupernovaDamage 
    }
}