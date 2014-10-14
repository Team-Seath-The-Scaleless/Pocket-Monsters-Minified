namespace Abilities
{
    using System;

    public class Cataclysm : SpecialAbility
    {
        public const int CataclysmDamage = 100; // if pokemon max health = ~20/30.

        public const int CataclysmHitChance = 1;

        public const int CataclysmCooldown = 5;

        private bool cataclysmHit;

        private string cataclysmOnHit = "A massive hole from the ground devours enemy unit!";

        private string cataclysmOnMiss = "Cataclysm has failed to begin!";

        protected Cataclysm(int frostboltDamage, int frostboltCooldown)
            : base(AbilityType.Battle, CataclysmHitChance)
        {
            this.cataclysmHit = this.TargetIsHit();
        }
        // do dmg method , enemyCurrentHP - CataclysmDamage (100% of enemy HP) 

        public string CataclysmOnHit
        {
            get
            {
                return this.cataclysmOnHit;
            }
        }

        public string CataclysmOnMiss
        {
            get
            {
                return this.cataclysmOnMiss;
            }
        }

    }
}