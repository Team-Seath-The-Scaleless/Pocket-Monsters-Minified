namespace Abilities
{
    using System;

    public class Aftershock : SpecialAbility
    {
        public const int AftershockDamage = 8; // if pokemon max health = ~20/30.

        public const int AftershockHitChance = 7;

        public const int AftershockCooldown = 2;

        private bool aftershockHit;

        private string aftershockOnHit = "The ground starts splashing sonic waves and hits the enemy!";

        private string aftershockOnMiss = "Aftershock has missed the target!";

        protected Aftershock(int aftershockDamage, int aftershockCooldown)
            : base(AbilityType.Battle, AftershockHitChance)
        {
            this.aftershockHit = this.TargetIsHit();
        }
        // do dmg method , enemyCurrentHP - AftershockDamage 

        public string AftershockOnHit
        {
            get
            {
                return this.aftershockOnHit;
            }
        }

        public string AftershockOnMiss
        {
            get
            {
                return this.aftershockOnMiss;
            }
        }

    }
}