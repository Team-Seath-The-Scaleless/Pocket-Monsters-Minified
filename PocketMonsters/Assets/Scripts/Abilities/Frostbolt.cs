namespace Abilities
{
    using System;

    public class Frostbolt : SpecialAbility
    {
        public const int FrostboltDamage = 4; // if pokemon max health = ~20/30.

        public const int FrostboltHitChance = 9;

        public const int FrostboltCooldown = 1;

        private bool frostboltHit;

        private string frostboltOnHit = "The target has been hit by a massive frostbolt!";

        private string frostboltOnMiss = "Frostbolt has missed the target!";

        protected Frostbolt(int frostboltDamage, int frostboltCooldown)
            : base(AbilityType.Battle, FrostboltHitChance)
        {
            this.frostboltHit = this.TargetIsHit();
        }
        // do dmg method , enemyCurrentHP - FrostBoltDamage 

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

    }
}