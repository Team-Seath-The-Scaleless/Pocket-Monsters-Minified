namespace Abilities
{
    using System;

    public class Firebreath : SpecialAbility
    {
        public const int FirebreathHeal = 2;

        public const int FirebreathDamage = 3; // if pokemon max health = ~20/30.

        public const int FirebreathHitChance = 8;

        public const int FirebreathCooldown = 1;
        
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

        

        // do dmg+heal method , allyCurrentHP + FlamebreathHeal  and EnemyCurrentHP - Flamebreath Damage
    }
}