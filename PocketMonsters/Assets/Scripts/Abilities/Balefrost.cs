namespace Abilities
{
    using System;

    public class Balefrost : SpecialAbility
    {
        private int balefrostDamage = 7; 

        public const int BalefrostHitChance = 8;

        private int balefrostCooldown = 3;

        private bool balefrostHit;

        private string balefrostOnHit = "Huge ice spikes shatter the ground and hit the enemy!";

        private string balefrostOnMiss = "Balefrost has missed the target!";

        protected Balefrost(int balefrostDamage, int balefrostCooldown)
            : base(AbilityType.Battle, BalefrostHitChance)
        {
            this.balefrostHit = this.TargetIsHit();
        }
       
        public string BalefrostOnHit
        {
            get
            {
                return this.balefrostOnHit;
            }
        }

        public string BalefrostOnMiss
        {
            get
            {
                return this.balefrostOnMiss;
            }
        }

        public int BalefrostDamage
        {
            get
            {
                return this.balefrostDamage;
            }
        }

        public int BalefrostCooldown
        {
            get
            {
                return this.balefrostCooldown;
            }
        }
    }
}