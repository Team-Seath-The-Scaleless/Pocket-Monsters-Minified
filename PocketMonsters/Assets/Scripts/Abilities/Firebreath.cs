namespace Abilities
{
    using System;

    public class Firebreath : SpecialAbility
    {
        public const int FirebreathHeal = 2;

        public const int FirebreathDamage = 3; // if pokemon max health = ~20/30.

        public const int FirebreathHitChance = 8;

        private bool firebreathHit;

        protected Firebreath(int firebreathHeal, int firebreathDamage)
            : base(AbilityType.Battle, FirebreathHitChance)
        {
            this.firebreathHit = this.TargetIsHit();
        }

        // do dmg+heal method , allyCurrentHP + FlamebreathHeal  and EnemyCurrentHP - Flamebreath Damage
    }
}