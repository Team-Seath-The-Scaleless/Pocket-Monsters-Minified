namespace Abilities
{
    using System;

    public class Eruption : SpecialAbility
    {
        public const int EruptionDamage = 7; // if pokemon max health = ~20/30.

        public const int EruptionHeal = 5;

        public const int EruptionHitChance = 5;

        public const int EruptionCooldown = 4;

        private bool eruptionHit;

        private string eruptionOnHit = "The lava waves damages the enemy and restore your health!";

        private string eruptionOnMiss = "Eruption has missed the target!";

        protected Eruption(int eruptionDamage, int eruptionHeal,  int eruptionCooldown)
            : base(AbilityType.Battle, EruptionHitChance)
        {
            this.eruptionHit = this.TargetIsHit();
        }
        // do dmg method , enemyCurrentHP - EruptionDamage  , allyCurrentHP + EruptionHeal

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

    }
}