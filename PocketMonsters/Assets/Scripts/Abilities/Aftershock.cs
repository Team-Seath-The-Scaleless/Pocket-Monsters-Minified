namespace Abilities
{
    using System;

    public class Aftershock : SpecialAbility
    {
        private int aftershockDamage = 8; 

        public const int AftershockHitChance = 7;

        private int aftershockCooldown = 2;

        private bool aftershockHit;

        private string aftershockOnHit = "The ground starts splashing sonic waves and hits the enemy!";

        private string aftershockOnMiss = "Aftershock has missed the target!";

        protected Aftershock(int aftershockDamage, int aftershockCooldown)
            : base(AbilityType.Battle, AftershockHitChance)
        {
            this.aftershockHit = this.TargetIsHit();
        }
       
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

        public int AftershockDamage
        {
            get
            {
                return this.aftershockDamage;
            }
        }

        public int AftershockCooldown
        {
            get
            {
                return this.aftershockCooldown;
            }
        }

    }
}