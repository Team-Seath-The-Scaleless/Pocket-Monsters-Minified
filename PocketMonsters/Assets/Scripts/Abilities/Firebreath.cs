namespace Abilities
{
    using System;

    public class Firebreath : SpecialAbility
    {
        public const int FirebreathHeal = 2;
        public const int FirebreathDamage = 3; // if pokemon max health = ~20/30.
        public const AbilityType FirebreathSpellType = AbilityType.Battle;
        public const int FirebreathHitChance = 8;
        bool FirebreathHit;

        protected Firebreath(int FirebreathHeal, int FirebreathDamage)
            : base(FirebreathSpellType, FirebreathHitChance)
        {
            FirebreathHit = targetHit();
        }
        // do dmg+heal method , allyCurrentHP + FlamebreathHeal  and EnemyCurrentHP - Flamebreath Damage
    }
}