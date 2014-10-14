namespace Abilities
{
    using System;

    public class Eruption : SpecialAbility
    {
        private int eruptionDamage = 7; 

        private int eruptionHeal = 5;

        public const int EruptionHitChance = 5;

        private int eruptionCooldown = 4;

        private bool eruptionHit;

        private string eruptionOnHit = "The lava waves damages the enemy and restore your health!";

        private string eruptionOnMiss = "Eruption has missed the target!";

        protected Eruption(int eruptionDamage, int eruptionHeal,  int eruptionCooldown)
            : base(AbilityType.Battle, EruptionHitChance)
        {
            this.eruptionHit = this.TargetIsHit();
        }
       
        public string EruptionOnHit
        {
            get
            {
                return this.eruptionOnHit;
            }
        }

        public string EruptionMiss
        {
            get
            {
                return this.eruptionOnMiss;
            }
        }

        public int EruptionDamage
        {
            get
            {
                return this.eruptionDamage;
            }
        }

        public int EruptionHeal
        {
            get
            {
                return this.eruptionHeal;
            }
        }

        public int EruptionCooldown
        {
            get
            {
                return this.eruptionCooldown;
            }
        }
    }
}