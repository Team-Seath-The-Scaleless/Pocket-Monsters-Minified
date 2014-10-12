namespace Abilities
{
    using System;

    public class Thundershock : SpecialAbility
    {
        public const int ThundershockDamage = 5; // if pokemon max health = ~20/30.

        public const int ThundershockHitChance = 8;

        private bool thundershockHit;

        protected Thundershock(int thundershockDamage)
            : base(AbilityType.Battle, ThundershockHitChance)
        {
            this.thundershockHit = this.TargetIsHit();
        }

        // do dmg method , enemyCurrentHP - ThundershockDamage 
    }
}
