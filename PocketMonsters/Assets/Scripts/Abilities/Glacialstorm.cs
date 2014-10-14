namespace Abilities
{
    using System;

    public class Glacialstorm : SpecialAbility
    {
        private int glacialstormDamage = 10; 

        public const int GlacialstormHitChance = 9;

        private int glacialstormCooldown = 5;

        private bool glacialstormHit;

        private string glacialstormOnHit = "The Glacial Storm freezes your enemy blood!";

        private string glacialstormOnMiss = "Glacial Storm failed to hit!";

        protected Glacialstorm(int glacialstormDamage, int glacialstormCooldown)
            : base(AbilityType.Battle, GlacialstormHitChance)
        {
            this.glacialstormHit = this.TargetIsHit();
        }
        
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

        public int GlacialstormDamage
        {
            get
            {
                return this.glacialstormDamage;
            }
        }

        public int GlacialstormCooldown
        {
            get
            {
                return this.glacialstormCooldown;
            }
        }

    }
}