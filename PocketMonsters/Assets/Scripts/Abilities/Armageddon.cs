namespace Abilities
{
    using System;

    public class Armageddon : SpecialAbility
    {
        public const int ArmageddonDamage = 15; // if pokemon max health = ~20/30.

        public const int ArmageddonHitChance = 3;

        public const int ArmageddonCooldown = 4;

        private bool armageddonHit;

        private string armageddonOnHit = "The unstopable flames burn everything around!";

        private string armageddonOnMiss = "Summoning Armageddon failed!";

        protected Armageddon(int armageddonDamage, int armageddonCooldown)
            : base(AbilityType.Battle, ArmageddonHitChance)
        {
            this.armageddonHit = this.TargetIsHit();
        }

        public string ArmageddonOnHit
        {
            get
            {
                return this.armageddonOnHit;
            }
        }

        public string ArmageddonOnMiss
        {
            get
            {
                return this.armageddonOnMiss;
            }
        }

        // do dmg method , enemyCurrentHP - ArmageddonDamage 
    }
}