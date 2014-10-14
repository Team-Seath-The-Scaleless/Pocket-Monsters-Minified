namespace Abilities
{
    using System;

    public class Glacialstorm : SpecialAbility
    {
        public const int GlacialstormDamage = 10; // if pokemon max health = ~20/30.

        public const int GlacialstormHitChance = 9;

        public const int GlacialstormCooldown = 5;

        private bool glacialstormHit;

        private string glacialstormOnHit = "The Glacial Storm freezes your enemy blood!";

        private string glacialstormOnMiss = "Glacial Storm failed to hit!";

        protected Glacialstorm(int glacialstormDamage, int glacialstormCooldown)
            : base(AbilityType.Battle, GlacialstormHitChance)
        {
            this.glacialstormHit = this.TargetIsHit();
        }
        // do dmg method , enemyCurrentHP - GlacialstormDamage 

        public string GlacialstormOnHit
        {
            get
            {
                return this.glacialstormOnHit;
            }
        }

        public string GlacialstormOnMiss
        {
            get
            {
                return this.glacialstormOnMiss;
            }
        }

    }
}