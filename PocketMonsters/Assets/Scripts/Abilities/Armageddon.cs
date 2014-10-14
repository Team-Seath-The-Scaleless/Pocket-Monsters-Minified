namespace Abilities
{
    using System;

    public class Armageddon : SpecialAbility
    {
        private int armageddonDamage = 15; 

        public const int ArmageddonHitChance = 3;

        private int armageddonCooldown = 4;

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

        public int ArmageddonDamage
        {
            get
            {
                return this.armageddonDamage;
            }
        }

        public int ArmageddonCooldown
        {
            get
            {
                return this.armageddonCooldown;
            }
        }
    }
}