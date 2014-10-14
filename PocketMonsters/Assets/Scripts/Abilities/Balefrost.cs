namespace Abilities
{
    using System;

    public class Balefrost : SpecialAbility
    {
        public const int BalefrostDamage = 7; // if pokemon max health = ~20/30.

        public const int BalefrostHitChance = 8;

        public const int BalefrostCooldown = 3;

        private bool balefrostHit;

        private string balefrostOnHit = "Huge ice spikes shatter the ground and hit the enemy!";

        private string balefrostOnMiss = "Balefrost has missed the target!";

        protected Balefrost(int balefrostDamage, int balefrostCooldown)
            : base(AbilityType.Battle, BalefrostHitChance)
        {
            this.balefrostHit = this.TargetIsHit();
        }
        // do dmg method , enemyCurrentHP - BalefrostDamage 

        public string BalefrostOnHit
        {
            get
            {
                return this.balefrostOnHit;
            }
        }

        public string BalefrostOnMiss
        {
            get
            {
                return this.balefrostOnMiss;
            }
        }

    }
}