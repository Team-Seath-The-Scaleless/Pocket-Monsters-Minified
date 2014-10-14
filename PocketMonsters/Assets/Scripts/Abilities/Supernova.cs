namespace Abilities
{
    using System;

    public class Supernova : SpecialAbility
    {
        public const int SupernovaDamage = 10; // if pokemon max health = ~20/30.

        public const int SupernovaHitChance = 5;

        public const int SupernovaCooldown = 3;
        
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

        public string ThundershockOnMiss
        {
            get
            {
                return this.supernovaOnMiss;
            }
        }
        // do dmg method , enemyCurrentHP - SupernovaDamage 
    }
}