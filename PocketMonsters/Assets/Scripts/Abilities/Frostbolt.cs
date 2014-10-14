namespace Abilities
{
    using System;

    public class Frostbolt : SpecialAbility
    {
        private int frostboltDamage = 4; 

        public const int FrostboltHitChance = 9;

        private int frostboltCooldown = 1;

        private bool frostboltHit;

        private string frostboltOnHit = "The target has been hit by a massive frostbolt!";

        private string frostboltOnMiss = "Frostbolt has missed the target!";

        protected Frostbolt(int frostboltDamage, int frostboltCooldown)
            : base(AbilityType.Battle, FrostboltHitChance)
        {
            this.frostboltHit = this.TargetIsHit();
        }
        
        public string FrostboltOnHit
        {
            get
            {
                return this.frostboltOnHit;
            }
        }

        public string FrostboltOnMiss
        {
            get
            {
                return this.frostboltOnMiss;
            }
        }

        public int FrostboltDamage
        {
            get
            {
                return this.frostboltDamage;
            }
        }

        public int FrostboltCooldown
        {
            get
            {
                return this.frostboltCooldown;
            }
        }

    }
}