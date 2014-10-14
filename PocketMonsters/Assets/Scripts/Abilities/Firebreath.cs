namespace Abilities
{
    using System;

    public class Firebreath : SpecialAbility
    {
        private int firebreathHeal = 2;

        private int firebreathDamage = 3; 

        public const int FirebreathHitChance = 8;

        private int firebreathCooldown = 1;
        
        private bool firebreathHit;

        private string firebreathOnHit = "The force of fire stole some hit points from your enemy!";

        private string firebreathOnMiss = "Firebreath has missed the target!";

        protected Firebreath(int firebreathHeal, int firebreathDamage, int firebreathCooldown)
            : base(AbilityType.Battle, FirebreathHitChance)
        {
            this.firebreathHit = this.TargetIsHit();
        }

        public string FirebreathOnHit
        {
            get
            {
                return this.firebreathOnHit;
            }
        }

        public string FirebreathOnMiss
        {
            get
            {
                return this.firebreathOnMiss;
            }
        }

        public int FirebreathDamage
        {
            get
            {
                return this.firebreathDamage;
            }
        }

        public int FirebreathHeal
        {
            get
            {
                return this.firebreathHeal;
            }
        }

        public int FirebreathCooldown
        {
            get
            {
                return this.firebreathCooldown;
            }
        }

        
    }
}