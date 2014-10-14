namespace Abilities
{
    using System;

    public class Supernova : SpecialAbility
    {
        private int supernovaDamage = 10; // if pokemon max health = ~20/30.

        public const int SupernovaHitChance = 5;

        private int supernovaCooldown = 3;
        
        private bool supernovaHit;

        private string supernovaOnHit = "The Supernova released the ultimate force!";

        private string supernovaOnMiss = "Supernova has missed the target!";

        protected Supernova(int supernovaDamage, int supernovaCooldown)
            : base(AbilityType.Battle, SupernovaHitChance)
        {
            this.supernovaHit = this.TargetIsHit();
        }

        public string SupernovaOnHit
        {
            get
            {
                return this.supernovaOnHit;
            }
        }

        public string SupernovaOnMiss
        {
            get
            {
                return this.supernovaOnMiss;
            }
        }

        public int SupernovaDamage
        {
            get
            {
                return this.supernovaDamage;
            }
        }

        public int SupernovaCooldown
        {
            get
            {
                return this.supernovaCooldown;
            }
        }
    }
}